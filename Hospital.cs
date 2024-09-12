using System;
class Patient {
    public string Name { get; set; }
    public DateTime DateOfAdmission { get; set; }
    public int Age { get; set; }
    public string Disease { get; set; }
    public DateTime DateOfDischarge { get; set; }
    public decimal TotalBillsPaid { get; set; }
    public void GetPatientInfo() {
        Console.Write("Enter patient's name: ");
        Name = Console.ReadLine();
        Console.Write("Enter date of admission (yyyy-mm-dd): ");
        DateOfAdmission = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter age of patient: ");
        Age = int.Parse(Console.ReadLine());
        Console.Write("Enter disease: ");
        Disease = Console.ReadLine();
        Console.Write("Enter date of discharge (yyyy-mm-dd): ");
        DateOfDischarge = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter total bills paid: ");
        TotalBillsPaid = decimal.Parse(Console.ReadLine());
    }
    public void DisplayPatientInfo() {
        Console.WriteLine("\nPatient Information:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Date of Admission: {DateOfAdmission.ToShortDateString()}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Disease: {Disease}");
        Console.WriteLine($"Date of Discharge: {DateOfDischarge.ToShortDateString()}");
        Console.WriteLine($"Total Bills Paid: ${TotalBillsPaid}");
    }
}
class Hospital {
    static void Main(string[] args) {
        Patient patient = new Patient();
        patient.GetPatientInfo();
        patient.DisplayPatientInfo();
    }
}