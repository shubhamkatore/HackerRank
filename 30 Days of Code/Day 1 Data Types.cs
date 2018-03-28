using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
                
        // Declare second integer, double, and String variables.
       int t = Convert.ToInt32(Console.ReadLine());
            double td = Convert.ToDouble(Console.ReadLine());
            string ts = Console.ReadLine();
            float add = (float)td + (float)d;
            // Read and save an integer, double, and String to your variables.
            Console.WriteLine(t + i);
            Console.WriteLine(add.ToString("0.0"));
            Console.WriteLine(s + ts);
        // Print the sum of both integer variables on a new line.
        
        // Print the sum of the double variables on a new line.
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        
  }
}