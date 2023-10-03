using System;

class Program
{
    static void Main(string[] args)
    {
        // constructing data
        Assignment assignment1 = new Assignment("Bobby Joe", "Multiplication");
        MathAssignment mathAssignment1 = new MathAssignment("Mary Sue", "Fractions", "Section 7.3", "Problems 8-19");
        WritingAssignment writingAssignment1 = new WritingAssignment("John Smith", "Extreme Weather Events", "Oh Hail No!");

        // output
        Console.WriteLine();
        Console.WriteLine(assignment1.GetSummary() + "\n");
        Console.WriteLine(mathAssignment1.GetHomeworkList() + "\n");
        Console.WriteLine(writingAssignment1.GetWritingInformation() + "\n");
        Console.WriteLine();
    }
}