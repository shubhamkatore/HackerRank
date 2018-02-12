using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int jumpingOnClouds(int[] c) {
        // Complete this function
        int count = 0;
        for (int i = 0; i < c.Length-1; i++, count++)
            if (i< c.Length-2 &&c[i+2]==0)
                i++;
        return count;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        int result = jumpingOnClouds(c);
        Console.WriteLine(result);
    }
}
