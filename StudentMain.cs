using System;
class Student {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string MobileNumber { get; set; }
    public virtual void GetData() {
        Console.Write("Enter student's name: ");
        Name = Console.ReadLine();
        Console.Write("Enter student's age: ");
        Age = int.Parse(Console.ReadLine());
        Console.Write("Enter student's address: ");
        Address = Console.ReadLine();
        Console.Write("Enter student's mobile number: ");
        MobileNumber = Console.ReadLine();
    }
    public virtual void PrintData() {
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Mobile Number: {MobileNumber}");
    }
}
class StudentMark : Student {
    public int Marks { get; set; }
    public override void GetData() {
        base.GetData();
        Console.Write("Enter student's marks: ");
        Marks = int.Parse(Console.ReadLine());
    }
    public override void PrintData() {
        base.PrintData();
        Console.WriteLine($"Marks: {Marks}");
        Console.WriteLine($"Grade: {GetGrade()}");
    }
    private string GetGrade() {
        if (Marks >= 90)
            return "A";
        else if (Marks >= 80)
            return "B";
        else if (Marks >= 70)
            return "C";
        else if (Marks >= 60)
            return "D";
        else
            return "F";
    }
}
class StudentMain {
    static void Main(string[] args) {
        StudentMark student = new StudentMark();
        student.GetData();
        student.PrintData();
    }
}