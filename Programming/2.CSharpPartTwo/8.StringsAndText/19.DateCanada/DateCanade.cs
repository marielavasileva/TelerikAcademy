﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;

class DateCanada
{
    static void Main()
    {
        string str = "Static void Main() 12.10.2012, 50.13.2012";

        DateTime date;
        foreach (Match item in Regex.Matches(str, @"\b\d{2}.\d{2}.\d{4}\b"))
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
    }
}