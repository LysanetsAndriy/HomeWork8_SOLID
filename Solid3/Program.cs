using System;

/*
Порушено принцип Liskov Substitution Principle.
Щоб вирішити цю проблему можна використати інтерфейс або абстрактний клас
для спільних властивостей та методів, а потім створити конкретні класи
Rectangle та Square, що реалізують цей інтерфейс або успадковуються від абстрактного класу.
*/

public interface IShape
{
    int Width { get; set; }
    int Height { get; set; }
    int GetArea();
}

public class Rectangle : IShape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

public class Square : IShape
{
    private int side;

    public int Width
    {
        get { return side; }
        set { side = value; }
    }

    public int Height
    {
        get { return side; }
        set { side = value; }
    }

    public int GetArea()
    {
        return side * side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape shape = new Square();
        shape.Width = 5;
        shape.Height = 10;

        Console.WriteLine(shape.GetArea());
        Console.ReadKey();
    }
}
