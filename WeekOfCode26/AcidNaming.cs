/*Jonathan is in a science class, but because he does not understand how to name acids, he would like you to make a program for him. There are two types of acids at his level, and .

Conditions for naming an acid:

    If the given input starts with hydro and ends with ic then it is a non-metal acid.
    If the input only ends with ic then it is a polyatomic acid.
    If it does not have either case, then output not an acid.

For example, for the input, , the correct output is - as the input begins with hydro and ends withic.

Complete the function acidNaming which takes a string input with the name of the acid, and return a string describing the appropriate type of acid.

Input Format

The first line will contain an integer .
The next lines will contain a single word .

Constraints

    Word is made up of lower-case english letters.
    Length of

Output Format

If the word starts with hydro and ends with ic then it is a non-metal acid. Hence, the correct output is - .

If the word only ends with ic then it is a . Hence, the correct output is .

If the word does not meet any of the cases, then the correct output is .

Sample Input 0

3
hydrochloric
rainbowic
idontevenknow

Sample Output 0

non-metal acid
polyatomic acid
not an acid
*/

//Solution
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string acidNaming(string acid_name) {
        // Complete this function
        return acid_name.StartsWith("hydro") && acid_name.EndsWith("ic")? "non-metal acid" :(acid_name.EndsWith("ic")? "polyatomic acid" : "not an acid");
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < n; a0++){
            string acid_name = Console.ReadLine();
            string result = acidNaming(acid_name);
            Console.WriteLine(result);
        }
    }
}