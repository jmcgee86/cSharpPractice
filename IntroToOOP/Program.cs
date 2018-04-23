using System;

namespace CarExample
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Car car1 = new Car ("Red", "Toyota");
            SaloonCar saloonCar1 = new SaloonCar (2);
            SaloonCar saloonCar2 = new SaloonCar (3, "Nissan");
            SaloonCar saloonCar3 = new SaloonCar (4, "Ford", "purple");
            Console.WriteLine("The car is a: " + car1.color + " " + car1.manufacturer);
            Console.WriteLine("The first saloon car has " + saloonCar1.numberOfSeats + " seats");
            Console.WriteLine("The second saloon car has " + saloonCar2.numberOfSeats + " seats " + saloonCar2.manufacturer);
            Console.WriteLine("The third saloon car has " + saloonCar3.numberOfSeats + " seats " + saloonCar3.manufacturer + " " + saloonCar3.color);


        }
    }

    public class Car
    {
        public Car (string _color = null, string _manufacturer = null){
            this.color = _color;
            this.manufacturer = _manufacturer;
        }
        public string color {get; set;}
        public string manufacturer {get; set;}
    }

    public class SaloonCar : Car
    {
        public SaloonCar (int _numberOfSeats){
            this.numberOfSeats = _numberOfSeats;
        }

        public SaloonCar (int _numberOfSeats, string _manufacturer){
            this.numberOfSeats = _numberOfSeats;
            this.manufacturer = _manufacturer;
        }
        public SaloonCar (int _numberOfSeats, string _manufacturer, string _color){
            this.numberOfSeats = _numberOfSeats;
            this.color = _color;
            this.manufacturer = _manufacturer;
        }
        public int numberOfSeats {get; set;}

    }


}
