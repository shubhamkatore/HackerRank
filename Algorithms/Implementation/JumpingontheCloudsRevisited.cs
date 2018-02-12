using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int jumpingOnClouds(int[] c, int k) {
        // Complete this function
        int res=100,len=c.Length;
        for (int i = k; i <=len; i+=k)
            res = c[i%len]==0?res - 1:res-3;
        return res;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        int result = jumpingOnClouds(c, k);
        Console.WriteLine(result);
    }
}
