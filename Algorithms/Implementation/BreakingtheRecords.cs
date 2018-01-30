using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] breakingRecords(int[] score) {
        int high, low;
        high=low= score[0];
        int[] res = new int[2] { 0,0};
        for (int i = 1; i < score.Length; i++)
        {
            if (score[i]>high)
            {
                res[0]++;
                high = score[i];
            }
            else if (low> score[i])
            {
                res[1]++;
                low = score[i];
            }
        }
        return res;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] score_temp = Console.ReadLine().Split(' ');
        int[] score = Array.ConvertAll(score_temp,Int32.Parse);
        int[] result = breakingRecords(score);
        Console.WriteLine(String.Join(" ", result));


    }
}
