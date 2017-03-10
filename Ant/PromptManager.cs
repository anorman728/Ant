using System;
using System.Timers;

namespace Ant
{
    /**
     * Manages prompts presented to the user.
     */

	public class PromptManager
	{
        private WriteFile writeFileObj;
        private HourMinuteAMPM[] timeArr;
        private Timer timer;

        /* Getters and setters. */

            public void createWriteFileObj(String inputPath)
            {
                this.writeFileObj = new WriteFile(inputPath);
            }

            public WriteFile getWriteFileObj()
            {
                return this.writeFileObj;
            }

            public void createTimeArr(String inputTimes)
            {
                String[] dumStrArr = inputTimes.Split(',');
                this.timeArr = new HourMinuteAMPM[dumStrArr.Length];
                int len = dumStrArr.Length;
                for (int i=0;i<len;i++)
                {
                    this.timeArr[i] = new HourMinuteAMPM(dumStrArr[i]);
                }
                dumStrArr = null;
            }

            public HourMinuteAMPM[] getTimeArr()
            {
                return this.timeArr;
            }
            
        /**
         * Constructor for PromptManager.
         *
         *@access   Public
         *@param    String      inputPath   Path to use for CSV file.
         *@param    String      times       String of format "HH:mm,HH:mm,..."
         */

		public PromptManager (String inputPath,String times)
		{
            this.createWriteFileObj(inputPath);
            this.createTimeArr(times);

            this.timer = new Timer(60000);
		}

        public void startTimer()
        {
            this.timer.Start();
            this.timer.Elapsed += promptIfInArray;
            this.timer.AutoReset = true;
            this.timer.Enabled = true;
        }

        public void stopTimer()
        {
			this.timer.Stop();
            this.timer.Dispose();
        }

		private void promptIfInArray(object source, ElapsedEventArgs e)
        {
            int len = this.timeArr.Length;
			DateTime dumDT = DateTime.Now;

			for (int i = 0; i < len; i++) {
				if (this.timeArr [i].isMatch (dumDT)) {
					try{
						this.prompt ();
					} catch (Exception ex){
						Console.WriteLine(ex.Message);
					}
				}
			}
        }

        private void prompt()
        {
			this.writeFileObj.writeDatetime();
			PromptWindow win = new PromptWindow(this.writeFileObj);
            win.Show();
        }
	}
}

