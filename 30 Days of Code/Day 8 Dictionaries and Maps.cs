using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
         Dictionary<string, long> phb = new Dictionary<string, long> { };
        int nob = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < nob; i++)
        {
            string[] ip = Console.ReadLine().Split(' ');
            phb.Add(ip[0], Convert.ToInt64(ip[1]));
        }
        string a = "";
        while(!String.IsNullOrEmpty(a=Console.ReadLine()))
        {
            string op = "";
            try
            {
                op = a + "=" + phb[a];
            }
            catch (Exception)
            {
                op = "Not found";
            }
            Console.WriteLine(op);
        }
    }
}