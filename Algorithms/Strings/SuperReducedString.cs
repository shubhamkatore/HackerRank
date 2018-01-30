using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string super_reduced_string(string s){
        // Complete this function
        char[] cha = s.ToCharArray();
            for (int i = 0; i < cha.Length-1; i++)
            {
                char[] ch = s.ToCharArray();
                for (int j = 0; j < ch.Length-1; j++)
                {
                    if (ch[j] == ch[j + 1])
                    {
                        var aStringBuilder = new System.Text.StringBuilder(s);
                        aStringBuilder.Remove(j, 2);
                        s = aStringBuilder.ToString();
                        break;
                    }
                }
                
            }
            return s==""? "Empty String":s;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = super_reduced_string(s);
        Console.WriteLine(result);
    }
}