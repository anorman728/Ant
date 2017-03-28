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

namespace Ant.Windows
{
    public partial class PromptWindow : Form
    {
        private WriteFile writeFileObj;
        private System.Windows.Forms.TextBox[] inputFields;
        private PromptManager promptManagerObj;

        public PromptWindow(int numOfFields, WriteFile inputWriteFileObj, PromptManager inputPromptManager)
        {
            InitializeComponent();
            System.Media.SystemSounds.Beep.Play();
            this.createTextBoxes(numOfFields);
            this.writeFileObj = inputWriteFileObj;
            this.promptManagerObj = inputPromptManager;
            this.PlaceLowerRight();
        }
        
        /* Events */
            private void PromptWindow_KeyUp(object sender, KeyEventArgs e)
            {
                this.keyUpEvent(e);
            }

        /**
         * Create the input textboxes in the window.
         *
         *@access   Private
         *@param    int         numOfFields
         */

        private void createTextBoxes(int numOfFields)
        {
            this.inputFields = new System.Windows.Forms.TextBox[numOfFields];
            for (int i=0;i<numOfFields;i++)
            {
                this.inputFields[i] = new System.Windows.Forms.TextBox();
                this.inputFields[i].Location= new System.Drawing.Point(16,71+i*32);
                this.inputFields[i].Name = "fieldTextBox"+String.Format("{0:00}",i);
                this.inputFields[i].Size = new System.Drawing.Size(470,22);
                this.inputFields[i].TabIndex = i;
                this.Controls.Add(this.inputFields[i]);
            }
            this.SetClientSizeCore(500, 80 + numOfFields * 32);
        }

        /**
         * Handle keyUp events by calling submit or cancel events.
         *
         *@access   Private
         *@param    KeyEventArgs    e
         */

        private void keyUpEvent(KeyEventArgs e)
        {
            switch(e.KeyCode.ToString())
            {
                case "Return":
                    this.writeMessages();
                    break;
                case "Escape":
                    this.cancelAction();
                    break;
            }
        }

        /**
         * Write messages to file, let promptManagerObj know that it's done, and
         * close window.
         * This is the submit event.
         *
         *@access   Private
         */

        private void writeMessages()
        {
            String[] dumArr = this.getMessages();
            this.writeFileObj.writeMessages(dumArr);
            dumArr = null;
            this.promptManagerObj.setIsUp(false);
            this.Close();
        }

        /**
         * Collect the messages from the textboxes into an array.
         *
         *@access   Public
         */

        public String[] getMessages()
        {
            int len = this.inputFields.Length;
            String[] returnArr = new String[len];
            for (int i=0;i<len;i++)
            {
                returnArr[i] = this.inputFields[i].Text;
            }
            return returnArr;
        }

        /**
         * Handle canceling.
         *
         *@access   Private
         */

        private void cancelAction()
        {
            this.promptManagerObj.setIsUp(false);
            this.Close();
        }

        // Testing

        private void PlaceLowerRight()
        {
            Screen mainScreen = Screen.AllScreens[0];
            this.StartPosition = FormStartPosition.Manual;
            this.Left = mainScreen.WorkingArea.Right - this.Width;
            this.Top = mainScreen.WorkingArea.Bottom - this.Height;
        }
        
    }
}
