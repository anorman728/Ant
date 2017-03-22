using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ant {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e) {

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
            // Todo
        }
    }
}
