using System;

namespace Christlin.Utils
{
    public static class PrettyDate
    {
        public static string From(DateTime d)
        {
            // 1.
            // Get time span elapsed since the date.
            TimeSpan s = DateTime.Now.Subtract(d);

            // 2.
            // Get total number of days elapsed.
            int dayDiff = (int)s.TotalDays;

            // 3.
            // Get total number of seconds elapsed.
            int secDiff = (int)s.TotalSeconds;

            

            // 5.
            // Handle same-day times.
            if (dayDiff == 0)
            {
                // A.
                // Less than one minute ago.
                if (secDiff < 60)
                {
                    return "just now";
                }
                // B.
                // Less than 2 minutes ago.
                if (secDiff < 120)
                {
                    return "1 minute ago";
                }
                // C.
                // Less than one hour ago.
                if (secDiff < 3600)
                {
                    return string.Format("{0} minutes ago",
                        Math.Floor((double)secDiff / 60));
                }
                // D.
                // Less than 2 hours ago.
                if (secDiff < 7200)
                {
                    return "1 hour ago";
                }
                // E.
                // Less than one day ago.
                if (secDiff < 86400)
                {
                    return string.Format("{0} hours ago",
                        Math.Floor((double)secDiff / 3600));
                }
            }
            // 6.
            // Handle previous days.
            if (dayDiff == 1)
            {
                return "yesterday";
            }
            if (dayDiff < 7)
            {
                return string.Format("{0} days ago",
                    dayDiff);
            }
            if (dayDiff <= 31)
            {
                return string.Format("{0} ago",
                    Math.Ceiling((double)dayDiff / 7) == 1 ? "a week" : Math.Ceiling((double)dayDiff / 7) + " weeks");
            }
            if (dayDiff <= 365)
            {
                return string.Format("{0} months ago",
                    Math.Ceiling((double)dayDiff / 30));
            }
            if (dayDiff > 365)
            {
                return string.Format("{0} years ago",
                    Math.Ceiling((double)dayDiff / 365));
            }
            return "Invalid Date";
        }

        public static string From(string d)
        {
            DateTime dateTime = DateTime.Parse(d);
            return From(dateTime);
        }

        public static string From(string d, string format)
        {
            DateTime dateTime = DateTime.ParseExact(d, format, null);
            return From(dateTime);
        }

        public static string From(string d, string format, IFormatProvider provider)
        {
            DateTime dateTime = DateTime.ParseExact(d, format, provider);
            return From(dateTime);
        }
    }
}
