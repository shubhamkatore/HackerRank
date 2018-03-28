using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
         double mealcost = Convert.ToDouble(Console.ReadLine());
            double totalcost=0;
            double tipcalc =(double)Convert.ToInt32(Console.ReadLine()) / 100;
            double taxcalc = (double)Convert.ToInt32(Console.ReadLine()) / 100;
            double tip = mealcost * tipcalc;
            double tax= mealcost * taxcalc;
            totalcost = Math.Round(mealcost + tip + tax);
            Console.WriteLine("The total meal cost is "+ totalcost + " dollars.");
    }
}