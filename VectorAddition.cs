using System;
class Vector {
    public int X { get; set; }
    public int Y { get; set; }
    public Vector(int x, int y) {
        X = x;
        Y = y;
    }
    public static Vector operator +(Vector v1, Vector v2) {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }
    public void Display() {
        Console.WriteLine($"({X}, {Y})");
    }
}
class VectorAddition {
    static void Main(string[] args) {
        Console.Write("Enter the x component of the first vector: ");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the y component of the first vector: ");
        int y1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the x component of the second vector: ");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the y component of the second vector: ");
        int y2 = int.Parse(Console.ReadLine());
        Vector vector1 = new Vector(x1, y1);
        Vector vector2 = new Vector(x2, y2);
        Vector result = vector1 + vector2;
        Console.Write("Sum of the vectors: ");
        result.Display();
    }
}