using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string bonAppetit(int n, int k, int b, int[] ar)
    {
        // Complete this function
        int act = ar.Sum()-ar[k];
        return (act / 2 == b) ? "Bon Appetit" : Convert.ToString(b - act/2);
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int b = Convert.ToInt32(Console.ReadLine());
        string result = bonAppetit(n, k, b, ar);
        Console.WriteLine(result);
    }
}