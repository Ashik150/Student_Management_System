using System;

public class Student
{
    private string? name;
    private DateTime dateOfBirth;
    private string? studentId;

    public string? Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public DateTime DateOfBirth
    {
        get
        {
            return dateOfBirth;
        }
        set
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentException("Date of birth cannot be in the future.");
            }
            dateOfBirth = value;
        }
    }
    public string? StudentId
    {
        get
        {
            return studentId;
        }
        set
        {
            studentId = value;
        }
    }

    public Student(string? name, DateTime dateOfBirth, string? studentId)
    {
        this.Name = name;
        this.DateOfBirth = dateOfBirth;
        this.StudentId = studentId;
    }

    private int CalculateAge()
    {
        int age = DateTime.Now.Year - dateOfBirth.Year;
        return age;
    }

    public int Age
    {
        get
        {
            return CalculateAge();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Student s1 = new Student("Ashik Khan", new DateTime(2001, 05, 30), "210042150");
            Student s2 = new Student("Shahriar Khan", new DateTime(2002, 05, 30), "210042153");

            System.Console.WriteLine($"Name: {s1.Name}, Date of Birth: {s1.DateOfBirth.ToShortDateString()}, Student ID: {s1.StudentId}, Age: {s1.Age}"
                + $"\nName: {s2.Name}, Date of Birth: {s2.DateOfBirth.ToShortDateString()}, Student ID: {s2.StudentId}, Age: {s2.Age}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
