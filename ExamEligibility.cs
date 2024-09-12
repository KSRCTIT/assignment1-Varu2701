using System;
class ExamEligibility {
    static void Main() {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your 10th std percentage: ");
        double percentage = Convert.ToDouble(Console.ReadLine());
        if (age > 18 && age <= 30 && percentage >= 65) {
            Console.WriteLine("You are eligible to apply for the competitive exam.");
        }
        else {
            Console.WriteLine("You are not eligible to apply for the competitive exam.");
        }
    }
}