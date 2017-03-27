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
            String hourDum = this.startHourComboBox.Text;
            String minuteDum = this.startMinuteComboBox.Text;
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
            String hourDum = this.endHourComboBox.Text;
            String minuteDum = this.endMinuteComboBox.Text;
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

    }
}
