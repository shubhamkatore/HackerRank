using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int viralAdvertising(int n) {
        // Complete this function
        int sum = 0;
        int subs = 5;
        for (int i = 1; i <= n; i++)
        {
            subs = subs / 2;
            sum += subs;
            subs *= 3;
        }
        return sum;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int result = viralAdvertising(n);
        Console.WriteLine(result);
    }
}
