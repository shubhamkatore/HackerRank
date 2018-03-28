using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   
class Solution
{
    Solution(int n, int k, int[] a)
    {
        Console.WriteLine(n + " " + k);
        for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");
        Console.WriteLine();
    }

    public static void Main(String[] args)
    {
        int testCases = 5;
        Console.WriteLine(testCases);
        new Solution(4, 3, new int[] { -1, 0, 4, 2 });
        new Solution(5, 2, new int[] { 0, -1, 2, 1, 4 });
        new Solution(7, 6, new int[] { 2, 0, -1, 1, 1, 1, 1 });
        new Solution(3, 1, new int[] { -1, 0, 4 });
        new Solution(6, 4, new int[] { 0, -1, 1, 4, 5, 6 });
    }
}

