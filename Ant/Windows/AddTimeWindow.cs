﻿using System;
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
    public partial class AddTimeWindow : Form {

        private MainWindow mainWin;

        /* Events */

            private void AddTimeWindow_KeyUp(object sender, KeyEventArgs e)
            {
                this.keyEvent(e);
            }

            private void OKButton_Click(object sender, EventArgs e) {
                this.addEnteredTime();
            }

            private void cancelButton_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void hourNumericUpDown_Enter(object sender, EventArgs e)
            {
                this.selectAllNumericUpDown(this.hourNumericUpDown);
            }

            private void minuteNumericUpDown_Enter(object sender, EventArgs e)
            {
                this.selectAllNumericUpDown(this.minuteNumericUpDown);
            }

        public AddTimeWindow(MainWindow mainWinDum) {
            this.mainWin = mainWinDum;
            InitializeComponent();
            this.secondaryInitialize();
        }

        /**
         * Secondary initialization actions to define contents of window-- Not
         * defined in InitializeComponent because the designer can rewrite that.
         *
         *@access   Private
         */

        private void secondaryInitialize()
        {
            this.AMPMComboBox.SelectedIndex = 0;
        }

        /**
         * Handle submit event by adding the entered time to the main window and
         * closing the window.
         *
         *@access   Private
         */

        private void addEnteredTime() {
            String hour = this.hourNumericUpDown.Value.ToString();
            String minute = String.Format("{0:00}",this.minuteNumericUpDown.Value);
            String ampm = this.AMPMComboBox.Text;
            this.mainWin.addTime(hour, minute, ampm);
            this.Close();
        }

        /**
         * Handle keypress event by calling submit or cancel handlers.
         *
         *@access   Private
         *@param    KeyEventArgs    e       Determined by keyUp events.
         */

        private void keyEvent(KeyEventArgs e){
            switch (e.KeyCode.ToString()){
                case "Return":
                    this.addEnteredTime();
                    break;
                case "Escape":
                    this.Close();
                    break;
            }
        }

        /**
         * Handle NumericUpDowns' Enter event by selecting all of its text.
         *
         *@access   Private
         *@param    NumericUpDown   inputObj
         */

        private void selectAllNumericUpDown(NumericUpDown inputObj)
        {
            inputObj.Select(0,inputObj.Text.Length);
        }


    }
}
