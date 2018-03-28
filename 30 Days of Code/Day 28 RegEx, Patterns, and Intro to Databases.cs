using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        List<string> resname = new List<string> { };
        for (int a0 = 0; a0 < N; a0++)
        {
            string[] tokens_firstName = Console.ReadLine().Split(' ');
            if (tokens_firstName[1].Contains("@gmail.com"))
                resname.Add(tokens_firstName[0]);
        }
        resname.Sort();
        foreach (var item in resname)
            Console.WriteLine(item);
    }
}
