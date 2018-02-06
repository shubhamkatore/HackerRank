/*In the original version of Russian Roulette, there are active and inactive zones a contestant has to pass through to win, and also a trap door.

You are playing a revised version of the game, where, you have to unlock all doors in a given setting, in a given fashion, to enter the playig area.

    Initially, any door is either locked or unlocked.
    If a door is locked and you unlock it, then
        if the next consecutive door is locked, it will automatically get unlocked.
        if the next consecutive door is already unlocked, nothing will happen.
        there will be no effect on any following door. 

For example, if there are doors as shown below, where denotes an unlocked door, and denotes a locked door, a minimum of operations, will be required to unlock all doors.

image

Note: You are allowed to unlock the doors in any order you wish.

Complete the function revisedRussianRoulette that takes an integer array denoting status of each door in the array, and return an integer array denoting the minimum and maximum number of unlock operations needed to unlock all the doors.

Input Format

The first line contains a single integer , denoting the total number of doors.

The next line contains space separated integers, either or . denotes a locked door and denotes an unlocked door.

Constraints

Output Format

Print two integers separated by one space, denoting the minimum and maximum number of unlock operations needed respectively.

Sample Input 0

10
0 1 1 0 1 1 1 1 0 0

Sample Output 0

3 6

*/
//Solution

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] revisedRussianRoulette(int[] doors) {
        // Complete this function
        int[] res = { 0, 0 };
        for (int i = 0; i < doors.Length; i++)
            if (doors[i]==1)
            {
                res[1]++;
                res[0]++;
                doors[i] = 0;
                if (i != doors.Length - 1 && doors[i + 1] == 1)
                {
                    res[1]++;
                    doors[i++] = 0;
                }        
            }

        return res;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] doors_temp = Console.ReadLine().Split(' ');
        int[] doors = Array.ConvertAll(doors_temp,Int32.Parse);
        int[] result = revisedRussianRoulette(doors);
        Console.WriteLine(String.Join(" ", result));


    }
}
