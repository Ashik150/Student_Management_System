using System;

public class Student
{
    public string? Name
    {
        get;
        private set;
    }
    public DateTime DateOfBirth
    {
        get;
        private set;
    }

    public string? StudentId
    {
        get;
        private set;
    }

    public Student(string? name, DateTime dateOfBirth, string? studentId)
    {

        ValidateInputs(name, dateOfBirth, studentId);

        this.Name = name;
        this.DateOfBirth = dateOfBirth;
        this.StudentId = studentId;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}, Date of Birth: {DateOfBirth.ToShortDateString()}, Student ID: {StudentId}, Age: {Age}");
    }

    private int CalculateAge()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;
        return age;
    }

    private static void ValidateInputs(string? name, DateTime dateOfBirth, string? studentId)
    {
        if (dateOfBirth > DateTime.Now)
        {
            throw new ArgumentException("Date of birth cannot be in the future.");
        }
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty.");
        }

        if (string.IsNullOrWhiteSpace(studentId))
        {
            throw new ArgumentException("Student ID cannot be empty.");
        }

    }

    public int Age
    {
        get
        {
            return CalculateAge();
        }
    }
}

class StudentManagementSystem
{
    static void Main(string[] args)
    {
        try
        {
            Student s1 = new Student("Ashik Khan", new DateTime(2001, 05, 30), "210042150");
            Student s2 = new Student("Shahriar Khan", new DateTime(2002, 05, 30), "210042153");

            s1.PrintDetails();
            s2.PrintDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
