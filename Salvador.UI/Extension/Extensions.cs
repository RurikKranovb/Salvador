using System;

namespace Salvador.UI.Extension
{
    public static class Extensions
    {
        //public static DateTime FromUnixTicks(this double ms)
        //{
        //    DateTime dateTime = new DateTime()
        //}

        public static long ToUnixTime(this DateTime dateTime)
        {

            var utcNow = dateTime.ToFileTimeUtc();
            //TimeSpan offset = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time").GetUtcOffset(dateTime);

            DateTimeOffset dto = new DateTimeOffset(dateTime, new TimeSpan(3,0,0));

            //Int32 unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;


            //TimeSpan epochTicks = new TimeSpan(new DateTime(1970, 1, 1).Ticks);
            //TimeSpan unixTicks = new TimeSpan(DateTime.UtcNow.Ticks) - epochTicks;
            //double unixTime = unixTicks.TotalSeconds;


            return dto.ToUnixTimeSeconds();

        }

        public static DateTime ToUnixDate(this long dateTime)
        {

            var data = DateTimeOffset.FromUnixTimeSeconds(dateTime).DateTime;

            var normdate = new DateTimeOffset(data);

            return normdate.DateTime;
        }


    }
}
