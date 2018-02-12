using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int findDigits(int n) {
        // Complete this function
        int count = 0;
        char[] num_t = n.ToString().ToCharArray();
        int[] x = num_t.Select(c => Convert.ToInt32(c.ToString())).ToArray();
        for (int i = 0; i < x.Length; i++)
            if (x[i]!=0)
                count += n % x[i] == 0 ? 1 : 0; 
        return count;
    }

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int result = findDigits(n);
            Console.WriteLine(result);
        }
    }
}
