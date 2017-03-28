using System;
using System.Text.RegularExpressions;

namespace Ant
{
    /**
     * Simple way to store a day's time without managing everything involvedin a DateTime object.
     */

	public class HourMinuteAMPM
	{
        private int timeInt;

        /**
         * Constructor.
         *
         *@access   Public
         *@param    String                      inputTime   In format "HH:mm
         *                                                  am/pm".
         *@throws   System.ArgumentException                If inputTime doesn't
         *                                                  match "HH:mm am/pm"
         *                                                  format.
         */

		public HourMinuteAMPM (String inputTime)
		{
            /* Exceptions */
                Regex timeRgx = new Regex(@"^\d{1,2}:\d{2} (AM|PM)$",RegexOptions.IgnoreCase);
                if (!timeRgx.IsMatch(inputTime))
                {
                    throw new System.ArgumentException("Parameter must be in a \"HH:mm AM/PM\" format.","inputTime");
                }

            this.setTimeInt(this.strToInt(inputTime));
		}

        /**
         * Constructor.
         *
         *@access   Pulic
         *@param    int     inputTimeInt
         */

        public HourMinuteAMPM (int inputTimeInt)
        {
            this.setTimeInt(inputTimeInt);
        }

        /* Getters and setters. */
            
            public int getHour()
            {
                int returnVal = this.timeInt / 60;
                if (returnVal == 0){
                    returnVal = 12;
                } else if (returnVal > 12){
                    returnVal = returnVal - 12;
                }
                return returnVal;
            }

            public int getMinute()
            {
                int returnVal = this.timeInt % 60;
                return returnVal;
            }

            public String getAMPM()
            {
                String returnVal;
                if (this.timeInt >= 12*60)
                {
                    returnVal = "PM";
                }
                else
                {
                    returnVal = "AM";
                }
                return returnVal;
            }

            /**
             * Set timeInt.
             *
             *@access   Public
             */

            public void setTimeInt(int inputTimeInt)
            {
                this.timeInt = inputTimeInt;
            }

            /**
             * Get integer representation of time (i.e., minutes from midnight).
             *
             *@return   int
             */

            public int getTimeInt()
            {
                return this.timeInt;
            }

            /**
             * Get time in string format.
             *
             *@access   Public
             *@return   String
             */

            public String getTime()
            {
                String returnStr = (this.getHour().ToString()) + ":" + (String.Format("{0:00}",this.getMinute())) + " " + this.getAMPM();
                return returnStr;
            }

        /**
         * Compare inputDT to see if it matches this.hour and this.minute and
         * this.ampm.
         * Note: Needs to be refactored because it's done in kind of a lazy way.
         *
         *@access   Public
         *@param    inputDT
         *@return   Bool
         */

        public bool isMatch(DateTime inputDT)
        {
			String testStr = this.getTime();
			return testStr.Equals(inputDT.ToString("t"));
        }

        /**
         * Convert "HH:mm am/pm" string to minutes since midnight.
         *
         *@access   Private
         *@param    String      inputStr
         *@return   int
         */

        private int strToInt(String inputStr)
        {
            char[] splitArr = {':',' '};
            String[] dumArr = inputStr.Split(splitArr);

            int dumHour = Int32.Parse(dumArr[0]);
            int dumMinute = Int32.Parse(dumArr[1]);
            String dumAMPM = dumArr[2];

            splitArr = null;
            dumArr = null;

            if (dumAMPM.Equals("am",StringComparison.OrdinalIgnoreCase) && dumHour==12)
            {
                dumHour = 0;
            }
            else if (dumAMPM.Equals("pm",StringComparison.OrdinalIgnoreCase) && dumHour!=12)
            {
                dumHour = dumHour + 12;
            }
            int dumTimeInt = dumHour*60 + dumMinute;
            return dumTimeInt;
        }
	}
}

