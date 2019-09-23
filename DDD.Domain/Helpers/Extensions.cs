using System;
using System.Collections.Generic;
using System.Text;

public static class Extensions
{
    public static float ToSingle(this double value)
    {
        return Convert.ToSingle(value);
    }

    public static DateTime ToDate(this string value)
    {
        return DateTime.Parse(value);
    }
}
