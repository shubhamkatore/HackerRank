//Note : This is not optimized solution
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] acmTeam(string[] topic) {
        // Complete this function
        List<int> maxtopics = new List<int>();
        for (int i = 0; i < topic.Length-1; i++)
            for (int j = i+1; j < topic.Length; j++)
            {
                int topics = 0;
                char[] first = topic[i].ToCharArray();
                char[] second = topic[j].ToCharArray();
                for (int k = 0; k < first.Length; k++)
                    topics+=(Convert.ToInt32(first[k].ToString(),2) | Convert.ToInt32(second[k].ToString(),2));
                maxtopics.Add(topics);
            }
        int max=maxtopics.Max();
        return new int[]{max, maxtopics.ToArray().Count(x => x == max) };
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] topic = new string[n];
        for(int topic_i = 0; topic_i < n; topic_i++){
           topic[topic_i] = Console.ReadLine();   
        }
        int[] result = acmTeam(topic);
        Console.WriteLine(String.Join("\n", result));


    }
}
