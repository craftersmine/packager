using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace craftersmine.Packager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var file in openFileDialog1.FileNames)
            {
                double filesize = new FileInfo(file).Length / 1024.0d / 1024.0d;
                switch (Path.GetExtension(file))
                {
                    default:
                        filesList.Items.Add(new ListViewItem(new string[] { "", file, string.Format("{0:F2} MBytes", filesize) }, 3));
                        break;
                }
            }
        }
    }
}
