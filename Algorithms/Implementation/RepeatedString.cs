using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static long repeatedString(string s, long n) {
        // Complete this function
        long count = 0;
        foreach (char c in s)
            if(c=='a')
                count++;
        long res = (n / s.Length) * count;
        if (n % s.Length!=0)
        {
            char[] tmp = s.ToCharArray();
            for (long i = 0; i < n % s.Length; i++)
                if (tmp[i] == 'a')
                    res++;
        }
        return res;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        long n = Convert.ToInt64(Console.ReadLine());
        long result = repeatedString(s, n);
        Console.WriteLine(result);
    }
}
