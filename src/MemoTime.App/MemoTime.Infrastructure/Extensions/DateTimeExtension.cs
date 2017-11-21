﻿using System;

namespace MemoTime.Infrastructure.Extensions
{
    public static class DateTimeExtension
    {
        public static long ToTimestamp(this DateTime dateTime)
        {
            var unixEpochTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var time = dateTime.Subtract(new TimeSpan(unixEpochTime.Ticks));

            return time.Ticks / 10000;
        }
    }
}