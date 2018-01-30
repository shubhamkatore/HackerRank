using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int migratoryBirds(int n, int[] ar) {
        // Complete this function
        int[] grp = new int[5] {0,0,0,0,0 };
        int res=0;
        for (int i = 0; i < n; i++)
            grp[ar[i] - 1]++;
        int max=grp.Max();
        for (int j = 0; j < 5; j++)
            if (grp[j] == max)
            {
                res = j + 1;
                break;
            }        
        return res;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }
}