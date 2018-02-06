using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string[] bigSorting(string[] arr) {
        // Complete this function
        Array.Sort(arr, (string a, string b) => {
                if (a.Length == b.Length)
                    return string.Compare(a, b, StringComparison.Ordinal);
                return a.Length - b.Length;
            });
        return arr;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];
        for(int arr_i = 0; arr_i < n; arr_i++){
           arr[arr_i] = Console.ReadLine();   
        }
        string[] result = bigSorting(arr);
        Console.WriteLine(String.Join("\n", result));


    }
}