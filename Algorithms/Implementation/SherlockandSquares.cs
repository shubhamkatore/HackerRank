using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int squares(int a, int b) {
        // Complete this function
        return (int)Math.Floor(Math.Sqrt(b)) - (int)Math.Floor(Math.Sqrt(a - 1));
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            int result = squares(a, b);
            Console.WriteLine(result);
        }
    }
}
