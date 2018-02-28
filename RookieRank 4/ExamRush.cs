/*Your final exam is approaching and you haven't begun to study. In order to have the best chance of passing the course, you resolve to study from now until exam time. Chapters vary in length, but not in value towards a passing grade, so you want to study as many complete chapters as possible. The order of chapters doesn't matter, but you must complete a chapter before it will help your grade.

Your task is to maximize the number of complete chapters you can study between now and exam time.

Complete the function examRush to return the integer value representing the maximum number of chapters you can study before the exam.

Input Format

The first line contains an integer number, (number of chapters) and an integer number, (hours left until the exam). Then there are lines, each containing the time, in hours required to study that chapter.

Constraints

Output Format

Print an integer number, which is the maximum number of chapters that can be studied completely before the start of the final examination.

Sample Input 0

2 2
1
2

Sample Output 0

1

*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static long examRush(long[] tm, long t)
    {
        // Complete this function
        long count = 0;
        Array.Sort(tm);
        for (int i = 0; i < tm.Length; i++)
        {
            t = t-tm[i];
            if (t>=0)
                count++;
            if (t == 0)
                break;
        }
        return count;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        long n = Convert.ToInt32(tokens_n[0]);
        long t = Convert.ToInt32(tokens_n[1]);
        long[] tm = new long[n];
        for (long tm_i = 0; tm_i < n; tm_i++)
        {
            tm[tm_i] = Convert.ToInt32(Console.ReadLine());
        }
        long result = examRush(tm, t);
        Console.WriteLine(result);
    }
}
