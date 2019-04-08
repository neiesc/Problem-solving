using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the designerPdfViewer function below.
    static int designerPdfViewer(int[] h, string word) {
        int tallestLetterHigh = 0;
        foreach (var letter in word)
        {
            var actualLetterHigh = h[(char.ToUpper(letter) - 64) - 1];
            if (tallestLetterHigh < actualLetterHigh)
            {
                tallestLetterHigh = actualLetterHigh;
            }
        }

        return word.Length * tallestLetterHigh;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
        ;
        string word = Console.ReadLine();

        int result = designerPdfViewer(h, word);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}