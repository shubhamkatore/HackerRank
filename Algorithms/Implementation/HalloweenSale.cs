using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int howManyGames(int p, int d, int m, int s) {
        // Return the number of games you can buy
        int count = 0;
        while(s>=p)
        {
            s -= p;
            p = p - d > m ? p - d : m;
            count++;
        }
        return count;
    }

    static void Main(String[] args) {
        string[] tokens_p = Console.ReadLine().Split(' ');
        int p = Convert.ToInt32(tokens_p[0]);
        int d = Convert.ToInt32(tokens_p[1]);
        int m = Convert.ToInt32(tokens_p[2]);
        int s = Convert.ToInt32(tokens_p[3]);
        int answer = howManyGames(p, d, m, s);
        Console.WriteLine(answer);
    }
}
