// Grading Students
// https://www.hackerrank.com/challenges/grading/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades) {
        /*
         * Write your code here.
         */
         int[] result = new int [grades.Length];

         for (int i = 0; i < grades.Length; i++)
         {
             var next_multiple = grades[i] + (5-(grades[i] % 5)); /* https://www.quora.com/How-do-I-get-the-next-multiple-of-5-of-a-number-in-C */
             if ((next_multiple - grades[i]) < 3 && grades[i] >= 38) {
                 result[i] = next_multiple;
             }
             else {
                result[i] = grades[i];
             }
         }

         return result;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
