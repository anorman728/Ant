﻿using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ant
{
    /**
     * Manages prompts presented to the user.
     */

	public class PromptManager
	{
        private WriteFile writeFileObj;
        private HourMinuteAMPM[] timeArr;
        private int numFields;
        private Timer timer;
        private bool isUp = false;

        /* Getters and setters. */

            public void createWriteFileObj(String inputPath)
            {
                this.writeFileObj = new WriteFile(inputPath,this.numFields);
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

            public void setNumFields(int inputNumFields)
            {
                this.numFields = inputNumFields;
            }

            public int getNumFields()
            {
                return this.numFields;
            }

            public void setIsUp(bool inputBool)
            {
                this.isUp = inputBool;
            }
            
        /**
         * Constructor for PromptManager.
         *
         *@access   Public
         *@param    String      inputPath   Path to use for CSV file.
         *@param    String      times       String of format "HH:mm,HH:mm,..."
         */

		public PromptManager (String inputPath,String times,int inputNumFields)
		{
            this.setNumFields(inputNumFields);    
            this.createWriteFileObj(inputPath);
            this.createTimeArr(times);

            this.timer = new Timer();
            this.timer.Interval = 5000;
        }

        /**
         * Start timer for prompts.
         *
         *@access   Public
         */

        public void startPrompting()
        {
            this.timer.Tick += new EventHandler(promptIfInArray);
            this.timer.Start();
        }

        /**
         * Stop timer for prompts.
         *
         *@access   Public
         */

        public void stopPrompting()
        {
			this.timer.Stop();
            this.timer.Dispose();
        }

        /**
         * Check if the current time matches any of the times in timeArr and
         * call this.prompt if it does.
         * Designed to be used by the this.timer object.
         *
         *@access   Private
         *@param    Object              source
         *@param    ElapsedEventArgs    e
         */

		private void promptIfInArray(object source, EventArgs e)
        {
            if (DateTime.Now.Second < 5){
                int len = this.timeArr.Length;
                DateTime dumDT = DateTime.Now;

                for (int i = 0; i < len; i++) {
                    if (this.timeArr [i].isMatch (dumDT)) {
                        this.prompt ();
                    }
                }
            }
        }

        /**
         * Write current datetime to file, request message from user, write
         * message to file.
         *
         *@access   Private
         */

        private void prompt()
        {
            if (!this.isUp){
                this.isUp = true;
                this.writeFileObj.writeDatetime();
                //System.Media.SystemSounds.Beep.Play();
                //String message = Interaction.InputBox("What are you working on right now?");
                //this.writeFileObj.writeMessage(message);
                //this.isUp = false;
                //^ This is what now needs to be handled by a PromptWindow class.
                Windows.PromptWindow winDum = new Windows.PromptWindow(this.numFields,this.writeFileObj,this);
                winDum.Show();
            }
        }
	}
}

