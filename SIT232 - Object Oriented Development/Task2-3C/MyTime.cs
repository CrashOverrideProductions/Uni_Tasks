/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           2-3C (MyTime.cs)
DATE:           05/09/2020
STATUS:         COMPLETED

REVISIONS:      05/09/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_3C
{
    class MyTime
    {
        // Instance Vars
        private int _hour;
        private int _minute;
        private int _second;

        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentOutOfRangeException("Invalid Hour - Hour needs to be Between 00 and 23");
                }
                _hour = value;
            }
        }

        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException("Invalid Minute - Minute needs to be between 00 and 59");
                }
             _minute = value;
            }
        }

        public int Second
        {
            get
            {
               return _second;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException("Invalid Second - Second needs to be between 00 and 59");
                }
                _second = value;
            }
        }


        public MyTime() { }

        // Constructor
       public MyTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

       public void SetTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        // Methods

        public void SetHour(int hour)
        {
            Hour = hour;
        }

        public void SetMinute(int minute)
        {
            Minute = minute;
        }

        public void SetSeconds(int second)
        {
            Second = second;
        }

        public int GetHour()
        {
            return Hour;
        }


        public int GetMinute()
        {
            return Minute;
        }

        public int GetSecond()
        {
            return Second;
        }

        String LeftPad(int num)
        {
            if (num <= 9)
            {
                return Convert.ToString("0" + num);
            }
            else
            {
                return Convert.ToString(num);
            }
        }

       public override String ToString()
        {
            return LeftPad(Hour) + ":" + LeftPad(Minute) + ":" + LeftPad(Second);
        }

        public MyTime NextSecond()
        {
            try
            {
                Second += 1;

            }
            catch (ArgumentOutOfRangeException)
            {
                Second = 0;
                NextMinute();
            }
            return this;
        }

        public MyTime NextMinute()
        {
            try
            {
                Minute += 1;

            }
            catch (ArgumentOutOfRangeException)
            {
                Minute = 0;
                NextHour();
            }
            return this;
        }

        public MyTime NextHour()
        {
            try
            {
                Hour += 1;

            }
            catch (ArgumentOutOfRangeException)
            {
                Hour = 0;
                //NextDay();
            }
            return this;
        }

        public MyTime PreviousSecond()
        {
            try
            {
                Second -= 1;

            }
            catch (ArgumentOutOfRangeException)
            {
                Second = 59;
                PreviousMinute();
            }
            return this;
        }

        public MyTime PreviousMinute()
        {
            try
            {
                Minute -= 1;

            }
            catch (ArgumentOutOfRangeException)
            {
                Minute = 59;
                PreviousHour();
            }
            return this;
        }

        public MyTime PreviousHour()
        {
            try
            {
                Hour -= 1;

            }
            catch (ArgumentOutOfRangeException)
            {
                Hour = 23;
                //PreviousDay();
            }
            return this;
        }

    }
}
