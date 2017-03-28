using System;
using System.IO;
using System.Diagnostics;

namespace Ant
{
	public class WriteFile
	{
        private string filePath;

        /* Getters and setters */

            public void setFilePath(string inputPath)
            {
                this.filePath = inputPath;
            }

            public string getFilePath()
            {
                return this.filePath;
            }

        /**
         * Constructor for WriteFile.
         *
         *@access   Public
         *@param    String      inputPath       Path to use for CSV file.
         */

		public WriteFile (String inputPath)
		{
            this.setFilePath(inputPath);
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
                this.writeToFile("Ant Log:");
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

	}
}

