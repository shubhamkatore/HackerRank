using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int utopianTree(int n) {
        // Complete this function
        int res = 1;
        for (int i = 1; i <= n; i++)
            res = i % 2 == 0 ? res+ 1 : res * 2;    
        return res;

        //Optimized
        //return (int)Math.Pow(2, (n + 1) / 2 + 1) - 1 - (n % 2);
    }

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int result = utopianTree(n);
            Console.WriteLine(result);
        }
    }
}
