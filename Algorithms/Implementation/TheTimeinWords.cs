using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string timeInWords(int h, int m) {
        // Complete this function
        string op = "";
        string[] num = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" ,"ten","eleven","twelve","thirteen","fourteen","quarter","sixteen","seventeen","eighteen","ninteen","twenty"};
        if (m == 0)
            op = num[h] + " o' clock";
        else if (m == 30)
            op = "half past " + num[h];
        else if (m < 30)
        {
            int sub = m - 20;
            if (m == 15)
                op = "quarter past " + num[h];
            else if (sub > 0)
                op = num[20] + " " + num[sub] + " minutes past " + num[h];
            else if(m==1)
                op = "one minute past " + num[h];
            else
                op = num[m] + " minutes past " + num[h];
        }
        else
        {
            int sub = 60 - m;
            if (m == 45)
                op = "quarter to " + num[h + 1];
            else if (sub > 20)
                op = num[20] + " " + num[sub - 20] + " minutes to " + num[h + 1];
            else if(m==59)
                op = "one minute to " + num[h + 1];
            else
                op = num[sub] + " minutes to " + num[h+1];
        }
        return op;
    }

    static void Main(String[] args) {
        int h = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        string result = timeInWords(h, m);
        Console.WriteLine(result);
    }
}
