using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string caesarCipher(string s, int k) {
        // Complete this function
        string op = "";
            char[] ret = s.ToCharArray();
            for (int i = 0; i < ret.Length; i++)
            {
                if (!char.IsLetter(ret[i]))
                {
                    op += ret[i];
                }
                else
                {
                    char d = char.IsUpper(ret[i]) ? 'A' : 'a';
                    op+=(char)((((ret[i] + k) - d) % 26) + d);
                }
            }
            return op;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());
        string result = caesarCipher(s, k);
        Console.WriteLine(result);
    }
}
