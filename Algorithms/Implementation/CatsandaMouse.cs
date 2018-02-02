using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string catAndMouse(int x, int y, int z) {
        // Complete this function
        int xl = Math.Abs(x - z);
        int yl = Math.Abs(y - z);
        return xl == yl ? "Mouse C" :(xl<yl?"Cat A":"Cat B");
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string[] tokens_x = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(tokens_x[0]);
            int y = Convert.ToInt32(tokens_x[1]);
            int z = Convert.ToInt32(tokens_x[2]);
            string result = catAndMouse(x, y, z);
            Console.WriteLine( result);


        }
    }
}
