using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}
class Student : Person{
    private int[] testScores; 
    public Student(string firstName, string lastName, int identification,int[] scores):base(firstName, lastName, identification)
    {
        testScores = scores;
    }

    public char Calculate()
    {
        double avg = this.testScores.Sum() / this.testScores.Length;
        char op = ' ';
        if (avg >= 90 && avg <= 100)
            op = 'O';
        else if (avg >= 80 && avg < 90)
            op = 'E';
        else if (avg >= 70 && avg < 80)
            op = 'A';
        else if (avg >= 55 && avg < 70)
            op = 'P';
        else if (avg >= 40 && avg < 55)
            op = 'D';
        else
            op = 'T';
        return op;
    }
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}