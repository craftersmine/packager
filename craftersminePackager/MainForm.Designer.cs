namespace craftersmine.Packager
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
            this.addFile = new System.Windows.Forms.Button();
            this.removeFile = new System.Windows.Forms.Button();
            this.clearFilelist = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseDirs = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filenamecol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizecol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // filesList
            // 
            this.filesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.filenamecol,
            this.sizecol});
            this.filesList.FullRowSelect = true;
            this.filesList.LargeImageList = this.imageList;
            this.filesList.Location = new System.Drawing.Point(12, 49);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(825, 457);
            this.filesList.SmallImageList = this.imageList;
            this.filesList.StateImageList = this.imageList;
            this.filesList.TabIndex = 0;
            this.filesList.UseCompatibleStateImageBehavior = false;
            this.filesList.View = System.Windows.Forms.View.Details;
            // 
            // addFile
            // 
            this.addFile.Image = global::craftersmine.Packager.Properties.Resources.plus;
            this.addFile.Location = new System.Drawing.Point(12, 12);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(31, 31);
            this.addFile.TabIndex = 1;
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // removeFile
            // 
            this.removeFile.Image = global::craftersmine.Packager.Properties.Resources.minus;
            this.removeFile.Location = new System.Drawing.Point(49, 12);
            this.removeFile.Name = "removeFile";
            this.removeFile.Size = new System.Drawing.Size(31, 31);
            this.removeFile.TabIndex = 2;
            this.removeFile.UseVisualStyleBackColor = true;
            // 
            // clearFilelist
            // 
            this.clearFilelist.Image = global::craftersmine.Packager.Properties.Resources.eraser;
            this.clearFilelist.Location = new System.Drawing.Point(86, 12);
            this.clearFilelist.Name = "clearFilelist";
            this.clearFilelist.Size = new System.Drawing.Size(31, 31);
            this.clearFilelist.TabIndex = 3;
            this.clearFilelist.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::craftersmine.Packager.Properties.Resources.box_zipper;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(689, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Build package";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 20);
            this.textBox1.TabIndex = 5;
            // 
            // browseDirs
            // 
            this.browseDirs.Image = global::craftersmine.Packager.Properties.Resources.folder_tree;
            this.browseDirs.Location = new System.Drawing.Point(491, 12);
            this.browseDirs.Name = "browseDirs";
            this.browseDirs.Size = new System.Drawing.Size(31, 31);
            this.browseDirs.TabIndex = 6;
            this.browseDirs.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(528, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 7;
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
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 25;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            this.openFileDialog1.Title = "Select files to add in package";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.browseDirs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clearFilelist);
            this.Controls.Add(this.removeFile);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.filesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "craftersmine Packager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView filesList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader filenamecol;
        private System.Windows.Forms.ColumnHeader sizecol;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button addFile;
        private System.Windows.Forms.Button removeFile;
        private System.Windows.Forms.Button clearFilelist;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browseDirs;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

