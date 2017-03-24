using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ant {
    public partial class MainWindow : Form {
        private PromptManager promptManagerObj;

        public MainWindow() {
            InitializeComponent();
            this.populateTimesListBox(Properties.Settings.Default["timesListBox"].ToString());
            this.fileNameTextBox.Text = Properties.Settings.Default["fileNameTextBox"].ToString();
        }
        
        private void addTimeButton_Click(object sender, EventArgs e) {
            AddTimeWindow winDum = new AddTimeWindow(this);
            winDum.Show();
        }

        public void addTime(String hour,String minute,String ampm) {
            String timeToAdd = hour + ":" + minute + " " + ampm;
            this.timesListBox.Items.Add(timeToAdd);
        }

        public void deleteSelectedTime() {
            int dumInd = this.timesListBox.SelectedIndex;
            if (dumInd != -1)
            {
                Object itemDum = this.timesListBox.Items[dumInd];
                this.timesListBox.Items.Remove(itemDum);
            }
        }

        private void deleteSelectedTimeButton_Click(object sender, EventArgs e) {
            this.deleteSelectedTime();
        }

        private void browseButton_Click(object sender, EventArgs e) {
            var FD = new OpenFileDialog();
            FD.CheckFileExists = false;
            if (FD.ShowDialog() == DialogResult.OK)
            {
                String fileName = FD.FileName;
                this.fileNameTextBox.Text = fileName;
            }
        }

        private void startButton_Click(object sender, EventArgs e) {
            if (this.timesListBox.Items.Count > 0) {
                /* Disable elements. */
                    this.startButton.Enabled                = false;
                    this.addTimeButton.Enabled              = false;
                    this.deleteSelectedTimeButton.Enabled   = false;
                    this.browseButton.Enabled               = false;
                    this.fileNameTextBox.Enabled            = false;
                    this.timesListBox.Enabled               = false;
                /* Enable elements */
                    this.stopButton.Enabled = true;
            
                String fileName = this.fileNameTextBox.Text;
                String timesStr = this.getTimes();
                
                this.promptManagerObj = new PromptManager(fileName, timesStr);

                this.promptManagerObj.startPrompting();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            /* Disable elements. */
                this.startButton.Enabled                = true;
                this.addTimeButton.Enabled              = true;
                this.deleteSelectedTimeButton.Enabled   = true;
                this.browseButton.Enabled               = true;
                this.fileNameTextBox.Enabled            = true;
                this.timesListBox.Enabled               = true;
            /* Enable elements */
                this.stopButton.Enabled = false;

            this.promptManagerObj.stopPrompting();

        }

        public String getTimes(){
            int cnt = this.timesListBox.Items.Count;
            String[] dumArr = new String[cnt];

            for (int i = 0; i < cnt; i++) {
                dumArr[i] = this.timesListBox.Items[i].ToString();
            }

            String dumStr = String.Join(",", dumArr);
            return dumStr;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            /* timesListBox settings */
                String dumStr = this.getTimes();
                Properties.Settings.Default["timesListBox"] = dumStr;

            /* fileNameTextBox setting */
                Properties.Settings.Default["fileNameTextBox"] = this.fileNameTextBox.Text;

            /* Save settings */
                Properties.Settings.Default.Save();
        }

        private void populateTimesListBox(String multipleTimesString)
        {
            String[] dumArr = multipleTimesString.Split(',');
            int len = dumArr.Length;
            for (int i=0;i<len;i++)
            {
                this.timesListBox.Items.Add(dumArr[i]);
            }
        }

        private void onlineDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/anorman728/ant");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow winDum = new aboutWindow();
            winDum.Show();
        }
    }
}
