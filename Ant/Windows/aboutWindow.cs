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
    public partial class aboutWindow : Form
    {
        public aboutWindow()
        {
            InitializeComponent();
            this.versionLabel.Text += Application.ProductVersion.ToString();
        }
        
        private void licenseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.licenseLink.Text.ToString());
        }

        private void sourceCodeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.sourceCodeLink.Text.ToString());
        }

        private void devPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.devPageLink.Text.ToString());
        }

    }
}
