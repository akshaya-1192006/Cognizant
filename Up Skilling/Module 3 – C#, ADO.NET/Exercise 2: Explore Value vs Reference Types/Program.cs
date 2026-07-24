using System;

class Student
{
    public string Name;
}
class Program
{
    static void ChangeValue(int number)
    {
        number = 100;
    }
    static void ChangeReference(Student student)
    {
        student.Name = "Akshaya";
    }
    static void Main(string[] args)
    {
        // Value Type
        int num = 10;
        Console.WriteLine("Before ChangeValue(): " + num);
        ChangeValue(num);
        Console.WriteLine("After ChangeValue(): " + num);
        Console.WriteLine();
        // Reference Type
        Student s = new Student();
        s.Name = "Reddy";
        Console.WriteLine("Before ChangeReference(): " + s.Name);
        ChangeReference(s);
        Console.WriteLine("After ChangeReference(): " + s.Name);
    }
}
