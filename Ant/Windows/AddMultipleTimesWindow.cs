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

namespace Ant
{
    public partial class AddMultipleTimesWindow : Form
    {
        private MainWindow mainWin;

        public AddMultipleTimesWindow(MainWindow mainWinDum)
        {
            this.mainWin = mainWinDum;
            InitializeComponent();
            this.secondaryInitialize();
        }

        /* Events */
            private void AddMultipleTimesWindow_KeyUp(object sender, KeyEventArgs e)
            {
                this.keyUpEvent(e);
            }

            private void Cancel_Click(object sender, EventArgs e)
            {
                this.CancelAction();
            }

            private void okayButton_Click(object sender, EventArgs e)
            {
                this.addTimes();
            }

            private void cancelButton_Click(object sender, EventArgs e)
            {
                this.CancelAction();
            }

            private void startHourNumericUpDown_Enter(object sender, EventArgs e)
            {
                this.selectAllNumericUpDown(this.startHourNumericUpDown);
            }

            private void startMinuteNumericUpDown_Enter(object sender, EventArgs e)
            {
                this.selectAllNumericUpDown(this.startMinuteNumericUpDown);
            }

            private void endHourNumericUpDown_Enter(object sender, EventArgs e)
            {
                this.selectAllNumericUpDown(this.endHourNumericUpDown);
            }

            private void endMinuteNumericUpDown_Enter(object sender, EventArgs e)
            {
                this.selectAllNumericUpDown(this.endMinuteNumericUpDown);
            }

            private void intervalNumericUpDown_Enter(object sender, EventArgs e)
            {
                this.selectAllNumericUpDown(this.intervalNumericUpDown);
            }

        private void secondaryInitialize()
        {
            this.startAMPMComboBox.SelectedIndex = 0;
            this.endAMPMComboBox.SelectedIndex = 0;
        }

        /**
         * Handler for keyUp event in this window.
         *
         *@access   Private
         *@param    Object      e       KeyEventArgs
         */

        private void keyUpEvent(KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Return":
                    this.addTimes();
                    break;
                case "Escape":
                    this.CancelAction();
                    break;
            }
        }

        /**
         * Get the HourMinuteAMPM object determined by what user has entered for
         * start time.
         *
         *@access   Public
         *@return   HourMinuteAMPM
         */

        public HourMinuteAMPM startHM()
        {
            String hourDum = this.startHourNumericUpDown.Value.ToString();
            String minuteDum = String.Format("{0:00}",this.startMinuteNumericUpDown.Value);
            String ampmDum = this.startAMPMComboBox.Text;
            HourMinuteAMPM returnVal = new HourMinuteAMPM(hourDum+":"+minuteDum+" "+ampmDum);
            return returnVal;
        }

        /**
         * Get the HourMinuteAMPM object determined by what user has entered for
         * end time.
         *
         *@access   Public
         *@return   HourMinuteAMPM
         */

        public HourMinuteAMPM endHM()
        {
            String hourDum = this.endHourNumericUpDown.Value.ToString();
            String minuteDum = String.Format("{0:00}",this.endMinuteNumericUpDown.Value);
            String ampmDum = this.endAMPMComboBox.Text;
            HourMinuteAMPM returnVal = new HourMinuteAMPM(hourDum+":"+minuteDum+" "+ampmDum);
            return returnVal;
        }

        /**
         * "Ok" action-- Add all times between start and end times of the
         * specified interval, then close the window.
         *
         *@access   Public.
         */

        public void addTimes()
        {
            HourMinuteAMPM startDum = this.startHM();
            HourMinuteAMPM endDum = this.endHM();
            int interval = (int) this.intervalNumericUpDown.Value;
            this.mainWin.populateTimesListBoxIntervals(startDum,endDum,interval);
            startDum = null;
            endDum = null;
            this.Close();
        }

        /**
         * "Cancel" action-- Just close the window and dow nothing.
         *
         *@access   Public
         */

        public void CancelAction()
        {
            this.Close();
        }

        private void selectAllNumericUpDown(NumericUpDown inputObj)
        {
            inputObj.Select(0,inputObj.Text.Length);
        }


    }
}
