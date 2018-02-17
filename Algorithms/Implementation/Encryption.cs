using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string encryption(string s) {
        // Complete this function
        s=s.Replace(" ", string.Empty);
        double sqrt = Math.Sqrt((double)s.Length);
        int row =(int) Math.Floor(sqrt);
        int column = row >= sqrt ? row : row + 1;
        string op = "";
        for (int i = 0; i < column; i++)
        {
            for (int j = i; j < s.Length; j+= column)
                op += s[j];
            op += " ";
        }
        return op;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = encryption(s);
        Console.WriteLine(result);
    }
}
