using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace MediaCopy
{
    public partial class MainForm : Form
    {
        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 7;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam,
        IntPtr lParam);


        MediaCopier copier;
        Timer statusChecker;
        public MainForm()
        {
            InitializeComponent();
            statusChecker = new Timer();
            statusChecker.Interval = 250;
            statusChecker.Tick += new EventHandler(statusChecker_Tick);
            statusChecker.Enabled = true;
        }

        void statusChecker_Tick(object sender, EventArgs e)
        {
            if (copier == null) return;
            while (true)
            {
                string statusMessage = copier.Status;

                if (statusMessage != null) Print(statusMessage);
                else break;
            }
            Progress.Value = (int)(copier.FractionComplete * Progress.Maximum);

            if (copier.IsFinished)
            {
                copier = null;
                CopyButton.Enabled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SourceDriveComboBox.Items.Add("F");
            SourceDriveComboBox.Items.Add("G");
            SourceDriveComboBox.Items.Add("H");
            SourceDriveComboBox.Items.Add("I");
            SourceDriveComboBox.Items.Add("J");
            SourceDriveComboBox.Items.Add("K");
            SourceDriveComboBox.Items.Add("L");
            SourceDriveComboBox.Items.Add("M");
            SourceDriveComboBox.Items.Add("N");
            SourceDriveComboBox.Items.Add("O");
            SourceDriveComboBox.SelectedIndex = 2;




            DateFromTextBox.Text = Properties.Settings.Default.FromDate;
            DateToTextBox.Text = Properties.Settings.Default.ToDate;
            VideoDestinationTextBox.Text = Properties.Settings.Default.DestinationFolder;
            VideoExtensionsTextBox.Text = Properties.Settings.Default.VidioExtensions;
            PictureExtensionsTextBox.Text = Properties.Settings.Default.PictureExtensions;
            NameMappingTextBox.Text = Properties.Settings.Default.NameMapping;

        }

        private void SourceDriveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NameMappingLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Print("Some Name Mapping examples:");
            Print("yyyyMMdd_HH-mm-ss =>" + DateTime.Now.ToString("yyyyMMdd_HH-mm-ss"));
            Print("h:mm tt =>" + DateTime.Now.ToString("h:mm tt"));
            Print("M/d/yyyy =>" + DateTime.Now.ToString("M/d/yyyy"));
            Print("dddd, MMMM dd, yyyy h:mm:ss tt =>" + DateTime.Now.ToString("dddd, MMMM dd, yyyy h:mm:ss tt "));
            Print("M/d/yyyy h:mm:ss tt =>" + DateTime.Now.ToString("M/d/yyyy h:mm:ss tt"));
        }

        void Print(string message)
        {
            StatusText.AppendText(Environment.NewLine + message);
            //SendMessage(StatusText.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);

            //StatusText.SelectionStart = StatusText.Text.Length;
            //StatusText.Select(StatusText.Text.Length, 0);
            //StatusText.ScrollToCaret();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            DoCopy(false);
        }

        private void PretendCopyButton_Click(object sender, EventArgs e)
        {
            DoCopy(true);
        }

        private void DoCopy(bool pretend)
        {
            StatusText.Clear();
            CopyButton.Enabled = false;

            DateTime fromDate = DateTime.MinValue;
            DateTime toDate = DateTime.MaxValue;

            if (!DateTime.TryParse(DateFromTextBox.Text, out fromDate))
            {
                fromDate = DateTime.MinValue;
            }

            if (!DateTime.TryParse(DateToTextBox.Text, out toDate))
            {
                toDate = DateTime.MaxValue;
            }


            copier = new MediaCopier(
                SourceDriveComboBox.SelectedItem.ToString() + ":\\",
                Regex.Split(VideoExtensionsTextBox.Text.ToLower(), "\\s+"),
                VideoDestinationTextBox.Text,
                NameMappingTextBox.Text,
                fromDate,
                toDate);
            copier.NoCopy = pretend;
            copier.StartCopy();
        }


            //string[] allFIles = Directory.GetFiles(sourceFolder, "*.*", SearchOption.AllDirectories);
            ////string[] extensions = 
            
            //List<string> toCopy = new List<string>();
            //foreach (string file in allFIles)
            //{
            //    foreach(string extension in extensions)
            //    {
            //        if(file.ToLower().EndsWith("." + extension))
            //        {
            //            toCopy.Add(file);
            //        }
            //    }
            //}

            //Print("FOUND: " + toCopy.Count + " files.\r\n");

            //int count = 0;
            //foreach(string file in toCopy)
            //{
            //    FileInfo info = new FileInfo(file);
            //    string destination = Path.Combine(VideoDestinationTextBox.Text,
            //        info.LastWriteTime.ToString(NameMappingTextBox.Text) + Path.GetExtension(file));
            //    if (!File.Exists(destination))
            //    {
            //        Print("copying " + file + " to " + destination);
            //        File.Copy(file, destination);
            //    }
            //    else
            //    {
            //        Print("Skipping: " + destination);
            //    }

            //    count++;
            //    Progress.Value = count / toCopy.Count;
            //}

            //Print("Done copying.\r\n");


        private void ScanButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FromDate = DateFromTextBox.Text;
            Properties.Settings.Default.ToDate = DateToTextBox.Text;
            Properties.Settings.Default.DestinationFolder = VideoDestinationTextBox.Text;
            Properties.Settings.Default.VidioExtensions = VideoExtensionsTextBox.Text;
            Properties.Settings.Default.PictureExtensions = PictureExtensionsTextBox.Text;
            Properties.Settings.Default.NameMapping = NameMappingTextBox.Text;
            Properties.Settings.Default.Save();

        }
    }
}
