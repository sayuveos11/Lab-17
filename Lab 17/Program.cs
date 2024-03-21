using System;
using System.Text;

// Абстрактний клас Body
public abstract class Body
{
    // Віртуальний метод для обчислення площі поверхні
    public abstract double SurfaceArea();

    // Віртуальний метод для обчислення об'єму
    public abstract double Volume();
}

// Похідний клас Parallelepiped
public class Parallelepiped : Body
{
    private double _length;
    private double _width;
    private double _height;

    // Конструктор класу Parallelepiped
    public Parallelepiped(double length, double width, double height)
    {
        _length = length;
        _width = width;
        _height = height;
    }

    // Реалізація методу для обчислення площі поверхні
    public override double SurfaceArea()
    {
        return 2 * (_length * _width + _length * _height + _width * _height);
    }

    // Реалізація методу для обчислення об'єму
    public override double Volume()
    {
        return _length * _width * _height;
    }
}

// Похідний клас Ball
public class Ball : Body
{
    private double _radius;

    // Конструктор класу Ball
    public Ball(double radius)
    {
        _radius = radius;
    }

    // Реалізація методу для обчислення площі поверхні
    public override double SurfaceArea()
    {
        return 4 * Math.PI * Math.Pow(_radius, 2);
    }

    // Реалізація методу для обчислення об'єму
    public override double Volume()
    {
        return (4 / 3) * Math.PI * Math.Pow(_radius, 3);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Приклад використання класів
        Parallelepiped parallelepiped = new Parallelepiped(4, 6, 8);
        Console.WriteLine("Площа поверхні паралелепіпеда " + parallelepiped.SurfaceArea());
        Console.WriteLine("Обсяг паралелепіпеда: " + parallelepiped.Volume());

        Ball ball = new Ball(9);
        Console.WriteLine("Площа поверхні кулі: " + ball.SurfaceArea());
        Console.WriteLine("Обсяг кулі: " + ball.Volume());
    }
}
