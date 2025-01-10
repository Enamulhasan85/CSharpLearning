using System;
using Fundamentals;

class Program
{
    static void Main(string[] args)
    {
        var john = new Person();
        john.FirstName = "John";
        john.LastName = "Smith";
        john.Intro();

        var max = new Person("Max");
        max.LastName = "Smith";
        max.Intro();

        var order = new Order();
        var customer = new Customer("Max");
        customer.Orders.Add(order);
        customer.Intro();

        // UpCasting
        Circle circle = new Circle();
        Shape shape = circle;

        circle.width = 200;
        shape.width = 100;
        Console.WriteLine(circle.width);

        // DownCasting
        //Circle circle1 = (Circle)shape;
        Circle circle1 = shape as Circle;
        if(circle1 != null){
            circle1.Draw();
        }
    }
}
