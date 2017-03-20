﻿using System;
using System.Timers;
using Microsoft.VisualBasic;
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
        private Timer timer;
        private bool isUp = false;

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

            this.timer = new Timer(1000);
		}

        /**
         * Start timer for prompts.
         *
         *@access   Public
         */

        public void startPrompting()
        {
            this.timer.Start();
            this.timer.Elapsed += promptIfInArray;
            this.timer.AutoReset = true;
            this.timer.Enabled = true;
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
         *@param    ElaspsedEventArgs   e
         */

		private void promptIfInArray(object source, ElapsedEventArgs e)
        {
            if (DateTime.Now.Second == 0){
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
                System.Media.SystemSounds.Beep.Play();
                String message = Interaction.InputBox("What are you working on right now?");
                this.writeFileObj.writeMessage(message);
                this.isUp = false;
            }
        }
	}
}

