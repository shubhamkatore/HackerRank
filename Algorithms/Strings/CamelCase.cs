using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int camelcase(string s) {
        // Complete this function
        return s.Count(c => char.IsUpper(c))+1;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        int result = camelcase(s);
        Console.WriteLine(result);
    }
}
