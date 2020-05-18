using System;

namespace Christlin.Utils
{
    public static class PrettyDate
    {
        public static string From(DateTime d)
        {
            TimeSpan s = DateTime.Now.Subtract(d);
            int dayDiff = (int)s.TotalDays;
            int secDiff = (int)s.TotalSeconds;      

            if (dayDiff == 0)
            {
                if (secDiff > -60 && secDiff < 0)
                {
                    return "just seconds from now";
                }
                if (secDiff > -120 && secDiff < 0)
                {
                    return "in 1 minute";
                }
                if (secDiff > -3600 && secDiff < 0)
                {
                    return string.Format("in {0} minutes",
                        Math.Floor((double)secDiff / 60) * -1);
                }
                if (secDiff > -7200 && secDiff < 0)
                {
                    return "in 1 hour";
                }
                if (secDiff > -86400 && secDiff < 0)
                {
                    return string.Format("in {0} hours",
                        Math.Floor((double)secDiff / 3600) * -1);
                }
                if (secDiff < 60)
                {
                    return "just now";
                }
                if (secDiff < 120)
                {
                    return "1 minute ago";
                }
                if (secDiff < 3600)
                {
                    return string.Format("{0} minutes ago",
                        Math.Floor((double)secDiff / 60));
                }
                if (secDiff < 7200)
                {
                    return "1 hour ago";
                }
                if (secDiff < 86400)
                {
                    return string.Format("{0} hours ago",
                        Math.Floor((double)secDiff / 3600));
                }
            }

            if (dayDiff == 1)
            {
                return "yesterday";
            }
            if (dayDiff < 7 && dayDiff > 0)
            {
                return string.Format("{0} days ago",
                    dayDiff);
            }
            if (dayDiff <= 31 && dayDiff > 0)
            {
                return string.Format("{0} ago",
                    Math.Ceiling((double)dayDiff / 7) == 1 ? "a week" : Math.Ceiling((double)dayDiff / 7) + " weeks");
            }
            if (dayDiff <= 365 && dayDiff > 0)
            {
                return string.Format("{0} months ago",
                    Math.Ceiling((double)dayDiff / 30));
            }
            if (dayDiff > 365 && dayDiff > 0)
            {
                return string.Format("{0} years ago",
                    Math.Ceiling((double)dayDiff / 365));
            }


            if (dayDiff == -1)
            {
                return "tomorrow";
            }
            if (dayDiff > -7)
            {
                return string.Format("{0} days ago",
                    dayDiff * -1);
            }
            if (dayDiff <= 31)
            {
                return string.Format("in {0}",
                    Math.Ceiling((double)dayDiff / 7) == -1 ? "a week" : Math.Ceiling(((double)dayDiff / 7) * -1) + " weeks");
            }
            if (dayDiff <= 365)
            {
                return string.Format("in {0} months",
                    Math.Ceiling((double)dayDiff / 30) * -1);
            }
            if (dayDiff > 365)
            {
                return string.Format("in {0} years",
                    Math.Ceiling((double)dayDiff / 365) * -1);
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
