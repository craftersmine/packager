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
using craftersmine.Packager.Lib.Core;
using System.Threading;

namespace craftersmine.Packager.GUI
{
    public partial class MainForm : Form
    {
        private Thread _workingThread;

        public MainForm()
        {
            InitializeComponent();
            _workingThread = new Thread(new ParameterizedThreadStart(startPackaging));
        }

        private void startPackaging(object pkgr)
        {
            ((Packager.Lib.Core.Packager)(pkgr)).Pack();
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var file in openFileDialog.FileNames)
            {
                double filesize = new FileInfo(file).Length;
                string sizestr = "Bytes";
                if (filesize >= 1024.0d)
                {
                    filesize /= 1024.0d;
                    sizestr = "KBytes";
                    if (filesize >= 1024.0d)
                    {
                        filesize /= 1024.0d;
                        sizestr = "MBytes";
                        if (filesize >= 1024.0d)
                        {
                            filesize /= 1024.0d;
                            sizestr = "GBytes";
                        }
                    }
                }
                int imgId = 3;
                string ext = Path.GetExtension(file).ToLower().Substring(1);
                if (ext == "png" || ext == "jpg" || ext == "jpeg" || ext == "bmp" || ext == "gif" || ext == "tif" || ext == "tiff" || ext == "ai" || ext == "psd" || ext == "pdn")
                    imgId = 9;
                else if (ext == "txt" || ext == "xml")
                    imgId = 6;
                else if (ext == "pdf" || ext == "epub" || ext == "xps" || ext == "oxps")
                    imgId = 11;
                else if (ext == "mp4" || ext == "avi" || ext == "mov" || ext == "3gp" || ext == "mkv" || ext == "webm" || ext == "flv" || ext == "wmv")
                    imgId = 8;
                else if (ext == "mp3" || ext == "aac" || ext == "flac" || ext == "amr" || ext == "ra" || ext == "aif" || ext == "aiff" || ext == "fla" || ext == "wma" || ext == "oga" || ext == "ogg" || ext == "wav")
                    imgId = 10;
                else if (ext == "doc" || ext == "docx")
                    imgId = 7;
                else if (ext == "ppt" || ext == "pptx" || ext == "xls" || ext == "xlsx" || ext == "accdb" || ext == "mdb" || ext == "pub")
                    imgId = 5;
                else if (ext == "dll")
                    imgId = 4;
                else if (ext == "exe" || ext == "jar" || ext == "apk")
                    imgId = 0;
                else if (ext == "bat" || ext == "cmd" || ext == "ps1" || ext == "sh")
                    imgId = 1;
                else if (ext == "zip" || ext == "rar" || ext == "7z" || ext == "cab" || ext == "xz" || ext == "txz" || ext == "lzma" || ext == "tar" || ext == "cpio" || ext == "bz2" || ext == "bzip2" || ext == "tbz2" || ext == "tbz" || ext == "gz" || ext == "gzip" || ext == "tgz" || ext == "tpz" || ext == "z" || ext == "taz" || ext == "lzh" || ext == "lha" || ext == "rpm" || ext == "deb" || ext == "arj" || ext == "wim" || ext == "swm" || ext == "dmg" || ext == "xar")
                    imgId = 2;
                filesList.Items.Add(new ListViewItem(new string[] { null, file, string.Format("{0:F2} {1}", filesize, sizestr) }, imgId));
            }
        }

        private void removeFile_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in filesList.SelectedItems)
            {
                filesList.Items.Remove(itm);
            }
        }

        private void clearFilelist_Click(object sender, EventArgs e)
        {
            filesList.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 3 && textBox2.Text.Length > 4)
                build.Enabled = true;
            else build.Enabled = false;
        }

        private void browseDirs_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            textBox1.Text = folderBrowserDialog.SelectedPath;
        }

        private void build_Click(object sender, EventArgs e)
        {
            try
            {
                filesList.Enabled = false;
                panel.Visible = true;
                PackageFile pkg = new PackageFile(textBox2.Text);
                foreach (ListViewItem entry in filesList.Items)
                {
                    pkg.AddFile(entry.SubItems[1].Text);
                }
                Packager.Lib.Core.Packager pkgr = new Lib.Core.Packager(textBox1.Text, pkg);
                pkgr.PackingEvent += Pkgr_PackingEvent;
                pkgr.PackingDoneEvent += Pkgr_PackingDoneEvent;
                totalFiles = pkg.Files.Length;
                _workingThread.Start(pkgr);
                progressBar1.Style = ProgressBarStyle.Continuous;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void Pkgr_PackingDoneEvent(object sender, PackingDoneEventArgs e)
        {
            
            if (this.InvokeRequired)
                this.Invoke(new Action(() =>
                {
                    buildComplete(e);
                }));
            else
                buildComplete(e);
        }

        private void Pkgr_PackingEvent(object sender, PackingEventArgs e)
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(() => { buildProcessing(e); }));
            else buildProcessing(e);
        }

        private void buildComplete(PackingDoneEventArgs e)
        {
            if (e.IsSuccessful)
            {
                filesList.Items.Clear();
                MessageBox.Show("Packaging successful completed! Package path: " + Path.Combine(textBox1.Text, textBox2.Text + ".cmpkg"), "Packaging completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                if (e.InnerException != null)
                    MessageBox.Show("An error has occured while package creation!\r\nMessage: " + e.InnerException.Message + "\r\n\r\nStack Trace: \r\n" + e.InnerException.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("An error has occured while package creation!\r\nNo additional information about error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            filesList.Enabled = true;
            panel.Visible = false;
        }

        private int totalFiles = 0;

        private void buildProcessing(PackingEventArgs e)
        {
            double perc = 0.0d;
            if (e.CurrentFileByte > 0 && e.TotalAllBytes > 0 && e.TotalFileByte > 0)
                perc = ((double)e.CurrentFileByte / e.TotalFileByte) * 100.0d;
            if (perc < 100.0d)
            {
                progressBar1.Value = (int)perc;
                status.Text = "Current file: " + e.CurrentFilename + "         " + string.Format("{0:F1}%", perc) + "       Processing file: " + (e.CurrentFileIndex + 1).ToString() + " of " + totalFiles.ToString();
            }
            else perc = 100.0d;
        }
    }
}
