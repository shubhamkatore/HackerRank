using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string a =Convert.ToString(n, 2);
        int op = 1;
        int count = 1;
        char current = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] == current)
            {
                count++;
                op = count > op ? count : op;
            }
            else
            {
                current = a[i];
                count = 1;
            }
        }
        Console.WriteLine(op);
    }
}
