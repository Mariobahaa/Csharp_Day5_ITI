using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    class Duration
    {
        int hours;
        int minutes;
        int seconds;

        public Duration(int _h, int _m, int _s)
        {
            hours = _h;
            minutes = _m;
            seconds = _s;
        }

        public Duration(int time)
        {
            int t = time;
            hours = t / (60 * 60);
            t %= (60 * 60);
            minutes = t / (60);
            t %= 60;
            seconds = t;
        }

        public override bool Equals(object obj)
        {
            Duration dur = (Duration)obj;
            return (dur.hours == hours) && (dur.minutes == minutes) && (dur.seconds == minutes);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            String str;
            if(hours>0)
            {
                str = String.Format($"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}");
            }
            else
            {
                if(minutes>0)
                {
                    str= String.Format($"Minutes: {minutes}, Seconds: {seconds}");
                }
                else
                {
                    if (seconds > 0)
                    {
                        str = String.Format($"Seconds: {seconds}");

                    }
                    else
                    {
                        str = String.Format($"Seconds: "+0);
                    }
                }
            }
            return str;
        }
    }
}
