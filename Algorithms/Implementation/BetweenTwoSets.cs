using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public static int getlcm(int[] numbers)
        {
            int lcm = 1;
            int divisor = 2;
            while (true)
            {
                int cnt = 0;
                bool divisible = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0)
                        return 0;
                    else if (numbers[i] < 0)
                        numbers[i] = numbers[i] * (-1);
                    if (numbers[i] == 1)
                        cnt++;
                    if (numbers[i] % divisor == 0)
                    {
                        divisible = true;
                        numbers[i] = numbers[i] / divisor;
                    }
                }
                if (divisible)
                    lcm = lcm * divisor;
                else
                    divisor++;
                if (cnt == numbers.Length)
                    return lcm;
            }
        }
        static int getTotalX(int[] a, int[] b)
        {
            // Complete this function
            int count = 0;
            int lcm = getlcm(a);
            int gcd = b.Aggregate(GCD);
            for (int i = lcm; i <= gcd; i += lcm)
                if (gcd % i == 0) { count++; }
            return count;
        }
    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp,Int32.Parse);
        int total = getTotalX(a, b);
        Console.WriteLine(total);
    }
}
