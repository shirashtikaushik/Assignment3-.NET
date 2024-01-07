using System;
using System.Collections.Generic;

    internal class Program2
    {
      static void Main(string[] args)
    {

        Console.WriteLine("Input the marks obtained in Physics: ");
        int physicsMarks = int.Parse(Console.ReadLine());

        Console.WriteLine("Input the marks obtained in Chemistry: ");
        int chemistryMarks = int.Parse(Console.ReadLine());

        Console.WriteLine("Input the marks obtained in Mathematics: ");
        int mathMarks = int.Parse(Console.ReadLine());

        // Check eligibility based on the criteria
        if ((mathMarks >= 65) && (physicsMarks >= 55) && (chemistryMarks >= 50) && (mathMarks + physicsMarks + chemistryMarks >= 180))
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else if ((mathMarks + physicsMarks) >= 140)
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
            Console.WriteLine("The candidate is not eligible for admission.");
        }
    }
}

