using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int num = Convert.ToInt32(Console.ReadLine());
            if (num>=1 && num<=100)
            {
                if (num%2==0)
                {
                    if ((num>=2&&num<=5)|| num>20)
                    {
                        Console.WriteLine("Not Weird");
                    }
                    else
                    {
                        Console.WriteLine("Weird");
                    }
                }
                else
                {
                    Console.WriteLine("Weird");
                }
            }
    }
}
