using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student(101, "Minh", 16),
            new Student(102, "Bao", 19),
            new Student(103, "An", 17),
            new Student(104, "Khanh", 15),
            new Student(105, "Phuong", 18)
        };
        Console.WriteLine("a. Danh sach hoc sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        Console.WriteLine("\nb. Hoc sinh tu 15 den 18 tuoi:");

        var age15To18 = students
            .Where(s => s.Age >= 15 && s.Age <= 18);

        foreach (var student in age15To18)
        {
            Console.WriteLine($"{student.Name} - {student.Age} tuoi");
        }

        Console.WriteLine("\nc. Hoc sinh co ten bat dau bang chu A:");

        var nameStartWithA = students
            .Where(s => s.Name.StartsWith("A"));

        foreach (var student in nameStartWithA)
        {
            Console.WriteLine($"{student.Name} - {student.Age} tuoi");
        }

        Console.WriteLine("\nd. Tong tuoi cua tat ca hoc sinh:");

        int totalAge = students.Sum(s => s.Age);

        Console.WriteLine($"Tong tuoi: {totalAge}");

        Console.WriteLine("\ne. Hoc sinh co tuoi lon nhat:");

        int maxAge = students.Max(s => s.Age);

        var oldestStudents = students
            .Where(s => s.Age == maxAge);

        foreach (var student in oldestStudents)
        {
            Console.WriteLine($"{student.Name} - {student.Age} tuoi");
        }

        Console.WriteLine("\nf. Danh sach sau khi sap xep tuoi tang dan:");

        var sortedStudents = students
            .OrderBy(s => s.Age);

        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        Console.ReadLine();
    }
}