using System;

namespace Ant
{
    /**
     * Simple way to store a day's time without managing everything involvedin a DateTime object.
     */

	public class HourMinuteAMPM
	{
        private int hour;
        private int minute;
        private String ampm;

        /**
         * Constructor.
         *
         *@access   Public
         *@param    String      inputTime   In format "HH:mm".
         */

		public HourMinuteAMPM (String inputTime)
		{
            char[] splitArr = {':',' '};
            String[] dumArr = inputTime.Split(splitArr);

            /* Exceptions */
                if (dumArr.Length != 3)
                {
                    throw new ArgumentException("Parameter must be in form \"HH:mm AM/PM\".","inputTime");
                }
                int n;
                if (!(int.TryParse(dumArr[0], out n)))
                {
                    throw new ArgumentException("Hour must be integer.  Found "+dumArr[0]+".");
                }
                if (!(int.TryParse(dumArr[1], out n)))
                {
                    throw new ArgumentException("Minute must be integer.  Found "+dumArr[1]+".");
                }

//            this.setHour((int) dumArr[0]);
			this.setHour(Int32.Parse(dumArr[0]));
//            this.setMinute((int) dumArr[1]);
			this.setMinute(Int32.Parse(dumArr[1]));
            this.setAMPM(dumArr[2]);

            splitArr = null;
            dumArr = null;
		}

        /* Getters and setters. */
            
            public void setHour(int inputHour)
            {
                this.hour = inputHour;
            }

            public int getHour()
            {
                return this.hour;
            }

            public void setMinute(int inputMinute)
            {
                this.minute = inputMinute;
            }

            public int getMinute()
            {
                return this.minute;
            }

            /**
             * Setter for ampm.
             *
             *@access   Public
             *@param    String              inputAMPM
             *@throws   ArgumentException   If inputAMPM is neither "am" nor
             *                              "pm" (case insensitive).
             */

            public void setAMPM(String inputAMPM)
            {
                /* Exceptions */
                    if (!inputAMPM.Equals("am",StringComparison.OrdinalIgnoreCase) && !inputAMPM.Equals("pm",StringComparison.OrdinalIgnoreCase)){
                        throw new ArgumentException("Parameter must be \"am\" or \"pm\" (case insensitive).", "inputAMPM");
                    }
                this.ampm = inputAMPM.ToUpper();
            }

            public String getAMPM()
            {
                return this.ampm;
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
			String testStr = (this.hour.ToString()) + ":" + (String.Format("{0:00}",this.minute)) + " " + this.ampm;
			return testStr.Equals(inputDT.ToString("t"));
        }
	}
}

