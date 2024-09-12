using System;
using System.Text.RegularExpressions;
class Validation {
    static void Main() {
        Console.Write("Enter your mobile number (format: xxxx-xxxxxx): ");
        string mobileNumber = Console.ReadLine();
        string pattern = @"^[98]\d{3}-\d{6}$";
        if (Regex.IsMatch(mobileNumber, pattern)) {
            Console.WriteLine("Mobile number is valid.");
        }
        else {
            Console.WriteLine("Mobile number is invalid.");
        }
    }
}