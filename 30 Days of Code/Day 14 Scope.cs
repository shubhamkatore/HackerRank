using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
    	// Add your code here
    public Difference(int[] elm)
    {
        elements = elm;
    }
    public void computeDifference()
    {
        maximumDifference = Math.Abs(elements[0] - elements[1]);
        for (int i = 0; i < this.elements.Length; i++)
            for (int j = i+1; j < this.elements.Length; j++)
                maximumDifference = maximumDifference < Math.Abs(elements[i] - elements[j]) ? Math.Abs(elements[i] - elements[j]) : maximumDifference;
    }
} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}