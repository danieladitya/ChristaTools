namespace watermarkit {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.contextMenuPreview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPreview = new System.Windows.Forms.GroupBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.btnSourceImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.groupFiles = new System.Windows.Forms.GroupBox();
            this.checkReset = new System.Windows.Forms.CheckBox();
            this.btnResetImage = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.textTextToAdd = new System.Windows.Forms.TextBox();
            this.btnWatermark = new System.Windows.Forms.Button();
            this.textWatermark = new System.Windows.Forms.TextBox();
            this.textSourceImage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnPathImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.contextMenuPreview.SuspendLayout();
            this.groupPreview.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupOptions.SuspendLayout();
            this.groupFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturePreview
            // 
            this.picturePreview.ContextMenuStrip = this.contextMenuPreview;
            this.picturePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePreview.Location = new System.Drawing.Point(12, 24);
            this.picturePreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(631, 998);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreview.TabIndex = 2;
            this.picturePreview.TabStop = false;
            // 
            // contextMenuPreview
            // 
            this.contextMenuPreview.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuPreview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.stretchToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.contextMenuPreview.Name = "contextMenuPreview";
            this.contextMenuPreview.Size = new System.Drawing.Size(144, 94);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // stretchToolStripMenuItem
            // 
            this.stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            this.stretchToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.stretchToolStripMenuItem.Text = "Stretch";
            this.stretchToolStripMenuItem.Click += new System.EventHandler(this.stretchToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // groupPreview
            // 
            this.groupPreview.Controls.Add(this.picturePreview);
            this.groupPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPreview.Location = new System.Drawing.Point(0, 0);
            this.groupPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupPreview.Name = "groupPreview";
            this.groupPreview.Padding = new System.Windows.Forms.Padding(12, 5, 12, 12);
            this.groupPreview.Size = new System.Drawing.Size(655, 1034);
            this.groupPreview.TabIndex = 3;
            this.groupPreview.TabStop = false;
            this.groupPreview.Text = "Preview";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddImage.Image = ((System.Drawing.Image)(resources.GetObject("btnAddImage.Image")));
            this.btnAddImage.Location = new System.Drawing.Point(216, 283);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(123, 48);
            this.btnAddImage.TabIndex = 6;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.HelpVisible = false;
            this.propertyGrid.Location = new System.Drawing.Point(4, 24);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid.Size = new System.Drawing.Size(598, 664);
            this.propertyGrid.TabIndex = 8;
            this.propertyGrid.Click += new System.EventHandler(this.propertyGrid_Click);
            // 
            // btnSourceImage
            // 
            this.btnSourceImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSourceImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSourceImage.Image = ((System.Drawing.Image)(resources.GetObject("btnSourceImage.Image")));
            this.btnSourceImage.Location = new System.Drawing.Point(566, 20);
            this.btnSourceImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSourceImage.Name = "btnSourceImage";
            this.btnSourceImage.Size = new System.Drawing.Size(32, 32);
            this.btnSourceImage.TabIndex = 7;
            this.btnSourceImage.UseVisualStyleBackColor = true;
            this.btnSourceImage.Click += new System.EventHandler(this.btnSourceImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Source Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Watermark Image:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(8, 8);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupOptions);
            this.splitContainer1.Panel1.Controls.Add(this.groupFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupPreview);
            this.splitContainer1.Size = new System.Drawing.Size(1267, 1034);
            this.splitContainer1.SplitterDistance = 606;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 11;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.propertyGrid);
            this.groupOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupOptions.Location = new System.Drawing.Point(0, 341);
            this.groupOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupOptions.Size = new System.Drawing.Size(606, 693);
            this.groupOptions.TabIndex = 1;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Options";
            // 
            // groupFiles
            // 
            this.groupFiles.Controls.Add(this.btnPathImage);
            this.groupFiles.Controls.Add(this.txtSavePath);
            this.groupFiles.Controls.Add(this.label4);
            this.groupFiles.Controls.Add(this.btnSave);
            this.groupFiles.Controls.Add(this.checkReset);
            this.groupFiles.Controls.Add(this.btnResetImage);
            this.groupFiles.Controls.Add(this.btnAddText);
            this.groupFiles.Controls.Add(this.textTextToAdd);
            this.groupFiles.Controls.Add(this.btnWatermark);
            this.groupFiles.Controls.Add(this.textWatermark);
            this.groupFiles.Controls.Add(this.textSourceImage);
            this.groupFiles.Controls.Add(this.label3);
            this.groupFiles.Controls.Add(this.label1);
            this.groupFiles.Controls.Add(this.label2);
            this.groupFiles.Controls.Add(this.btnAddImage);
            this.groupFiles.Controls.Add(this.btnSourceImage);
            this.groupFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFiles.Location = new System.Drawing.Point(0, 0);
            this.groupFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupFiles.Name = "groupFiles";
            this.groupFiles.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupFiles.Size = new System.Drawing.Size(606, 341);
            this.groupFiles.TabIndex = 0;
            this.groupFiles.TabStop = false;
            // 
            // checkReset
            // 
            this.checkReset.AutoSize = true;
            this.checkReset.Location = new System.Drawing.Point(164, 228);
            this.checkReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkReset.Name = "checkReset";
            this.checkReset.Size = new System.Drawing.Size(274, 24);
            this.checkReset.TabIndex = 18;
            this.checkReset.Text = "Reset image before watermarking";
            this.checkReset.UseVisualStyleBackColor = true;
            // 
            // btnResetImage
            // 
            this.btnResetImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetImage.Image = ((System.Drawing.Image)(resources.GetObject("btnResetImage.Image")));
            this.btnResetImage.Location = new System.Drawing.Point(65, 283);
            this.btnResetImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetImage.Name = "btnResetImage";
            this.btnResetImage.Size = new System.Drawing.Size(143, 48);
            this.btnResetImage.TabIndex = 17;
            this.btnResetImage.Text = "Reset Image";
            this.btnResetImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetImage.UseVisualStyleBackColor = true;
            this.btnResetImage.Click += new System.EventHandler(this.btnResetImage_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddText.Image = ((System.Drawing.Image)(resources.GetObject("btnAddText.Image")));
            this.btnAddText.Location = new System.Drawing.Point(347, 283);
            this.btnAddText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(119, 48);
            this.btnAddText.TabIndex = 16;
            this.btnAddText.Text = "Add Text";
            this.btnAddText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // textTextToAdd
            // 
            this.textTextToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTextToAdd.Location = new System.Drawing.Point(164, 148);
            this.textTextToAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTextToAdd.Multiline = true;
            this.textTextToAdd.Name = "textTextToAdd";
            this.textTextToAdd.Size = new System.Drawing.Size(432, 70);
            this.textTextToAdd.TabIndex = 15;
            // 
            // btnWatermark
            // 
            this.btnWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWatermark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWatermark.Image = ((System.Drawing.Image)(resources.GetObject("btnWatermark.Image")));
            this.btnWatermark.Location = new System.Drawing.Point(566, 62);
            this.btnWatermark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWatermark.Name = "btnWatermark";
            this.btnWatermark.Size = new System.Drawing.Size(32, 32);
            this.btnWatermark.TabIndex = 14;
            this.btnWatermark.UseVisualStyleBackColor = true;
            this.btnWatermark.Click += new System.EventHandler(this.btnWatermark_Click);
            // 
            // textWatermark
            // 
            this.textWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textWatermark.Enabled = false;
            this.textWatermark.Location = new System.Drawing.Point(164, 65);
            this.textWatermark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textWatermark.Name = "textWatermark";
            this.textWatermark.Size = new System.Drawing.Size(391, 26);
            this.textWatermark.TabIndex = 13;
            // 
            // textSourceImage
            // 
            this.textSourceImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSourceImage.Enabled = false;
            this.textSourceImage.Location = new System.Drawing.Point(164, 20);
            this.textSourceImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSourceImage.Name = "textSourceImage";
            this.textSourceImage.Size = new System.Drawing.Size(391, 26);
            this.textSourceImage.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Watermark Text:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(474, 283);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 48);
            this.btnSave.TabIndex = 19;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Save Image";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavePath.Enabled = false;
            this.txtSavePath.Location = new System.Drawing.Point(164, 109);
            this.txtSavePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(391, 26);
            this.txtSavePath.TabIndex = 21;
            // 
            // btnPathImage
            // 
            this.btnPathImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPathImage.Image = ((System.Drawing.Image)(resources.GetObject("btnPathImage.Image")));
            this.btnPathImage.Location = new System.Drawing.Point(566, 104);
            this.btnPathImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPathImage.Name = "btnPathImage";
            this.btnPathImage.Size = new System.Drawing.Size(32, 33);
            this.btnPathImage.TabIndex = 22;
            this.btnPathImage.UseVisualStyleBackColor = true;
            this.btnPathImage.Click += new System.EventHandler(this.btnPathImage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 1050);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHRISTA SOFT";
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.contextMenuPreview.ResumeLayout(false);
            this.groupPreview.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupOptions.ResumeLayout(false);
            this.groupFiles.ResumeLayout(false);
            this.groupFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.GroupBox groupPreview;
        private System.Windows.Forms.ContextMenuStrip contextMenuPreview;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button btnSourceImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.GroupBox groupFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSourceImage;
        private System.Windows.Forms.TextBox textWatermark;
        private System.Windows.Forms.Button btnWatermark;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.TextBox textTextToAdd;
        private System.Windows.Forms.Button btnResetImage;
        private System.Windows.Forms.CheckBox checkReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPathImage;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label label4;
    }
}

