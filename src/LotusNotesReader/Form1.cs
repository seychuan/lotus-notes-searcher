using Domino;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotusNotesReader
{
    public partial class Form1 : Form
    {
        NotesSession session = new NotesSession();
        NotesDatabase db = null;

        public Form1()
        {
            InitializeComponent();

            session.Initialize("");
        }

        private void ListAvailableView()
        {
            cboView.Items.Clear();
            rtbOutput.Clear();

            db = session.GetDatabase("", txtNsfFilePath.Text, false);

            foreach (NotesView view in GetNotesView(db))
            {
                if (view != null)
                {
                    cboView.Items.Add(view.Name);
                }
            }

            if (cboView.Items.Count > 0) cboView.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtNsfFilePath.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select a nsf file");
                return;
            }



            btnOpenNsf.Enabled = false;
            btnSearch.Enabled = false;
            txtSearch.Enabled = false;
            cboView.Enabled = false;

            try
            {
                rtbOutput.Clear();

                string searchText = txtSearch.Text.ToLower();

                //NotesSession session = new NotesSession();
                //session.Initialize("");
                ////NotesDatabase db = session.GetDatabase("", @"D:\Personal\Tools\LotusNotesReader\LotusNotesReader\Database\log2.nsf", false);
                //NotesDatabase db = session.GetDatabase("", txtNsfFilePath.Text, false);
                List<string> universalIDList = new List<string>();


                foreach (NotesView view in GetNotesView(db))
                {
                    if (view == null) continue;

                    if (cboView.SelectedIndex >= 0)
                    {
                        if (view.Name != cboView.SelectedItem.ToString()) continue;
                    }


                    foreach (var entry in GetNotesViewEntry(view))
                    {
                        if (entry == null) continue;

                        // Skip the entry if already processed
                        if (universalIDList.Contains(entry.UniversalID)) continue;
                        universalIDList.Add(entry.UniversalID);

                        StringBuilder sb = new StringBuilder();
                        StringBuilder sbEvents = new StringBuilder();

                        string updatedBy = string.Empty;
                        string startTime = string.Empty;
                        string finishTime = string.Empty;
                        string form = string.Empty;

                        //sb.AppendLine($"UniversalID - {entry.UniversalID}");

                        foreach (var item in GetNoteItem(entry.Document))
                        {
                            if (item == null) continue;

                            //sb.AppendLine($"{item.Name}:\t{item.Text}");

                            switch (item.Name)
                            {
                                //case "$UpdatedBy":
                                //    updatedBy = $"{item.Name}:\t{item.Text}";
                                //    break;
                                //case "StartTime":
                                //    startTime = $"{item.Name}:\t{item.Text}";
                                //    break;
                                //case "FinishTime":
                                //    finishTime = $"{item.Name}:\t{item.Text}";
                                //    break;
                                //case "Form":
                                //    form = $"{item.Name}:\t{item.Text}";
                                //    break;
                                case "EventList":
                                    foreach(var eventStr in item.Text.Split(';'))
                                    {
                                        if (eventStr == string.Empty || eventStr.ToLower().IndexOf(searchText) >= 0)
                                        {
                                            sbEvents.AppendLine(eventStr);
                                        }
                                    }
                                    break;
                            }
                        }

                        //sb.AppendLine(updatedBy);
                        //sb.AppendLine(startTime);
                        //sb.AppendLine(finishTime);
                        //sb.AppendLine(form);
                        sb.Append(sbEvents.ToString());

                        if (sb.Length > 0)
                        {
                            //if (searchText == string.Empty || sb.ToString().ToLower().IndexOf(searchText) >= 0)
                            //{
                            rtbOutput.Text += sb.ToString() + Environment.NewLine + Environment.NewLine;
                            //}
                        }

                        Application.DoEvents();
                    }
                }

                MessageBox.Show("Search completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + Environment.NewLine + ex.Message);
            }
            finally
            {
                btnOpenNsf.Enabled = true;
                btnSearch.Enabled = true;
                txtSearch.Enabled = true;
                cboView.Enabled = true;
            }



            //NotesDocument doc = db.AllDocuments.GetFirstDocument();
            //while(doc != null)
            //{
            //    Array itemArray = (System.Array)doc.Items;

            //    StringBuilder sb = new StringBuilder();

            //    for(int index = 0; index < itemArray.Length; index++)
            //    {
            //        NotesItem item = (NotesItem)itemArray.GetValue(index);
            //        sb.AppendLine($"{item.Name} - {item.Text}");
            //    }

            //    richTextBox1.Text += sb.ToString();

            //    //doc = db.AllDocuments.GetNextDocument();
            //}




            //List<NotesView> views = new List<NotesView>();

            //foreach(var viewObject in viewsArray)
            //{


            //}

        }

        private IEnumerable<NotesDocument> GetNotesDocument(NotesDatabase db)
        {
            NotesDocumentCollection col = db.AllDocuments;

            NotesDocument doc = col.GetFirstDocument();

            while (doc != null)
            {
                yield return doc;

                doc = col.GetNextDocument(doc);
            }

            yield return null;
        }

        private IEnumerable<NotesView> GetNotesView(NotesDatabase db)
        {
            var viewList = (object[])db.Views;

            foreach(var view in viewList)
            {
                yield return (NotesView)view;

                Application.DoEvents();
            }

            yield return null;
        }

        private IEnumerable<NotesViewEntry> GetNotesViewEntry(NotesView nv)
        {
            NotesViewEntryCollection col = nv.AllEntries;

            for (int index = 1; index <= col.Count; index++)
            {
                NotesViewEntry entry = col.GetNthEntry(index);
                yield return entry;

                Application.DoEvents();
            }

            yield return null;
        }

        private IEnumerable<NotesItem> GetNoteItem(NotesDocument doc)
        {
            Array itemArray = (Array)doc.Items;

            for(int index = 0; index < itemArray.Length; index++)
            {
                NotesItem item = (NotesItem)itemArray.GetValue(index);
                yield return item;

                Application.DoEvents();
            }

            yield return null;
        }

        private void btnOpenNsf_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (txtNsfFilePath.Text != openFileDialog1.FileName)
                {
                    if (txtNsfFilePath.Text == string.Empty || MessageBox.Show(this, "Reset?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtNsfFilePath.Text = openFileDialog1.FileName;

                        ListAvailableView();
                    }
                }
            }
        }
    }
}
