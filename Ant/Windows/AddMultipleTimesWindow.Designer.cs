namespace Ant
{
    partial class AddMultipleTimesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMultipleTimesWindow));
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okayButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.startMinuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startHourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startAMPMComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endMinuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endHourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endAMPMComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startHourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHourNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(23, 17);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(77, 17);
            this.startTimeLabel.TabIndex = 0;
            this.startTimeLabel.Text = "Start Time:";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(28, 45);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(72, 17);
            this.endTimeLabel.TabIndex = 8;
            this.endTimeLabel.Text = "End Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Interval lengths (in minutes):";
            // 
            // intervalNumericUpDown
            // 
            this.intervalNumericUpDown.Location = new System.Drawing.Point(196, 82);
            this.intervalNumericUpDown.Name = "intervalNumericUpDown";
            this.intervalNumericUpDown.Size = new System.Drawing.Size(144, 22);
            this.intervalNumericUpDown.TabIndex = 6;
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(214, 110);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(131, 39);
            this.okayButton.TabIndex = 8;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(77, 110);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(131, 39);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // startMinuteNumericUpDown
            // 
            this.startMinuteNumericUpDown.Location = new System.Drawing.Point(196, 15);
            this.startMinuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startMinuteNumericUpDown.Name = "startMinuteNumericUpDown";
            this.startMinuteNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.startMinuteNumericUpDown.TabIndex = 1;
            // 
            // startHourNumericUpDown
            // 
            this.startHourNumericUpDown.Location = new System.Drawing.Point(107, 16);
            this.startHourNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.startHourNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startHourNumericUpDown.Name = "startHourNumericUpDown";
            this.startHourNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.startHourNumericUpDown.TabIndex = 0;
            this.startHourNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startAMPMComboBox
            // 
            this.startAMPMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startAMPMComboBox.FormattingEnabled = true;
            this.startAMPMComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.startAMPMComboBox.Location = new System.Drawing.Point(283, 13);
            this.startAMPMComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.startAMPMComboBox.Name = "startAMPMComboBox";
            this.startAMPMComboBox.Size = new System.Drawing.Size(63, 24);
            this.startAMPMComboBox.TabIndex = 2;
            this.startAMPMComboBox.SelectedItem = this.startAMPMComboBox.Items[0];
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = ":";
            // 
            // endMinuteNumericUpDown
            // 
            this.endMinuteNumericUpDown.Location = new System.Drawing.Point(196, 43);
            this.endMinuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.endMinuteNumericUpDown.Name = "endMinuteNumericUpDown";
            this.endMinuteNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.endMinuteNumericUpDown.TabIndex = 4;
            // 
            // endHourNumericUpDown
            // 
            this.endHourNumericUpDown.Location = new System.Drawing.Point(107, 44);
            this.endHourNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.endHourNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endHourNumericUpDown.Name = "endHourNumericUpDown";
            this.endHourNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.endHourNumericUpDown.TabIndex = 3;
            this.endHourNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endAMPMComboBox
            // 
            this.endAMPMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endAMPMComboBox.FormattingEnabled = true;
            this.endAMPMComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.endAMPMComboBox.Location = new System.Drawing.Point(283, 41);
            this.endAMPMComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.endAMPMComboBox.Name = "endAMPMComboBox";
            this.endAMPMComboBox.Size = new System.Drawing.Size(63, 24);
            this.endAMPMComboBox.TabIndex = 5;
            this.endAMPMComboBox.SelectedItem = this.endAMPMComboBox.Items[0];
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = ":";
            // 
            // AddMultipleTimesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 166);
            this.Controls.Add(this.endMinuteNumericUpDown);
            this.Controls.Add(this.endHourNumericUpDown);
            this.Controls.Add(this.endAMPMComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startMinuteNumericUpDown);
            this.Controls.Add(this.startHourNumericUpDown);
            this.Controls.Add(this.startAMPMComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.intervalNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "AddMultipleTimesWindow";
            this.Text = "AddMultipleTimesWindow";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AddMultipleTimesWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startHourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHourNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown startMinuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown startHourNumericUpDown;
        private System.Windows.Forms.ComboBox startAMPMComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown endMinuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown endHourNumericUpDown;
        private System.Windows.Forms.ComboBox endAMPMComboBox;
        private System.Windows.Forms.Label label4;
    }
}