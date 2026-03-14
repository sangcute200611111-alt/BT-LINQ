using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}

class Program
{
    static void Main()
    {
        string info = "Vo Van Sang | 2415053122237 | 24T2";
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        List<Student> students = new List<Student>() {
            new Student{Id=1, Name="An", Score=8},
            new Student{Id=2, Name="Binh", Score=6},
            new Student{Id=3, Name="Chi", Score=9},
            new Student{Id=4, Name="Dung", Score=7}
        };

        Console.WriteLine($"{info} | Bai 7");
        bool has7 = numbers.Any(n => n > 10);
        Console.WriteLine("Co so > 10 khong? " + (has7 ? "Co" : "Khong"));

        Console.ReadLine();
    }
}