using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] circularArrayRotation(int[] a, int[] m,int k)
    {
        // Complete this function
        int alen = a.Length;
        int mlen = m.Length;
        for (int i = 0; i < m.Length; i++)
            m[i] = a[(alen + m[i] - (k % alen))%alen];
        return m;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        int q = Convert.ToInt32(tokens_n[2]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int[] m = new int[q];
        for (int m_i = 0; m_i < q; m_i++)
        {
            m[m_i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] result = circularArrayRotation(a, m,k);
        Console.WriteLine(String.Join("\n", result));


    }
}
