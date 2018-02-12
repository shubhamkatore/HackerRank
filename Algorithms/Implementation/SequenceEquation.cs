using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] permutationEquation(int[] p) {
        // Complete this function
        int n = p.Length;
        int[] res = new int[n];
        int[] inv = new int[n + 1];
        int j = 0,i=0;
        for (int x = 1; x <= n; x++)
            inv[p[j++]] = x;
        for (int x = 1; x <= n; x++)
            res[i++] = inv[inv[x]];
        return res;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] p_temp = Console.ReadLine().Split(' ');
        int[] p = Array.ConvertAll(p_temp,Int32.Parse);
        int[] result = permutationEquation(p);
        Console.WriteLine(String.Join("\n", result));


    }
}
