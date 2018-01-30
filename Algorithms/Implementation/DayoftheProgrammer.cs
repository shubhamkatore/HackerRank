using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string solve(int year){
        // Complete this function
        string date = "";
        if (year<1918)
            date = (year % 4 == 0 ? "12" : "13") + ".09." + year;
        else if (year==1918)
            date =  "26.09.1918";
        else if (year>1918)
            date = (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0) ? "12" : "13")+".09."+year;
        return date;
    }

    static void Main(String[] args) {
        int year = Convert.ToInt32(Console.ReadLine());
        string result = solve(year);
        Console.WriteLine(result);
    }
}
