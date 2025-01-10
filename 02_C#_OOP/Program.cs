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

    }
}
