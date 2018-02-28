using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int minimumDistances(int[] a) {
        // Complete this function
        int min = -1;
        List<int> sub = new List<int> { };
        for (int i = 0; i < a.Length-1; i++)
            for (int j = i+1; j < a.Length; j++)
                if (a[i]==a[j])
                    sub.Add(Math.Abs(i-j));
        if (sub.Count > 0)
            min = sub.Min();
        return min;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int result = minimumDistances(a);
        Console.WriteLine(result);
    }
}
