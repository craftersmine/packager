namespace craftersmine.Packager.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.filesList = new System.Windows.Forms.ListView();
            this.icon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filenamecol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizecol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.addFile = new System.Windows.Forms.Button();
            this.removeFile = new System.Windows.Forms.Button();
            this.clearFilelist = new System.Windows.Forms.Button();
            this.build = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseDirs = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.status = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesList
            // 
            this.filesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.icon,
            this.filenamecol,
            this.sizecol});
            this.filesList.FullRowSelect = true;
            this.filesList.Location = new System.Drawing.Point(12, 50);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(825, 457);
            this.filesList.SmallImageList = this.imageList;
            this.filesList.TabIndex = 0;
            this.filesList.UseCompatibleStateImageBehavior = false;
            this.filesList.View = System.Windows.Forms.View.Details;
            // 
            // icon
            // 
            this.icon.Text = "";
            this.icon.Width = 24;
            // 
            // filenamecol
            // 
            this.filenamecol.Text = "Path\\Filename";
            this.filenamecol.Width = 635;
            // 
            // sizecol
            // 
            this.sizecol.Text = "Size";
            this.sizecol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sizecol.Width = 161;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "app");
            this.imageList.Images.SetKeyName(1, "console");
            this.imageList.Images.SetKeyName(2, "archives");
            this.imageList.Images.SetKeyName(3, "unknown");
            this.imageList.Images.SetKeyName(4, "dll");
            this.imageList.Images.SetKeyName(5, "otheroffice");
            this.imageList.Images.SetKeyName(6, "txt");
            this.imageList.Images.SetKeyName(7, "word");
            this.imageList.Images.SetKeyName(8, "video");
            this.imageList.Images.SetKeyName(9, "image");
            this.imageList.Images.SetKeyName(10, "music");
            this.imageList.Images.SetKeyName(11, "book");
            // 
            // addFile
            // 
            this.addFile.Image = global::craftersmine.Packager.GUI.Properties.Resources.plus;
            this.addFile.Location = new System.Drawing.Point(12, 12);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(31, 31);
            this.addFile.TabIndex = 1;
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // removeFile
            // 
            this.removeFile.Image = global::craftersmine.Packager.GUI.Properties.Resources.minus;
            this.removeFile.Location = new System.Drawing.Point(49, 12);
            this.removeFile.Name = "removeFile";
            this.removeFile.Size = new System.Drawing.Size(31, 31);
            this.removeFile.TabIndex = 2;
            this.removeFile.UseVisualStyleBackColor = true;
            this.removeFile.Click += new System.EventHandler(this.removeFile_Click);
            // 
            // clearFilelist
            // 
            this.clearFilelist.Image = global::craftersmine.Packager.GUI.Properties.Resources.eraser;
            this.clearFilelist.Location = new System.Drawing.Point(86, 12);
            this.clearFilelist.Name = "clearFilelist";
            this.clearFilelist.Size = new System.Drawing.Size(31, 31);
            this.clearFilelist.TabIndex = 3;
            this.clearFilelist.UseVisualStyleBackColor = true;
            this.clearFilelist.Click += new System.EventHandler(this.clearFilelist_Click);
            // 
            // build
            // 
            this.build.Enabled = false;
            this.build.Image = global::craftersmine.Packager.GUI.Properties.Resources.box_zipper;
            this.build.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.build.Location = new System.Drawing.Point(689, 12);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(148, 31);
            this.build.TabIndex = 4;
            this.build.Text = "Build package";
            this.build.UseVisualStyleBackColor = true;
            this.build.Click += new System.EventHandler(this.build_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // browseDirs
            // 
            this.browseDirs.Image = global::craftersmine.Packager.GUI.Properties.Resources.folder_tree;
            this.browseDirs.Location = new System.Drawing.Point(491, 12);
            this.browseDirs.Name = "browseDirs";
            this.browseDirs.Size = new System.Drawing.Size(31, 31);
            this.browseDirs.TabIndex = 6;
            this.browseDirs.UseVisualStyleBackColor = true;
            this.browseDirs.Click += new System.EventHandler(this.browseDirs_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(528, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Directory where save package:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Package Name:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.SupportMultiDottedExtensions = true;
            this.openFileDialog.Title = "Select files to add in package";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select directory where save output package";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.progressBar1);
            this.panel.Controls.Add(this.status);
            this.panel.Location = new System.Drawing.Point(12, 9);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(825, 34);
            this.panel.TabIndex = 10;
            this.panel.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 19);
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(825, 15);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(3, 3);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(46, 13);
            this.status.TabIndex = 0;
            this.status.Text = "{status}:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 519);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.browseDirs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.build);
            this.Controls.Add(this.clearFilelist);
            this.Controls.Add(this.removeFile);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.filesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "craftersmine Packager";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView filesList;
        private System.Windows.Forms.ColumnHeader icon;
        private System.Windows.Forms.ColumnHeader filenamecol;
        private System.Windows.Forms.ColumnHeader sizecol;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button addFile;
        private System.Windows.Forms.Button removeFile;
        private System.Windows.Forms.Button clearFilelist;
        private System.Windows.Forms.Button build;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browseDirs;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label status;
    }
}

