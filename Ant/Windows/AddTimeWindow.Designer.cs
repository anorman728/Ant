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
            this.colonLabel = new System.Windows.Forms.Label();
            this.AMPMComboBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.hourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // colonLabel
            // 
            this.colonLabel.AutoSize = true;
            this.colonLabel.Location = new System.Drawing.Point(83, 14);
            this.colonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(12, 17);
            this.colonLabel.TabIndex = 1;
            this.colonLabel.Text = ":";
            // 
            // AMPMComboBox
            // 
            this.AMPMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AMPMComboBox.FormattingEnabled = true;
            this.AMPMComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.AMPMComboBox.Location = new System.Drawing.Point(189, 10);
            this.AMPMComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.AMPMComboBox.Name = "AMPMComboBox";
            this.AMPMComboBox.Size = new System.Drawing.Size(63, 24);
            this.AMPMComboBox.TabIndex = 2;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(152, 42);
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
            this.cancelButton.Location = new System.Drawing.Point(44, 42);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 39);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // hourNumericUpDown
            // 
            this.hourNumericUpDown.Location = new System.Drawing.Point(13, 13);
            this.hourNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hourNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hourNumericUpDown.Name = "hourNumericUpDown";
            this.hourNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.hourNumericUpDown.TabIndex = 0;
            this.hourNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hourNumericUpDown.Enter += new System.EventHandler(this.hourNumericUpDown_Enter);
            // 
            // minuteNumericUpDown
            // 
            this.minuteNumericUpDown.Location = new System.Drawing.Point(102, 12);
            this.minuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNumericUpDown.Name = "minuteNumericUpDown";
            this.minuteNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.minuteNumericUpDown.TabIndex = 1;
            this.minuteNumericUpDown.Enter += new System.EventHandler(this.minuteNumericUpDown_Enter);
            // 
            // AddTimeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 96);
            this.Controls.Add(this.minuteNumericUpDown);
            this.Controls.Add(this.hourNumericUpDown);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AMPMComboBox);
            this.Controls.Add(this.colonLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTimeWindow";
            this.Text = "Add Time";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AddTimeWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label colonLabel;
        private System.Windows.Forms.ComboBox AMPMComboBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown hourNumericUpDown;
        private System.Windows.Forms.NumericUpDown minuteNumericUpDown;
    }
}