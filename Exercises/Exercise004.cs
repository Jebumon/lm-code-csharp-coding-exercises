﻿using System;
namespace Exercises
{
    public class Exercise004
    {
        public static int ONE_GIGASECOND = 1000000000;
        public static DateTime AddGigaSecond(DateTime dateTime) => dateTime.AddSeconds(ONE_GIGASECOND);
    }
}
