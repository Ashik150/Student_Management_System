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
}

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello, World!");
    }
}
