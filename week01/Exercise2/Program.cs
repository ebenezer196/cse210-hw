using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user their grade and store the variable
        Console.WriteLine("What is your grade percentage ? ");
        int grade = int.Parse(Console.ReadLine());

        //Let's determine the letter grade for a course 

        string letter ;
        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
           letter = "F"; 
        }

        //Let's determine the sign
        int lastdigit = grade %10 ;
        string sign = "";

        if (lastdigit >=7)
        {
            sign = "+";
        }

        else if (lastdigit <3)
        {
            sign = "-";
        }
       
       if (letter  == "A" && sign == "+" )
        {
            sign = ""; 
        }
        if (letter == "F")
        {
            sign = "";
        }

        //Lets display final grade 
        Console.WriteLine($"Your grade is : {letter} {sign}");

        if (grade >= 70)
        {
            Console.WriteLine ("Congratulation you passed the course ");
        }

        else
        {
            Console.WriteLine ("Don't give, next time will be better !");
        }

    }
}