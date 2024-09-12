using System;
class Person {
    public string name;
    public int age;
    public float weight;

    public void PrintPerson() {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Weight: " + weight + " kg");
    }
}

class PersonData {
    static void Main(string[] args) {
        Person person1 = new Person();
        person1.name = "Kannan";
        person1.age = 19;
        person1.weight = 58;
        person1.PrintPerson();
    }
}