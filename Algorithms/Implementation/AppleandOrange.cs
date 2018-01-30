using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        // Complete this function
        int apct=0, orct=0,tes;
            for (int i = 0; i < apples.Length; i++)
            {
                tes = a + apples[i];
                if (tes>=s && tes <= t)
                    apct++; 
            }   
            for (int i = 0; i < oranges.Length; i++)
            {
                tes = b + oranges[i];
                if (tes >= s && tes <= t)
                    orct++;
            }
            Console.WriteLine(apct+"\n"+orct); 
    }

    static void Main(String[] args) {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int t = Convert.ToInt32(tokens_s[1]);
        string[] tokens_a = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens_a[0]);
        int b = Convert.ToInt32(tokens_a[1]);
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] apple_temp = Console.ReadLine().Split(' ');
        int[] apple = Array.ConvertAll(apple_temp,Int32.Parse);
        string[] orange_temp = Console.ReadLine().Split(' ');
        int[] orange = Array.ConvertAll(orange_temp,Int32.Parse);
        countApplesAndOranges(s, t, a, b, apple, orange);
    }
}
