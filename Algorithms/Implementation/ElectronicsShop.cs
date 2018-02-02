using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getMoneySpent(int[] keyboards, int[] drives, int s){
        // Complete this function
        int max=-1;
        for (int i = 0; i < keyboards.Length; i++)
            for (int j = 0; j < drives.Length; j++)
            {
                int amt = keyboards[i] + drives[j];
                if (amt <= s && amt>max)
                    max = amt;
            }

        return max;
    }

    static void Main(String[] args) {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        string[] keyboards_temp = Console.ReadLine().Split(' ');
        int[] keyboards = Array.ConvertAll(keyboards_temp,Int32.Parse);
        string[] drives_temp = Console.ReadLine().Split(' ');
        int[] drives = Array.ConvertAll(drives_temp,Int32.Parse);
        //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
        int moneySpent = getMoneySpent(keyboards, drives, s);
        Console.WriteLine(moneySpent);
    }
}
