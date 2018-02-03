using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int pickingNumbers(int[] a) {
        // Complete this function
        Array.Sort(a);
        int max = 0;
        for (int i = 0; i < a.Length; i++)
        {
            int count = 0;
            for (int j = i; j < a.Length; j++)
                if (a[j] - a[i] <= 1)
                    count++;
            if (count > max)
                max = count;
        }
        return max;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int result = pickingNumbers(a);
        Console.WriteLine(result);
    }
}