using System;
using System.Windows.Forms;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System.Collections.Generic;

namespace PageExtractionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSearchText.ReadOnly = rdoNumber.Checked || rdoRange.Checked;
            txtFrom.ReadOnly = txtTo.ReadOnly = rdoNumber.Checked || rdoSearch.Checked;
            txtPageNumbers.ReadOnly = rdoRange.Checked || rdoSearch.Checked;
            txtTo.Minimum = 1;
            txtFrom.Minimum = 1;
            txtFrom.Value = 1;
            txtTo.Value = 1;
            txtSearchText.Text = String.Empty;
        }

        private void rdoRange_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchText.ReadOnly = rdoNumber.Checked || rdoRange.Checked;
            txtFrom.ReadOnly = txtTo.ReadOnly = rdoNumber.Checked || rdoSearch.Checked;
            txtPageNumbers.ReadOnly = rdoRange.Checked || rdoSearch.Checked;
        }

        private void rdoNumber_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchText.ReadOnly = rdoNumber.Checked || rdoRange.Checked;
            txtFrom.ReadOnly = txtTo.ReadOnly = rdoNumber.Checked || rdoSearch.Checked;
            txtPageNumbers.ReadOnly = rdoRange.Checked || rdoSearch.Checked;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
            fd.InitialDirectory = @"C:\";
            fd.Title = "Please select a PDF file to upload.";
            fd.Multiselect = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = fd.FileName;
                txtTo.Maximum = new Document(fd.FileName).Pages.Count;
                txtSearchText.Text = String.Empty;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text != String.Empty)
            {
                Document doc = new Document(txtFilePath.Text);
                Document newDoc = new Document();
                if (rdoRange.Checked)
                {
                    for (decimal i = txtFrom.Value; i <= txtTo.Value; i++)
                    {
                        newDoc.Pages.Add(doc.Pages[Convert.ToInt32(i)]);
                    }
                    newDoc.Save("output_" + DateTime.Now.Millisecond + ".pdf");
                    MessageBox.Show("Document has been created.", "Success");
                }
                else if (rdoNumber.Checked)
                {
                    try
                    {
                        string[] pages = txtPageNumbers.Text.Split(',');
                        foreach (string s in pages)
                        {
                            newDoc.Pages.Add(doc.Pages[Convert.ToInt32(s)]);
                        }
                        newDoc.Save("output_" + DateTime.Now.Millisecond + ".pdf");
                        MessageBox.Show("Document has been created.", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in processing Page Numbers. Some values are not in correct format.\n" + ex.Message, "Error");
                    }
                }
                else
                {
                    if (txtSearchText.Text != String.Empty)
                    {
                        TextFragmentAbsorber absorber = new TextFragmentAbsorber(txtSearchText.Text, new TextSearchOptions(true));
                        doc.Pages.Accept(absorber);
                        TextFragmentCollection collection = absorber.TextFragments;
                        List<int> pagenumbers = new List<int>();
                        if(collection.Count > 0)
                        {
                            foreach(TextFragment textFragment in collection)
                            {
                                if(pagenumbers.Contains(textFragment.Page.Number))
                                {
                                    continue;
                                }
                                else
                                {
                                    pagenumbers.Add(textFragment.Page.Number);
                                }
                            }
                            foreach (int s in pagenumbers)
                            {
                                newDoc.Pages.Add(doc.Pages[s]);
                            }
                            newDoc.Save("output_" + DateTime.Now.Millisecond + ".pdf");
                            MessageBox.Show("Document has been created.", "Success");
                        }
                        else
                        {
                            MessageBox.Show("No Results found against Search.", "No Results");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a Search Term.", "No Search Term");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a PDF File First.", "File Not Found");
            }
        }

        private void rdoSearch_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchText.ReadOnly = rdoNumber.Checked || rdoRange.Checked;
            txtFrom.ReadOnly = txtTo.ReadOnly = rdoNumber.Checked || rdoSearch.Checked;
            txtPageNumbers.ReadOnly = rdoRange.Checked || rdoSearch.Checked;
        }
    }
}
