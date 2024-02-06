using Activity2;
using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Activity2
{
    public class Car
    {
        public string Brand
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        List<Car> list = new List<Car>();

        /*
        list.Add(1);
        list.Add(1);
        list.Add(1);
        list.Add(1);

        int num1 = 0;
        list.ForEach(x => num1 += x);

        */

        
        while (true)
        {
            Console.WriteLine("Enter new data: Y/N");

            if (Console.ReadLine() == "N")
            {
                break;
            }

            Car car1 = new Car();

            Console.Write("Enter Car Brand: ");
            car1.Brand = Console.ReadLine();

            Console.Write("Enter Car Color: ");
            car1.Color = Console.ReadLine();

            Console.Write("Enter Car Price: ");
            car1.Price = int.Parse(Console.ReadLine());

            list.Add(car1);
        }

        list.ForEach(x =>
        {
            Console.WriteLine("\n" + x.Brand);
            Console.WriteLine(x.Color);
            Console.WriteLine(x.Price);
            Console.WriteLine("\n");
        });
    }
}