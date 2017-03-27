namespace Ant {
    partial class MainWindow {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.timesListBox = new System.Windows.Forms.ListBox();
            this.promptTimesLabel = new System.Windows.Forms.Label();
            this.addTimeButton = new System.Windows.Forms.Button();
            this.deleteSelectedTimeButton = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMultipleTimeButton = new System.Windows.Forms.Button();
            this.clearAllTimesButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timesListBox
            // 
            this.timesListBox.FormattingEnabled = true;
            this.timesListBox.ItemHeight = 16;
            this.timesListBox.Location = new System.Drawing.Point(16, 58);
            this.timesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.timesListBox.Name = "timesListBox";
            this.timesListBox.Size = new System.Drawing.Size(431, 292);
            this.timesListBox.TabIndex = 0;
            // 
            // promptTimesLabel
            // 
            this.promptTimesLabel.AutoSize = true;
            this.promptTimesLabel.Location = new System.Drawing.Point(13, 37);
            this.promptTimesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.promptTimesLabel.Name = "promptTimesLabel";
            this.promptTimesLabel.Size = new System.Drawing.Size(95, 17);
            this.promptTimesLabel.TabIndex = 1;
            this.promptTimesLabel.Text = "Prompt Times";
            // 
            // addTimeButton
            // 
            this.addTimeButton.Location = new System.Drawing.Point(453, 58);
            this.addTimeButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTimeButton.Name = "addTimeButton";
            this.addTimeButton.Size = new System.Drawing.Size(152, 44);
            this.addTimeButton.TabIndex = 2;
            this.addTimeButton.Text = "Add Time";
            this.addTimeButton.UseVisualStyleBackColor = true;
            this.addTimeButton.Click += new System.EventHandler(this.addTimeButton_Click);
            // 
            // deleteSelectedTimeButton
            // 
            this.deleteSelectedTimeButton.Location = new System.Drawing.Point(453, 162);
            this.deleteSelectedTimeButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteSelectedTimeButton.Name = "deleteSelectedTimeButton";
            this.deleteSelectedTimeButton.Size = new System.Drawing.Size(152, 44);
            this.deleteSelectedTimeButton.TabIndex = 3;
            this.deleteSelectedTimeButton.Text = "Delete Selected Time";
            this.deleteSelectedTimeButton.UseVisualStyleBackColor = true;
            this.deleteSelectedTimeButton.Click += new System.EventHandler(this.deleteSelectedTimeButton_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(15, 374);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(431, 22);
            this.fileNameTextBox.TabIndex = 4;
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Location = new System.Drawing.Point(13, 354);
            this.outputFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(73, 17);
            this.outputFileLabel.TabIndex = 5;
            this.outputFileLabel.Text = "Output file";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(453, 374);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(152, 44);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(453, 426);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(152, 44);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(293, 426);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(152, 44);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineDocumentationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // onlineDocumentationToolStripMenuItem
            // 
            this.onlineDocumentationToolStripMenuItem.Name = "onlineDocumentationToolStripMenuItem";
            this.onlineDocumentationToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.onlineDocumentationToolStripMenuItem.Text = "Online Documentation";
            this.onlineDocumentationToolStripMenuItem.Click += new System.EventHandler(this.onlineDocumentationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // addMultipleTimeButton
            // 
            this.addMultipleTimeButton.Location = new System.Drawing.Point(453, 110);
            this.addMultipleTimeButton.Margin = new System.Windows.Forms.Padding(4);
            this.addMultipleTimeButton.Name = "addMultipleTimeButton";
            this.addMultipleTimeButton.Size = new System.Drawing.Size(152, 44);
            this.addMultipleTimeButton.TabIndex = 11;
            this.addMultipleTimeButton.Text = "Add Multiple Times";
            this.addMultipleTimeButton.UseVisualStyleBackColor = true;
            this.addMultipleTimeButton.Click += new System.EventHandler(this.addMultipleTimeButton_Click);
            // 
            // clearAllTimesButton
            // 
            this.clearAllTimesButton.Location = new System.Drawing.Point(453, 214);
            this.clearAllTimesButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearAllTimesButton.Name = "clearAllTimesButton";
            this.clearAllTimesButton.Size = new System.Drawing.Size(152, 44);
            this.clearAllTimesButton.TabIndex = 12;
            this.clearAllTimesButton.Text = "Clear All Times";
            this.clearAllTimesButton.UseVisualStyleBackColor = true;
            this.clearAllTimesButton.Click += new System.EventHandler(this.clearAllTimesButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 492);
            this.Controls.Add(this.clearAllTimesButton);
            this.Controls.Add(this.addMultipleTimeButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.deleteSelectedTimeButton);
            this.Controls.Add(this.addTimeButton);
            this.Controls.Add(this.promptTimesLabel);
            this.Controls.Add(this.timesListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Ant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox timesListBox;
        private System.Windows.Forms.Label promptTimesLabel;
        private System.Windows.Forms.Button addTimeButton;
        private System.Windows.Forms.Button deleteSelectedTimeButton;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button addMultipleTimeButton;
        private System.Windows.Forms.Button clearAllTimesButton;
    }
}

