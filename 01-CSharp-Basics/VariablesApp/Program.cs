using System;

class Program
{
    static void Main()
    {
        string fullName = "Uzair Iqbal";
        int birthYear = 1993;
        double cgpa = 3.69;
        bool jobReady = true;

        //More Variables
        char grade = 'A';
        float height = 5.8f;
        decimal salary = 450000.75m;
        bool isOnline = false;

        Console.WriteLine($"Name: {fullName}");
        Console.WriteLine($"BirthDay: {birthYear}");
        Console.WriteLine($"CGPA: {cgpa}");
        Console.WriteLine($"Job Ready?: {jobReady}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Online?: {isOnline}");


    }
}