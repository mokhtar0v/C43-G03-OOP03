using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part2
{
    internal class Duration
    {
        int hours {  get; set; }
        int minutes { get; set; }
        int seconds { get; set; }
        #region Override
        public override string ToString()
        {
            if (hours > 0)
            {
                return $"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}";
            }
            else if(minutes > 0)
            {
                return $"Minutes: {minutes}, Seconds: {seconds}";
            }
            return $"Seconds: {seconds}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Duration other)
            {
                return hours == other.hours && minutes == other.minutes && seconds == other.seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region Constructors
        public Duration(int hours,int minutes, int seconds)
        {
            this .hours = hours;
            this .minutes = minutes;
            this .seconds = seconds;
        }
        public Duration(int seconds)
        {
            hours = seconds / 3600;
            minutes = (seconds % 3600) / 60;
            seconds = seconds % 60;
        }
        #endregion

        #region Operator Overload
        public static Duration operator + (Duration a, Duration b)
        {
            return new Duration(((a?.hours ?? 0) + (b?.hours ?? 0)), ((a?.minutes ?? 0) + (b?.minutes ?? 0)), ((a?.seconds ?? 0) + (b?.seconds ?? 0)));
        }
        public static Duration operator + (Duration a, int b)
        {
            return new Duration(((a?.hours ?? 0) + b / 3600), ((a?.minutes ?? 0) + (b % 3600) / 60), ((a?.seconds ?? 0) + b));
        }
        public static Duration operator +(int b, Duration a)
        {
            return new Duration(((a?.hours ?? 0) + b / 3600), ((a?.minutes ?? 0) + (b % 3600) / 60), ((a?.seconds ?? 0) + b));
        }
        public static Duration operator ++ (Duration a)
        {
            return new Duration(a.hours,a.minutes+1,a.seconds);
        }
        public static Duration operator -- (Duration a)
        {
            return new Duration(a.hours, a.minutes -1, a.seconds);
        }
        public static Duration operator - (Duration a, Duration b)
        {
            return new Duration(((a?.hours ?? 0) - (b?.hours ?? 0)), ((a?.minutes ?? 0) - (b?.minutes ?? 0)), ((a?.seconds ?? 0) - (b?.seconds ?? 0)));
        }
        public static bool operator >(Duration a, Duration b)
        {
            a.hours *= 3600;
            a.minutes *= 60; 
            a.seconds = a.seconds+a.minutes+a.hours;
            b.hours *= 3600;
            b.minutes *= 60;
            b.seconds = b.seconds + b.minutes + b.hours;
            if (a.seconds > b.seconds) return a.seconds > b.seconds;
            return a.seconds < b.seconds;
        }
        public static bool operator <(Duration a, Duration b)
        {
            a.hours *= 3600;
            a.minutes *= 60;
            a.seconds = a.seconds + a.minutes + a.hours;
            b.hours *= 3600;
            b.minutes *= 60;
            b.seconds = b.seconds + b.minutes + b.hours;
            if (a.seconds > b.seconds) return a.seconds > b.seconds;
            return a.seconds < b.seconds;
        }
        public static bool operator >=(Duration a, Duration b)
        {
            a.hours *= 3600;
            a.minutes *= 60;
            a.seconds = a.seconds + a.minutes + a.hours;
            b.hours *= 3600;
            b.minutes *= 60;
            b.seconds = b.seconds + b.minutes + b.hours;
            if (a.seconds >= b.seconds) return a.seconds >= b.seconds;
            return a.seconds < b.seconds;
        }
        public static bool operator <=(Duration a, Duration b)
        {
            a.hours *= 3600;
            a.minutes *= 60;
            a.seconds = a.seconds + a.minutes + a.hours;
            b.hours *= 3600;
            b.minutes *= 60;
            b.seconds = b.seconds + b.minutes + b.hours;
            if (a.seconds <= b.seconds) return a.seconds <= b.seconds;
            return a.seconds > b.seconds;
        }
        public static implicit operator bool(Duration a)
        {
            if (a.hours != 0 && a.minutes != 0 && a.seconds != 0) return true;
            return false;
        }
        public static explicit operator DateTime(Duration a)
        {
            return new DateTime(1, 1, 1, a.hours, a.minutes, a.seconds);
        }
        #endregion

    }
}
