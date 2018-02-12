using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static List<int> cutTheSticks(int[] arr)
    {
        // Complete this function
        List<int> op = new List<int> {arr.Length };
        int idx = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            int min = arr.Min();
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] -= min;
                if (arr[j] <= 0)
                {
                    arr=arr.Where(w => w != arr[j]).ToArray();
                    j--;
                }
            }
            if (arr.Length!=0)
                op.Insert(idx++, arr.Length);
            i = 0;
        }
        return op;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        List<int> result = cutTheSticks(arr);
        result.ForEach(Console.WriteLine);
    }
}
