using System;
using System.IO;
using System.Diagnostics;

namespace Ant
{
	public class WriteFile
	{
        private string filePath;
        private int numFields;

        /* Getters and setters */

            public void setFilePath(string inputPath)
            {
                this.filePath = inputPath;
            }

            public string getFilePath()
            {
                return this.filePath;
            }

            public void setNumFields(int inputNumFields)
            {
                this.numFields = inputNumFields;
            }

            public int getNumFields()
            {
                return this.numFields;
            }

        /**
         * Constructor for WriteFile.
         *
         *@access   Public
         *@param    String      inputPath       Path to use for CSV file.
         */

		public WriteFile (String inputPath,int inputNumFields)
		{
            this.setFilePath(inputPath);
            this.setNumFields(inputNumFields);
		}

        /**
         * Create empty file if none exists.  Do nothing if it does already.
         *
         *@access   Private
         */

        private void touch()
        {
            if (!File.Exists(this.filePath))
            {
                File.Create(this.filePath).Dispose();
                String header = "Timestamp";
                for (int i=1;i<=this.numFields;i++)
                {
                    header += ",Field "+i.ToString();
                }
                this.writeToFile(header);
            }
        }

        /**
         * Write current datetime to new line in file.
         *
         *@access   Public
         */

        public void writeDatetime()
        {
            this.touch();
            DateTime currentTime = DateTime.Now;
            this.writeToFile("\r\n"+currentTime);
        }

        private void writeToFile(String message)
        {
            try{
                using(StreamWriter sw = File.AppendText(this.filePath))
                {
                    sw.Write(message);
                }
            } catch (System.IO.IOException)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Unable to write to "+this.filePath+".  Is it open in another program?");
            }
        }

        /**
         * Write message to end of last line in file.
         *
         *@access   Public
         *@param    String      message
         */

        public void writeMessage(String message)
        {
            this.touch();
            String dumStr = message.Replace("\"","''");
            this.writeToFile(",\""+dumStr+"\"");
        }

        /**
         * Write multiple messages to last line in file.
         *
         *@access   Public
         *@param    String[]    messages
         */

        public void writeMessages(String[] messages)
        {
            this.touch();
            int len = messages.Length;
            for (int i=0;i<len;i++)
            {
                this.writeMessage(messages[i]);
            }
        }

	}
}

