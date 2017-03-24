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
                using (StreamWriter sw = File.AppendText(this.filePath))
                {
                    sw.Write("Ant Log:");
                }
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
			using (StreamWriter sw = File.AppendText(this.filePath))
            {
                DateTime currentTime = DateTime.Now;
                sw.Write("\r\n"+currentTime);
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
            using (StreamWriter sw = File.AppendText(this.filePath))
            {
                String dumStr = message.Replace("\"","''");
                sw.Write(",\"{0}\"",dumStr);
            }
        }

	}
}

