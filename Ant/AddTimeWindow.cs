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
    public partial class AddTimeWindow : Form {

        private MainWindow mainWin;

        public AddTimeWindow(MainWindow mainWinDum) {
            this.mainWin = mainWinDum;
            InitializeComponent();
        }

        private void addEnteredTime() {
            String hour = this.hourComboBox.Text;
            String minute = this.minuteComboBox.Text;
            String ampm = this.AMPMComboBox.Text;
            this.mainWin.addTime(hour, minute, ampm);
            this.Close();
        }

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

        private void hourComboBox_KeyUp(object sender, KeyEventArgs e) {
            this.keyEvent(e);
        }

        private void minuteComboBox_KeyUp(object sender, KeyEventArgs e) {
            this.keyEvent(e);
        }

        private void AMPMComboBox_KeyUp(object sender, KeyEventArgs e) {
            this.keyEvent(e);
        }

        private void OKButton_Click(object sender, EventArgs e) {
            this.addEnteredTime();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
