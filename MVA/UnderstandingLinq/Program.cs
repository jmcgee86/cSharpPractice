using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>(){
                new Car (){ VIN = "A1", Make = "BMW", Model = "550i", StickerPrice = 55000, Year = 2013 },
                new Car (){ VIN = "B2", Make = "Toyota", Model = "4Runner", StickerPrice = 35000, Year = 2014 },
                new Car (){ VIN = "C3", Make = "BMW", Model = "745li", StickerPrice = 75000, Year = 2015 },
                new Car (){ VIN = "D4", Make = "Ford", Model = "Escape", StickerPrice = 25000, Year = 2016 },
                new Car (){ VIN = "E5", Make = "BMW", Model = "55i", StickerPrice = 57000, Year = 2010 },
            };

            //LINQ query
            // var bmws = from car in myCars
            //             where car.Make == "BMW"
            //             && car.Year == 2010
            //             select car;

            // var orderedCars = from car in myCars
            //                     orderby car.Year descending
            //                     select car;

            //LINQ method

            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            // var orderedCars = myCars.OrderByDescending(p=>p.Year);
            
            // var firstBMW = myCars.OrderByDescending(p => p.Year).First(p=>p.Make == "BMW");

            // System.Console.WriteLine(firstBMW.VIN);

            // System.Console.WriteLine(myCars.TrueForAll(p=>p.Year>2012));
            // myCars.ForEach(p=> p.StickerPrice-=3000);
            // myCars.ForEach(p=>Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));
            // System.Console.WriteLine(myCars.Exists(p=>p.Model == "745li"));
            // System.Console.WriteLine(myCars.Sum(p=>p.StickerPrice));
            // foreach(var car in orderedCars)
            // {
            //     System.Console.WriteLine("{0}, {1}, {2}", car.Model, car.VIN, car.Year);
            // }

            // System.Console.WriteLine(myCars.GetType());
            // var orderedCars = myCars.OrderByDescending(p=>p.Year);
            // System.Console.WriteLine(orderedCars.GetType());
            var newCars = from car in myCars
                            where car.Make == "BMW"
                            && car.Year == 2010
                            select new { car.Make, car.Model };
            System.Console.WriteLine(newCars.GetType());
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }



    }
}
