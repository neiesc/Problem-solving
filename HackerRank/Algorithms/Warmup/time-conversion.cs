// Time Conversion
// https://www.hackerrank.com/challenges/time-conversion/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        var s_split = s.Split(':');
        int hours = Convert.ToInt32(s_split[0]);
        int minutes = Convert.ToInt32(s_split[1]);
        int seconds = Convert.ToInt32(s_split[2].Substring(0, s_split[2].Length - 2));
        string midday = s_split[2].Substring(s_split[2].Length - 2);
        if (hours != 12 && midday == "PM")
            hours+= 12;
        else if (hours == 12 && midday == "AM")
            hours = 0;
            
        return $"{hours:00}:{minutes:00}:{seconds:00}";
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
