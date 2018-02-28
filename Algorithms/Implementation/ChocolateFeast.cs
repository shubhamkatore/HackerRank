using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int chocolateFeast(int n, int c, int m) {
        // Complete this function
        int chocolate = n / c;
        int wrap = chocolate;
        while(m<=wrap)
        {
            wrap -= m;
            chocolate++;
            wrap++;
        }
        return chocolate;
    }

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int c = Convert.ToInt32(tokens_n[1]);
            int m = Convert.ToInt32(tokens_n[2]);
            int result = chocolateFeast(n, c, m);
            Console.WriteLine(result);
        }
    }
}
