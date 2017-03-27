namespace Ant {
    partial class AddTimeWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTimeWindow));
            this.hourComboBox = new System.Windows.Forms.ComboBox();
            this.colonLabel = new System.Windows.Forms.Label();
            this.minuteComboBox = new System.Windows.Forms.ComboBox();
            this.AMPMComboBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hourComboBox
            // 
            this.hourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourComboBox.FormattingEnabled = true;
            this.hourComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.hourComboBox.Location = new System.Drawing.Point(16, 15);
            this.hourComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.hourComboBox.Name = "hourComboBox";
            this.hourComboBox.Size = new System.Drawing.Size(63, 24);
            this.hourComboBox.TabIndex = 0;
            this.hourComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hourComboBox_KeyUp);
            // 
            // colonLabel
            // 
            this.colonLabel.AutoSize = true;
            this.colonLabel.Location = new System.Drawing.Point(88, 18);
            this.colonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(12, 17);
            this.colonLabel.TabIndex = 1;
            this.colonLabel.Text = ":";
            // 
            // minuteComboBox
            // 
            this.minuteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minuteComboBox.FormattingEnabled = true;
            this.minuteComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minuteComboBox.Location = new System.Drawing.Point(109, 15);
            this.minuteComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.minuteComboBox.Name = "minuteComboBox";
            this.minuteComboBox.Size = new System.Drawing.Size(63, 24);
            this.minuteComboBox.TabIndex = 2;
            this.minuteComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.minuteComboBox_KeyUp);
            // 
            // AMPMComboBox
            // 
            this.AMPMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AMPMComboBox.FormattingEnabled = true;
            this.AMPMComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.AMPMComboBox.Location = new System.Drawing.Point(203, 15);
            this.AMPMComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.AMPMComboBox.Name = "AMPMComboBox";
            this.AMPMComboBox.Size = new System.Drawing.Size(63, 24);
            this.AMPMComboBox.TabIndex = 3;
            this.AMPMComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AMPMComboBox_KeyUp);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(171, 48);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 39);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(63, 48);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 39);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddTimeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 98);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AMPMComboBox);
            this.Controls.Add(this.minuteComboBox);
            this.Controls.Add(this.colonLabel);
            this.Controls.Add(this.hourComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTimeWindow";
            this.Text = "Add Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hourComboBox;
        private System.Windows.Forms.Label colonLabel;
        private System.Windows.Forms.ComboBox minuteComboBox;
        private System.Windows.Forms.ComboBox AMPMComboBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
    }
}