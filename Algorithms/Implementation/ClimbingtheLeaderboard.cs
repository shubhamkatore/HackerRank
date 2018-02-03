using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] climbingLeaderboard(int[] scores, int[] alice) {
        // Complete this function
        int[] res = new int[alice.Length];
        int[] rank = scores.Distinct().ToArray();
        int last= rank.Length - 1;
        for (int i = 0; i < alice.Length; i++)
            for (int j = last; j >=0; j--)
            {
                if (rank[j]==alice[i])
                {
                    res[i] = j + 1;
                    last = j;
                    break;
                }   
                else if(rank[j] > alice[i])
                {
                    res[i] = j + 2;
                    last = j;
                    break;
                }
                else if ( j==0 && rank[j] < alice[i] )
                {
                    res[i] = j + 1;
                    break;
                }
            }
        return res;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] scores_temp = Console.ReadLine().Split(' ');
        int[] scores = Array.ConvertAll(scores_temp,Int32.Parse);
        int m = Convert.ToInt32(Console.ReadLine());
        string[] alice_temp = Console.ReadLine().Split(' ');
        int[] alice = Array.ConvertAll(alice_temp,Int32.Parse);
        int[] result = climbingLeaderboard(scores, alice);
        Console.WriteLine(String.Join("\n", result));


    }
}
