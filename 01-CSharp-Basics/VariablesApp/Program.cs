using System;

class Program
{
    static void Main()
    {
        //Integer Variable
        int age = 32;
        Console.WriteLine($"Age: {age}");

        //Float Variable (add f at the end)
        float height = 5.9f;
        Console.WriteLine($"Height: {height}");

        //Decimal Variable (add m at the end)
        decimal salary = 45000.50m;
        Console.WriteLine($"Salary: {salary}");

        //Character Variable
        char grade = 'A';
        Console.WriteLine($"Grade : {grade}");

        //Boolean Variable
        bool isActive = true;
        Console.WriteLine($"Is Active: {isActive}");

        //String Variable (Reference Type)
        string name = "Uzair";
        Console.WriteLine($"Name: {name}");

        var country = "Pakistan";
        Console.WriteLine($"Country: {country}");

        const double Pi=3.14159;
        Console.WriteLine($"Pi: {Pi}");

    }
}