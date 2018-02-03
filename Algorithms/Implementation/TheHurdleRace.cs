using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int hurdleRace(int k, int[] height) {
        // Complete this function
        int mb=height.Max() - k;
        return mb < 0 ? 0 : mb;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp,Int32.Parse);
        int result = hurdleRace(k, height);
        Console.WriteLine(result);
    }
}
