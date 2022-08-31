using System;
namespace Exercises
{
    public class Exercise004
    {
        public static int ONE_GIGA_SECOND = 1000000000;
        public static DateTime AddGigaSecond(DateTime dateTime) => dateTime.AddSeconds(ONE_GIGA_SECOND);
    }
}
