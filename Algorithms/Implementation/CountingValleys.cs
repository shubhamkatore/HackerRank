using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int countingValleys(int n, string s) {
        // Complete this function
        char[] c = s.ToCharArray();
        int steps= 0,count=0;
        for (int i = 0; i < c.Length; i++)
        {
            if (c[i] == 'U')
                steps++;
            else
                steps--;
            if (steps == 0 && c[i] == 'U')
                count++;
        }
        return count;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int result = countingValleys(n, s);
        Console.WriteLine(result);
    }
}
