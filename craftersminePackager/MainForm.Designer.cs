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
            this.listView1 = new System.Windows.Forms.ListView();
            this.addFile = new System.Windows.Forms.Button();
            this.removeFile = new System.Windows.Forms.Button();
            this.addFolder = new System.Windows.Forms.Button();
            this.pack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(469, 425);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // addFile
            // 
            this.addFile.Location = new System.Drawing.Point(487, 12);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(177, 23);
            this.addFile.TabIndex = 1;
            this.addFile.Text = "Добавить файл";
            this.addFile.UseVisualStyleBackColor = true;
            // 
            // removeFile
            // 
            this.removeFile.Location = new System.Drawing.Point(487, 41);
            this.removeFile.Name = "removeFile";
            this.removeFile.Size = new System.Drawing.Size(177, 23);
            this.removeFile.TabIndex = 2;
            this.removeFile.Text = "Удалить файл";
            this.removeFile.UseVisualStyleBackColor = true;
            // 
            // addFolder
            // 
            this.addFolder.Location = new System.Drawing.Point(487, 99);
            this.addFolder.Name = "addFolder";
            this.addFolder.Size = new System.Drawing.Size(177, 23);
            this.addFolder.TabIndex = 3;
            this.addFolder.Text = "Добавить папку";
            this.addFolder.UseVisualStyleBackColor = true;
            // 
            // pack
            // 
            this.pack.Location = new System.Drawing.Point(487, 184);
            this.pack.Name = "pack";
            this.pack.Size = new System.Drawing.Size(177, 23);
            this.pack.TabIndex = 4;
            this.pack.Text = "Упаковать";
            this.pack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 449);
            this.Controls.Add(this.pack);
            this.Controls.Add(this.addFolder);
            this.Controls.Add(this.removeFile);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button addFile;
        private System.Windows.Forms.Button removeFile;
        private System.Windows.Forms.Button addFolder;
        private System.Windows.Forms.Button pack;
    }
}

