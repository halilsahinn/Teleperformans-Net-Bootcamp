namespace hafta2_1_halilsahin
{
    public static class DateTimeExtensions
    {
        public static void Ago(this DateTime datetime)
        {


            var timeDiff = DateTime.Now.Subtract(datetime);
            string daysDiff = timeDiff.Days != 0 ? $"{timeDiff.Days} days" : "";
            string hoursDiff = timeDiff.Hours != 0 ? $"{timeDiff.Hours} hours" : "";
            string minutesDiff = timeDiff.Minutes != 0 ? $"{timeDiff.Minutes} minutes" : "";
            string secondsDiff = timeDiff.Seconds != 0 ? $"{timeDiff.Seconds} seconds" : "";


            var result = $"{daysDiff} {hoursDiff} {minutesDiff} {secondsDiff} ago";
            Console.WriteLine(result);
        }

    }
}
