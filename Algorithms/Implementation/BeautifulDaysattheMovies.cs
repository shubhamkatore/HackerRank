using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int beautifulDays(int i, int j, int k) {
        // Complete this function
        int count=0;
        for (int l = i; l <= j; l++)
            if (Math.Abs(l - int.Parse(new String(l.ToString().Reverse().ToArray()))) % k == 0)
                count++;
        return count;
    }

    static void Main(String[] args) {
        string[] tokens_i = Console.ReadLine().Split(' ');
        int i = Convert.ToInt32(tokens_i[0]);
        int j = Convert.ToInt32(tokens_i[1]);
        int k = Convert.ToInt32(tokens_i[2]);
        int result = beautifulDays(i, j, k);
        Console.WriteLine(result);
    }
}