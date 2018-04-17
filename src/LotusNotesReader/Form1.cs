using Domino;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LotusNotesReader
{
    public partial class Form1 : Form
    {
        NotesDatabase _db = null;
        List<string> _universalIDList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ListAvailableView()
        {
            UpdateText(lblStatus, "Listing available view(s)...");

            cboView.Items.Clear();
            rtbOutput.Clear();

            NotesSession session = new NotesSession();
            session.Initialize("");

            _db = session.GetDatabase("", txtNsfFilePath.Text, false);

            foreach (NotesView view in GetNotesView(_db))
            {
                if (view != null)
                {
                    if (cboView.Items.Contains(view.Name) == false)
                    {
                        cboView.Items.Add(view.Name);
                    }
                }
            }

            if (cboView.Items.Count > 0)
            {
                cboView.Items.Insert(0, "--All--");
                cboView.SelectedIndex = 0;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var startTime = DateTime.Now;
            UpdateText(lblStartTime, startTime.ToString("yyyy-MM-dd HH:mm:ss.ffffff"));

            UpdateText(lblStatus, "Searching...");

            try
            {
                btnOpenNsf.Enabled = false;
                btnSearch.Enabled = false;
                txtSearch.Enabled = false;
                cboView.Enabled = false;
                rtbOutput.Enabled = false;

                rtbOutput.Clear();

                _universalIDList.Clear();

                if (txtNsfFilePath.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please select a nsf file");
                    return;
                }

                string searchText = txtSearch.Text.ToLower();
                string path = DateTime.Now.ToString("yyMMddHHmmssffffff") + "-{0}.log";

                foreach (NotesView view in GetNotesView(_db))
                {
                    if (view == null) continue;

                    if (cboView.SelectedIndex > 0)
                    {
                        if (view.Name != cboView.SelectedItem.ToString()) continue;
                    }

                    var output = ProcessNotesView(view, searchText);

                    if (output != null && output.Count > 0)
                    {

                        long index = 1;

                        UpdateText(lblOutputTotal, output.Count.ToString());

                        try
                        {
                            AppendText(rtbOutput, $">>> {view.Name} ({output.Count}) <<<" + Environment.NewLine + Environment.NewLine);

                            var logPath = string.Format(path, view.Name);

                            using (StreamWriter sw = new StreamWriter(logPath))
                            {
                                foreach (string value in output.Values)
                                {
                                    UpdateText(lblOutputCount, index.ToString());

                                    if (string.IsNullOrEmpty(value) == false && value.Trim().Length > 0)
                                    {
                                        sw.WriteLine(value + Environment.NewLine + Environment.NewLine);

                                        // Don't display live because string concatenation too slow
                                        //AppendText(rtbOutput, value + Environment.NewLine + Environment.NewLine);
                                        //Application.DoEvents();
                                    }

                                    index++;
                                }

                                sw.Close();

                                if (File.Exists(logPath))
                                {
                                    rtbOutput.LoadFile(logPath, RichTextBoxStreamType.PlainText);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        output.Clear();
                    }
                }

                var endTime = DateTime.Now;
                UpdateText(lblEndTime, endTime.ToString("yyyy-MM-dd HH:mm:ss.ffffff"));

                var elapsedTime = new DateTime((endTime - startTime).Ticks);
                UpdateText(lblElapsedTime, string.Format("{0:HH}H {0:mm}M {0:ss}.{0:ffffff}S", elapsedTime));

                MessageBox.Show("Search Completed.");
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
                rtbOutput.Enabled = true;

                UpdateText(lblStatus, "Search Completed!");
            }
        }

        private Dictionary<string, string> ProcessNotesView(NotesView notesView, string searchText)
        {
            Dictionary<string, string> entryOutput = new Dictionary<string, string>();

            foreach (var entry in GetNotesViewEntry(notesView))
            {
                //Application.DoEvents();

                if (entry == null) continue;

                // Skip the entry if already processed
                if (_universalIDList.Contains(entry.UniversalID)) continue;
                //if (entryOutput.ContainsKey(entry.UniversalID)) continue;

                var entryContent = ProcessNotesViewEntry(entry, searchText);

                if (string.IsNullOrEmpty(entryContent) == false && entryContent.Trim().Length > 0)
                {
                    _universalIDList.Add(entry.UniversalID);

                    entryOutput.Add(entry.UniversalID, entryContent);
                    //Application.DoEvents();
                }
            }

            return entryOutput;
        }

        private string ProcessNotesViewEntry(NotesViewEntry entry, string searchText)
        {
            StringBuilder sbEvents = new StringBuilder();

            //string updatedBy = string.Empty;
            //string startTime = string.Empty;
            //string finishTime = string.Empty;
            //string form = string.Empty;

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
                        foreach (var eventStr in item.Text.Split(';'))
                        {
                            if (eventStr == string.Empty || eventStr.ToLower().IndexOf(searchText) >= 0)
                            {
                                sbEvents.AppendLine(eventStr);
                            }
                        }
                        break;
                }
            }

            return sbEvents.ToString();

            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"UniversalID - {entry.UniversalID}");
            //sb.AppendLine(updatedBy);
            //sb.AppendLine(startTime);
            //sb.AppendLine(finishTime);
            //sb.AppendLine(form);
            //sb.Append(sbEvents.ToString());
            //sb.AppendLine();
            //sb.AppendLine();
        }


        //private IEnumerable<NotesDocument> GetNotesDocument(NotesDatabase db)
        //{
        //    UpdateText(lblStatus, "Get Notes Documents...");

        //    NotesDocumentCollection col = db.AllDocuments;
        //    NotesDocument doc = col.GetFirstDocument();

        //    while (doc != null)
        //    {
        //        yield return doc;

        //        doc = col.GetNextDocument(doc);
        //    }

        //    UpdateText(lblStatus, "Get Notes Documents Completed.");

        //    yield return null;
        //}

        private IEnumerable<NotesView> GetNotesView(NotesDatabase db)
        {
            var viewList = (object[])db.Views;
            long index = 1;

            if (viewList.LongLength > 0)
            {
                UpdateText(lblStatus, "Get Notes Views...");

                UpdateText(lblNotesViewTotal, viewList.LongLength.ToString());

                foreach (var view in viewList)
                {
                    UpdateText(lblNotesViewCount, index.ToString());

                    yield return (NotesView)view;

                    index++;

                    UpdateText(lblStatus, "Get Next Notes Views...");

                    //Application.DoEvents();
                }

                UpdateText(lblStatus, "Get Notes Views Completed.");
            }
        }

        private IEnumerable<NotesViewEntry> GetNotesViewEntry(NotesView nv)
        {
            NotesViewEntryCollection col = nv.AllEntries;

            if (col.Count > 0)
            {
                UpdateText(lblStatus, "Get Notes Entries...");

                UpdateText(lblNotesEntryTotal, col.Count.ToString());

                for (int index = 1; index <= col.Count; index++)
                {
                    UpdateText(lblNotesEntryCount, index.ToString());

                    NotesViewEntry entry = col.GetNthEntry(index);
                    yield return entry;

                    UpdateText(lblStatus, "Get Next Notes Entries...");

                    //Application.DoEvents();
                }

                UpdateText(lblStatus, "Get Notes Entries Completed.");
            }
        }

        private IEnumerable<NotesItem> GetNoteItem(NotesDocument doc)
        {
            Array itemArray = (Array)doc.Items;

            if (itemArray.Length > 0)
            {
                UpdateText(lblStatus, "Get Notes Items...");

                UpdateText(lblNotesItemTotal, itemArray.Length.ToString());

                for (int index = 0; index < itemArray.Length; index++)
                {
                    UpdateText(lblNotesItemCount, (index + 1).ToString());

                    NotesItem item = (NotesItem)itemArray.GetValue(index);
                    yield return item;

                    UpdateText(lblStatus, "Get Next Notes Items...");

                    //Application.DoEvents();
                }

                UpdateText(lblStatus, "Get Notes Items Completed.");
            }
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

        private void UpdateText(Control control, string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Control, string>(UpdateText), new object[] { control, value });
                return;
            }

            control.Text = value;
            Application.DoEvents();
        }

        private void AppendText(Control control, string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Control, string>(UpdateText), new object[] { control, value });
                return;
            }

            control.Text += value;
            Application.DoEvents();
        }
    }
}
