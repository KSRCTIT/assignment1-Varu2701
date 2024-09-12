using System;
class Employee {
    private int jobCatg;
    private int empNo;
    private string empName;
    private decimal basicSalary;
    private decimal hra;
    private decimal da;
    private decimal pf;
    private decimal loan;
    private decimal netSalary;
    public Employee(decimal basicSalary, decimal hra, decimal da, decimal pf, decimal loan) {
        this.basicSalary = basicSalary;
        this.hra = hra;
        this.da = da;
        this.pf = pf;
        this.loan = loan;
    }
    public void Input() {
        Console.Write("Enter employee number: ");
        empNo = int.Parse(Console.ReadLine());
        Console.Write("Enter employee name: ");
        empName = Console.ReadLine();
        Console.Write("Enter job category (1 for Table-I, 2 for Table-II): ");
        jobCatg = int.Parse(Console.ReadLine());
    }
    public void CalculateSalary() {
        switch (jobCatg) {
            case 1:
                basicSalary = 8000;
                hra = 0.10m * basicSalary;
                da = 0.20m * basicSalary;
                loan = 300;
                pf = 500;
                break;
            case 2:
                basicSalary = 15000;
                hra = 0.20m * basicSalary;
                da = 0.30m * basicSalary;
                loan = 600;
                pf = 1000;
                break;
            default:
                Console.WriteLine("Invalid job category.");
                return;
        }
        netSalary = basicSalary + hra + da - loan - pf;
    }
    public void Display() {
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine($"Employee Number: {empNo}");
        Console.WriteLine($"Employee Name: {empName}");
        Console.WriteLine($"Basic Salary: Rs. {basicSalary}");
        Console.WriteLine($"HRA: Rs. {hra}");
        Console.WriteLine($"DA: Rs. {da}");
        Console.WriteLine($"Loan: Rs. {loan}");
        Console.WriteLine($"PF: Rs. {pf}");
        Console.WriteLine($"Net Salary: Rs. {netSalary}");
    }
}
class EmpNetSalary {
    static void Main(string[] args) {
        Employee employee = new Employee(0, 0, 0, 0, 0);
        employee.Input();
        employee.CalculateSalary();
        employee.Display();
    }
}