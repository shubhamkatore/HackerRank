using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int designerPdfViewer(int[] h, string word) {
        // Complete this function
        int ht = 0;
        char[] charar = word.ToCharArray();
        for (int i = 0; i < charar.Length; i++)
        {
            int height = h[(int)charar[i] - 97];
            if (height > ht)
                ht = height;
        }
        return ht * charar.Length;
    }

    static void Main(String[] args) {
        string[] h_temp = Console.ReadLine().Split(' ');
        int[] h = Array.ConvertAll(h_temp,Int32.Parse);
        string word = Console.ReadLine();
        int result = designerPdfViewer(h, word);
        Console.WriteLine(result);
    }
}