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

        public AddTimeWindow(MainWindow mainWinDum) {
            this.mainWin = mainWinDum;
            InitializeComponent();
        }

        private void addEnteredTime() {
            String hour = this.hourNumericUpDown.Value.ToString();
            String minute = String.Format("{0:00}",this.minuteNumericUpDown.Value);
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
        
    }
}
