namespace ImageToPdf
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSelectSrc = new System.Windows.Forms.Button();
            this.txbxDestFile = new System.Windows.Forms.TextBox();
            this.btnSelectDest = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.ofdSrcFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdDestFile = new System.Windows.Forms.SaveFileDialog();
            this.errProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.buttonPreviewSource = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1Clr = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSeparate = new System.Windows.Forms.CheckBox();
            this.buttonPreviewDest = new System.Windows.Forms.Button();
            this.checkBoxDeleteSource = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoPreviewDest = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectSrc
            // 
            this.btnSelectSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSrc.Location = new System.Drawing.Point(762, 20);
            this.btnSelectSrc.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectSrc.Name = "btnSelectSrc";
            this.btnSelectSrc.Size = new System.Drawing.Size(92, 31);
            this.btnSelectSrc.TabIndex = 0;
            this.btnSelectSrc.Text = "Upload";
            this.btnSelectSrc.UseVisualStyleBackColor = true;
            this.btnSelectSrc.Click += new System.EventHandler(this.btnSelectSrc_Click);
            // 
            // txbxDestFile
            // 
            this.txbxDestFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxDestFile.Location = new System.Drawing.Point(104, 23);
            this.txbxDestFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbxDestFile.Name = "txbxDestFile";
            this.txbxDestFile.Size = new System.Drawing.Size(699, 26);
            this.txbxDestFile.TabIndex = 4;
            this.txbxDestFile.TextChanged += new System.EventHandler(this.txbxDestFile_TextChanged);
            // 
            // btnSelectDest
            // 
            this.btnSelectDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDest.Location = new System.Drawing.Point(816, 23);
            this.btnSelectDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectDest.Name = "btnSelectDest";
            this.btnSelectDest.Size = new System.Drawing.Size(38, 31);
            this.btnSelectDest.TabIndex = 3;
            this.btnSelectDest.Text = "...";
            this.btnSelectDest.UseVisualStyleBackColor = true;
            this.btnSelectDest.Click += new System.EventHandler(this.btnSelectDest_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 353);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(879, 31);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 23);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(195, 24);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(478, 284);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(379, 62);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // ofdSrcFile
            // 
            this.ofdSrcFile.FileName = "openFileDialog1";
            this.ofdSrcFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.TIF;*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIF;*" +
    ".TIFF|All files (*.*)|*.*";
            this.ofdSrcFile.Multiselect = true;
            this.ofdSrcFile.Title = "Choose source image file";
            // 
            // sfdDestFile
            // 
            this.sfdDestFile.OverwritePrompt = false;
            this.sfdDestFile.Title = "Choose save location of PDF file";
            // 
            // errProv
            // 
            this.errProv.ContainerControl = this;
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // buttonPreviewSource
            // 
            this.buttonPreviewSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviewSource.Location = new System.Drawing.Point(10, 51);
            this.buttonPreviewSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPreviewSource.Name = "buttonPreviewSource";
            this.buttonPreviewSource.Size = new System.Drawing.Size(82, 31);
            this.buttonPreviewSource.TabIndex = 8;
            this.buttonPreviewSource.Text = "Preview";
            this.buttonPreviewSource.UseVisualStyleBackColor = true;
            this.buttonPreviewSource.Click += new System.EventHandler(this.buttonPreviewSource_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(104, 20);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(634, 118);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(10, 20);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(82, 31);
            this.buttonUp.TabIndex = 13;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(10, 82);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(82, 31);
            this.buttonDown.TabIndex = 14;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1Clr);
            this.groupBox1.Controls.Add(this.buttonUp);
            this.groupBox1.Controls.Add(this.buttonDown);
            this.groupBox1.Controls.Add(this.btnSelectSrc);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.buttonPreviewSource);
            this.groupBox1.Location = new System.Drawing.Point(4, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(875, 149);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source file(s)";
            // 
            // button1Clr
            // 
            this.button1Clr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Clr.Location = new System.Drawing.Point(762, 51);
            this.button1Clr.Margin = new System.Windows.Forms.Padding(0);
            this.button1Clr.Name = "button1Clr";
            this.button1Clr.Size = new System.Drawing.Size(92, 31);
            this.button1Clr.TabIndex = 15;
            this.button1Clr.Text = "Clear ";
            this.button1Clr.UseVisualStyleBackColor = true;
            this.button1Clr.Click += new System.EventHandler(this.button1Clr_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxSeparate);
            this.groupBox2.Controls.Add(this.txbxDestFile);
            this.groupBox2.Controls.Add(this.btnSelectDest);
            this.groupBox2.Controls.Add(this.buttonPreviewDest);
            this.groupBox2.Location = new System.Drawing.Point(4, 161);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(875, 95);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination file";
            // 
            // checkBoxSeparate
            // 
            this.checkBoxSeparate.AutoSize = true;
            this.checkBoxSeparate.Location = new System.Drawing.Point(104, 63);
            this.checkBoxSeparate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSeparate.Name = "checkBoxSeparate";
            this.checkBoxSeparate.Size = new System.Drawing.Size(337, 24);
            this.checkBoxSeparate.TabIndex = 20;
            this.checkBoxSeparate.Text = "Each source file in separate destination file";
            this.checkBoxSeparate.UseVisualStyleBackColor = true;
            this.checkBoxSeparate.CheckedChanged += new System.EventHandler(this.checkBoxSeparate_CheckedChanged);
            // 
            // buttonPreviewDest
            // 
            this.buttonPreviewDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviewDest.Location = new System.Drawing.Point(10, 23);
            this.buttonPreviewDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPreviewDest.Name = "buttonPreviewDest";
            this.buttonPreviewDest.Size = new System.Drawing.Size(82, 31);
            this.buttonPreviewDest.TabIndex = 17;
            this.buttonPreviewDest.Text = "Preview";
            this.buttonPreviewDest.UseVisualStyleBackColor = true;
            this.buttonPreviewDest.Click += new System.EventHandler(this.buttonPreviewDest_Click);
            // 
            // checkBoxDeleteSource
            // 
            this.checkBoxDeleteSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxDeleteSource.AutoSize = true;
            this.checkBoxDeleteSource.Location = new System.Drawing.Point(104, 286);
            this.checkBoxDeleteSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxDeleteSource.Name = "checkBoxDeleteSource";
            this.checkBoxDeleteSource.Size = new System.Drawing.Size(285, 24);
            this.checkBoxDeleteSource.TabIndex = 18;
            this.checkBoxDeleteSource.Text = "Delete source file(s) after converion";
            this.checkBoxDeleteSource.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoPreviewDest
            // 
            this.checkBoxAutoPreviewDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAutoPreviewDest.AutoSize = true;
            this.checkBoxAutoPreviewDest.Checked = true;
            this.checkBoxAutoPreviewDest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoPreviewDest.Location = new System.Drawing.Point(104, 317);
            this.checkBoxAutoPreviewDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxAutoPreviewDest.Name = "checkBoxAutoPreviewDest";
            this.checkBoxAutoPreviewDest.Size = new System.Drawing.Size(288, 24);
            this.checkBoxAutoPreviewDest.TabIndex = 19;
            this.checkBoxAutoPreviewDest.Text = "Preview destination after conversion";
            this.checkBoxAutoPreviewDest.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 384);
            this.Controls.Add(this.checkBoxAutoPreviewDest);
            this.Controls.Add(this.checkBoxDeleteSource);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(589, 370);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Image => PDF Converter";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectSrc;
        private System.Windows.Forms.TextBox txbxDestFile;
        private System.Windows.Forms.Button btnSelectDest;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog ofdSrcFile;
        private System.Windows.Forms.SaveFileDialog sfdDestFile;
        private System.Windows.Forms.ErrorProvider errProv;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.Button buttonPreviewSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxDeleteSource;
        private System.Windows.Forms.Button buttonPreviewDest;
        private System.Windows.Forms.CheckBox checkBoxAutoPreviewDest;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox checkBoxSeparate;
        private System.Windows.Forms.Button button1Clr;
    }
}

