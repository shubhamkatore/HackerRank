using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int equalizeArray(int[] arr) {
        // Complete this function
        var group = arr.GroupBy(x => x);
        var largest = group.OrderByDescending(x => x.Count()).First();
        return arr.Length - largest.Count();
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        int result = equalizeArray(arr);
        Console.WriteLine(result);
    }
}
