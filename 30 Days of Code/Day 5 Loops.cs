using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n>=2 && n<=20)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}",n,i,n*i);
                }
            }
    }
}
