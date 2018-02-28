using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int beautifulTriplets(int d, int[] arr) {
        // Complete this function
        int len = arr.Length;
        int count = 0;
        for (int i = 0; i < len; i++)
            for (int j = i+1; j < len; j++)
                if(arr[j] - arr[i] == d)
                    for (int k = j + 1; k < len; k++)
                        if (arr[k] - arr[j] == d)
                            count++;
        return count;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int d = Convert.ToInt32(tokens_n[1]);
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        int result = beautifulTriplets(d, arr);
        Console.WriteLine(result);
    }
}
