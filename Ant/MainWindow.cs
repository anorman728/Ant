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
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace Ant {
    public partial class MainWindow : Form {

        private PromptManager promptManagerObj;

        public MainWindow() {
            InitializeComponent();
            this.loadSettings();
        }
        
        /* Events. */

            private void addTimeButton_Click(object sender, EventArgs e) 
            {
                AddTimeWindow winDum = new AddTimeWindow(this);
                winDum.Show();
            }

            private void deleteSelectedTimeButton_Click(object sender, EventArgs e) 
            {
                this.deleteSelectedTime();
            }

            private void browseButton_Click(object sender, EventArgs e) 
            {
                this.promptUserForFilename();
            }

            private void startButton_Click(object sender, EventArgs e) 
            {
                this.startPrompting();
            }

            private void stopButton_Click(object sender, EventArgs e)
            {
                this.stopPrompting();
            }

            private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
            {
                this.saveSettings();
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

        /**
         * Add time to timesListBox.
         *
         *@access   Public
         *@param    String      hour
         *@param    String      minute
         *@param    String      ampm
         */

        public void addTime(String hour,String minute,String ampm) 
        {
            String timeToAdd = hour + ":" + minute + " " + ampm;
            this.timesListBox.Items.Add(timeToAdd);
        }

        /**
         * Delete selected time from timesListBox.
         *
         *@access   Private
         */

        public void deleteSelectedTime() 
        {
            int dumInd = this.timesListBox.SelectedIndex;
            if (dumInd != -1)
            {
                Object itemDum = this.timesListBox.Items[dumInd];
                this.timesListBox.Items.Remove(itemDum);
            }
        }

        /**
         * Bring up dialog for output file and set fileNameTextBox to it.
         *
         *@access   Private
         */

        private void promptUserForFilename()
        {
            var FD = new OpenFileDialog();
            FD.CheckFileExists = false;
            if (FD.ShowDialog() == DialogResult.OK)
            {
                String fileName = FD.FileName;
                this.fileNameTextBox.Text = fileName;
            }
        }

        /**
         * Start prompting the user and change UI to match.
         *
         *@access   Private
         */

        private void startPrompting()
        {
            if (this.timesListBox.Items.Count > 0 && this.checkTimes()) {
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
            } else {
                Interaction.MsgBox("Unable to start timer: Either the list is empty or it contains invalid times.");
            }
        }

        /**
         * Stop prompting user and change UI to match.
         *
         *@access   Private
         */

        private void stopPrompting()
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

        /**
         * Get a string of all times in timesListBox, comma-delimited.
         *
         *@access   Public
         */

        public String getTimes()
        {
            int cnt = this.timesListBox.Items.Count;
            String[] dumArr = new String[cnt];

            for (int i = 0; i < cnt; i++) {
                dumArr[i] = this.timesListBox.Items[i].ToString();
            }

            String dumStr = String.Join(",", dumArr);
            return dumStr;
        }

        /**
         * Save all settings.
         *
         *@access   Public
         */

        public void saveSettings()
        {
            /* timesListBox settings */
                String dumStr = this.getTimes();
                Properties.Settings.Default["timesListBox"] = dumStr;

            /* fileNameTextBox setting */
                Properties.Settings.Default["fileNameTextBox"] = this.fileNameTextBox.Text;

            /* Save settings */
                Properties.Settings.Default.Save();
        }

        /**
         * Load all settings.
         *
         *@access   Public
         */

        public void loadSettings()
        {
            this.populateTimesListBox(Properties.Settings.Default["timesListBox"].ToString());
            this.fileNameTextBox.Text = Properties.Settings.Default["fileNameTextBox"].ToString();
        }

        /**
         * Populate timesListBox with comma-delimited string.
         *
         *@access   Public
         *@param    String  multipleTimesString
         */

        public void populateTimesListBox(String multipleTimesString)
        {
            String[] dumArr = multipleTimesString.Split(',');
            int len = dumArr.Length;
            for (int i=0;i<len;i++)
            {
                this.timesListBox.Items.Add(dumArr[i]);
            }
        }

        /**
         * "True" if all times in timesListBox are valid and "False" if there
         * are any invalid ones.
         *
         *@access   Public
         *@return   Boolean
         */

        public bool checkTimes()
        {
            Regex rgx = new Regex(@"^\d{1,2}:\d{2} (AM|PM)$",RegexOptions.IgnoreCase);
            bool returnVal = true; // Assume true until found otherwise.
            int cnt = this.timesListBox.Items.Count;
            for (int i=0; i < cnt; i++){
                String dumStr = this.timesListBox.Items[i].ToString();
                if (!rgx.IsMatch(dumStr)) returnVal = false;
            }
            return returnVal;
        }
    }
}
