using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        List<int> lst = Array.ConvertAll(ar_temp, Int32.Parse).ToList();
        int result = 0;
        for (int i = 0; i < lst.Count-1; i++)
            for (int j = i+1; j < lst.Count; j++)
                if (lst[i]==lst[j])
                {
                    lst.RemoveAt(j);
                    lst.RemoveAt(i);
                    result++;
                    j = i;
                }
        Console.WriteLine(result);
    }
}
