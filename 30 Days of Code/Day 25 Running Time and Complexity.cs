using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int nums = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < nums; i++)
        {
            int num= Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            if (num==1)
                flag = true;
            for (int j = 2; j*j <=num; j++)
            {
                if (num%j==0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                Console.WriteLine("Not prime");
            else
                Console.WriteLine("Prime");
        }
    }
}