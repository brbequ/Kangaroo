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

class Solution
{

    // Complete the kangaroo function below.
    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        // Start with a basic equation and factor it down
        // (n * v1) + x1 == (n * v2) + x2
        // (x1 - x2) == (n * v2) - (n * v1)
        // (x1 - x2) == n(v2 - v1)
        // (x1 - x2) / (v2 - v1) = n

        // If kangaroo 2 is making shorter hops than kngaroo 1
        // and the equation divides evenly, they will converge
        if (v2 < v1 && (x1 - x2) % (v2 - v1) == 0)
            return "YES";

        return "NO";
    }

    static void Main(string[] args)
    {
        int[][] testcases = new int[][]
        {
            new int[] { 0, 3, 4, 2 },
            new int[] { 0, 2, 5, 3 }
        };

        foreach (int[] testcase in testcases)
        {
            string result = kangaroo(testcase[0], testcase[1], testcase[2], testcase[3]);
            Console.WriteLine(result);
        }
    }
}
