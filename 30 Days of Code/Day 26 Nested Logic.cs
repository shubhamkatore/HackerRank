using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2) {
        // Complete this function
        int fine = 0;
        if (y1>y2)
            fine = 10000;
        else if(y1<=y2)
            if (m1>m2 && y1>=y2)
                fine = (m1 - m2) * 500;
            else if(m1<=m2)
                if (d1>d2&&m1>=m2&&y1>=y2)
                    fine = (d1 - d2) * 15;
        return fine;
    }

    static void Main(String[] args) {
        string[] tokens_d1 = Console.ReadLine().Split(' ');
        int d1 = Convert.ToInt32(tokens_d1[0]);
        int m1 = Convert.ToInt32(tokens_d1[1]);
        int y1 = Convert.ToInt32(tokens_d1[2]);
        string[] tokens_d2 = Console.ReadLine().Split(' ');
        int d2 = Convert.ToInt32(tokens_d2[0]);
        int m2 = Convert.ToInt32(tokens_d2[1]);
        int y2 = Convert.ToInt32(tokens_d2[2]);
        int result = libraryFine(d1, m1, y1, d2, m2, y2);
        Console.WriteLine(result);
    }
}