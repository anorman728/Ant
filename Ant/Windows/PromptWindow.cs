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
        }

        /* Events */
            private void PromptWindow_KeyUp(object sender, KeyEventArgs e)
            {
                this.keyUpEvent(e);
            }

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
            this.SetClientSizeCore(500,80+numOfFields*32);
        }

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

        private void writeMessages()
        {
            String[] dumArr = this.getMessages();
            this.writeFileObj.writeMessages(dumArr);
            dumArr = null;
            this.promptManagerObj.setIsUp(false);
            this.Close();
        }

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

        private void cancelAction()
        {
            this.promptManagerObj.setIsUp(false);
            this.Close();
        }
    }
}
