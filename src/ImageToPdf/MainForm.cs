using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp;

namespace ImageToPdf
{
    public partial class MainForm : Form
    {

        bool success = false;

        public MainForm()
        {
            InitializeComponent();
            //
            initCtrls();
        }

        #region form events
        private void btnSelectSrc_Click(object sender, EventArgs e)
        {
            if (ofdSrcFile.ShowDialog() != DialogResult.OK)
                return;

            toolStripStatusLabel1.Text = "";

            initCtrls();

            listBox1.Items.Clear();
            foreach (string fName in ofdSrcFile.FileNames) listBox1.Items.Add(fName);
            listBox1.SelectedIndex = 0;
            txbxDestFile.Text =
                Path.GetDirectoryName((string)listBox1.Items[0]) + "\\" +
                GetCommonPart(listBox1.Items) + ".pdf";
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {
            if (sfdDestFile.ShowDialog() != DialogResult.OK)
                return;
            toolStripStatusLabel1.Text = "";

            txbxDestFile.Text = sfdDestFile.FileName;
        }

        private void buttonPreviewSource_Click(object sender, EventArgs e)
        {
            errProv.Clear();

            if (listBox1.Items.Count == 0)
            {
                errProv.SetError(btnSelectSrc, toolStripStatusLabel1.Text = "Please point source file(s).");
                return;
            }
            else if (listBox1.SelectedIndex < 0)
            {
                errProv.SetError(listBox1, toolStripStatusLabel1.Text = "Please select source file to preview.");
                return;
            }

            try
            {
                foreach (string s in listBox1.SelectedItems)
                    Process.Start(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPreviewDest_Click(object sender, EventArgs e)
        {
            errProv.Clear();

            if (txbxDestFile.Text.Length == 0)
            {
                errProv.SetError(btnSelectDest, "Please point destination file.");
                return;
            }

            try
            {
                Process.Start(txbxDestFile.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
            CheckDestination();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
            CheckDestination();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            errProv.Clear();


            if (listBox1.Items.Count == 0)
            {
                errProv.SetError(listBox1, toolStripStatusLabel1.Text = "Please point source file(s).");
                return;
            }

            if (!checkBoxSeparate.Checked)
            {
                if (txbxDestFile.Text.Length == 0)
                {
                    errProv.SetError(txbxDestFile, toolStripStatusLabel1.Text = "Please point destination file.");
                    return;
                }
                else if (File.Exists(txbxDestFile.Text))
                {
                    if (MessageBox.Show("Overwrite file " + txbxDestFile.Text,
                        toolStripStatusLabel1.Text = "Destination file exists",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
                    {
                        return;
                    }
                }
            }

            success = false;
            List<string> l = new List<string>();
            //      1st argument = destination file

            l.Add(txbxDestFile.Text);

            //      Rest arguments = source files in required order
            foreach (string f in listBox1.Items)
                l.Add(f);

            bw.RunWorkerAsync(l.ToArray());
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

        }

        private void button1Clr_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            CheckDestination();
        }

        private void checkBoxSeparate_CheckedChanged(object sender, EventArgs e)
        {
            CheckDestination();
            checkBoxAutoPreviewDest.Checked = false;
        }

        private void txbxDestFile_TextChanged(object sender, EventArgs e)
        {
            btnConvert.Enabled = checkBoxDeleteSource.Enabled = true;
            buttonPreviewDest.Enabled = File.Exists(txbxDestFile.Text);
        }
        #endregion

        #region ListBox
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if ((listBox1.Items.Count > 0) & (listBox1.SelectedIndex >= 0))
                Process.Start((string)listBox1.SelectedItems[0]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDown.Enabled = buttonUp.Enabled = buttonPreviewSource.Enabled = true;
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listBox1.Items.Count > 0 && listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                CheckDestination();
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < s.Length; i++)
            {
                try
                {
                    // accept only files specified in the filer
                    FileInfo fi = new FileInfo(s[i]);
                    if (ofdSrcFile.Filter.Contains(fi.Extension.ToUpper()))
                        listBox1.Items.Add(s[i]);
                }
                catch { }
            }
            CheckDestination();
        }
        #endregion

        #region work
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string[] fNames = (e.Argument as string[]);
                var page = new PdfPage();
                var mediaBox = page.MediaBox;
                if (checkBoxSeparate.Checked)
                {

                    for (int i = 1; i < fNames.Length; i++)
                    {
                        // each source file saeparate
                        PdfDocument doc = new PdfDocument();
                        toolStripStatusLabel1.Text = "Processing " + fNames[i];                        

                        doc.Pages.Add(new PdfPage());
                        XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[i - 1]);
                        XImage img = XImage.FromFile(fNames[i]);
                        FixedSize(img, xgr, mediaBox.Width, mediaBox.Height);
                     
                        img.Dispose();
                        xgr.Dispose();
                        //  save to destination file
                        FileInfo fi = new FileInfo(fNames[i]);

                        doc.Save(fi.FullName.Replace(fi.Extension, ".PDF"));
                        doc.Close();
                    }

                }
                else
                {
                    // single document
                    PdfDocument doc = new PdfDocument();

                    for (int i = 1; i < fNames.Length; i++)
                    {
                        toolStripStatusLabel1.Text = "Processing " + fNames[i];
                        // each source on separate page

                        doc.Pages.Add(new PdfPage());
                        XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[i - 1]);
                        XImage img = XImage.FromFile(fNames[i]);
                        FixedSize(img, xgr, mediaBox.Width, mediaBox.Height);
                        img.Dispose();
                        xgr.Dispose();
                    }

                    //  save to destination file
                    doc.Save(fNames[0]);
                    doc.Close();
                }
                success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected void FixedSize(XImage imgPhoto, XGraphics xgr, double Width, double Height)
        {
            int sourceWidth = imgPhoto.PixelWidth;
            int sourceHeight = imgPhoto.PixelHeight;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width -
                              (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            xgr.DrawImage(imgPhoto,
                0, 0, destWidth, destHeight);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
            toolStripProgressBar1.Value = 0;

            Boolean anyErr = false;
            if (checkBoxDeleteSource.Checked)
            {
                foreach (string fName in listBox1.Items)
                {
                    try
                    {
                        toolStripStatusLabel1.Text = "Deleting " + fName;
                        File.Delete(fName);
                    }
                    catch
                    {
                        anyErr = true;
                    }
                }
                listBox1.Items.Clear();
            }

            if (checkBoxAutoPreviewDest.Checked && File.Exists(txbxDestFile.Text))
            {
                Process.Start(txbxDestFile.Text);
            }

            if (success && !anyErr)
            {
                initCtrls();
                toolStripStatusLabel1.Text = "The converion ended successfully.";
            }
            else
            {
                toolStripStatusLabel1.Text = "WARNING! Some errors during converion !";
            }
        }
        #endregion

        #region utils
        public void MoveItem(int direction)
        {
            // Checking selected item
            if (listBox1.SelectedItem == null || listBox1.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBox1.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox1.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBox1.SelectedItem;

            // Removing removable element
            listBox1.Items.Remove(selected);
            // Insert it in new position
            listBox1.Items.Insert(newIndex, selected);
            // Restore selection
            listBox1.SetSelected(newIndex, true);
        }

        private void initCtrls()
        {
            errProv.Clear();
            toolStripStatusLabel1.Text = "";
            buttonPreviewSource.Enabled = false;
            buttonUp.Enabled =
            buttonDown.Enabled = (listBox1.Items.Count > 0);
            CheckDestination();
        }

        private string GetCommonPart(ListBox.ObjectCollection fnames)
        {
            string res = "";
            try
            {
                res = Path.GetFileNameWithoutExtension(fnames[0].ToString());
                if (fnames.Count > 1)
                {
                    int posOfCommonPart = -1;
                    string f1 = Path.GetFileNameWithoutExtension(fnames[0].ToString());
                    for (int j = 1; j < fnames.Count; j++)
                    {
                        string f2 = Path.GetFileNameWithoutExtension(fnames[j].ToString());
                        for (int i = Math.Min(f1.Length, f2.Length); i > 0; i--)
                        {
                            if (f1.Substring(0, i) == f2.Substring(0, i))
                            {
                                if (posOfCommonPart > 0)
                                    posOfCommonPart = Math.Min(posOfCommonPart, i);
                                else
                                    posOfCommonPart = i;

                                break;
                            }
                        }
                    }
                    if (posOfCommonPart > 0)
                    {
                        res = f1.Substring(0, posOfCommonPart);
                    }
                }
            }
            catch { }
            return res;
        }

        private void CheckDestination()
        {
            txbxDestFile.Enabled = btnSelectDest.Enabled = buttonPreviewDest.Enabled = !checkBoxSeparate.Checked;


            if (!checkBoxSeparate.Checked && listBox1.Items.Count > 0)
            {
                txbxDestFile.Text = Path.GetDirectoryName((string)listBox1.Items[0]) + "\\" + GetCommonPart(listBox1.Items) + ".pdf";
            }
            else
            {
                txbxDestFile.Text = "";
            }

        }
        #endregion



    }
}