namespace Ant
{
    partial class aboutWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.licenseLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceCodeLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.devPageLink = new System.Windows.Forms.LinkLabel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 216);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ant = \r\n\r\n    Andrew\r\n    Norman\'s\r\n    Timelogger\r\n\r\nAnt is open source and dist" +
    "ributed under an MIT license.\r\n\r\nVisit the following site for details:";
            // 
            // licenseLink
            // 
            this.licenseLink.AutoSize = true;
            this.licenseLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseLink.Location = new System.Drawing.Point(12, 277);
            this.licenseLink.Name = "licenseLink";
            this.licenseLink.Size = new System.Drawing.Size(488, 24);
            this.licenseLink.TabIndex = 1;
            this.licenseLink.TabStop = true;
            this.licenseLink.Text = "https://github.com/anorman728/Ant/blob/master/LICENSE";
            this.licenseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.licenseLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "You can find the source code at the primary webpage:";
            // 
            // sourceCodeLink
            // 
            this.sourceCodeLink.AutoSize = true;
            this.sourceCodeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceCodeLink.Location = new System.Drawing.Point(12, 351);
            this.sourceCodeLink.Name = "sourceCodeLink";
            this.sourceCodeLink.Size = new System.Drawing.Size(301, 24);
            this.sourceCodeLink.TabIndex = 3;
            this.sourceCodeLink.TabStop = true;
            this.sourceCodeLink.Text = "https://github.com/anorman728/Ant";
            this.sourceCodeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sourceCodeLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "You can visit the dev\'s webpage here:";
            // 
            // devPageLink
            // 
            this.devPageLink.AutoSize = true;
            this.devPageLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devPageLink.Location = new System.Drawing.Point(12, 420);
            this.devPageLink.Name = "devPageLink";
            this.devPageLink.Size = new System.Drawing.Size(211, 24);
            this.devPageLink.TabIndex = 5;
            this.devPageLink.TabStop = true;
            this.devPageLink.Text = "https://anorman728.com";
            this.devPageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.devPageLink_LinkClicked);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(16, 13);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(62, 24);
            this.versionLabel.TabIndex = 6;
            this.versionLabel.Text = "Ant v. ";
            // 
            // aboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 469);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.devPageLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sourceCodeLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.licenseLink);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aboutWindow";
            this.Text = "About Ant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel licenseLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel sourceCodeLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel devPageLink;
        private System.Windows.Forms.Label versionLabel;
    }
}