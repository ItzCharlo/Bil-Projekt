using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usorteret");
            Car car1 = new Car("Mercedes", "AMG", MyColorEnum.black, 450, 1800, 330);
            Console.WriteLine(car1);

            Car car2 = new Car("tesla", "Model 3", MyColorEnum.Blue);
            car2.topspeed = 500;
            car2.weight = 2000;
            car2.hp = 700;
            Console.WriteLine(car2);

            Car car3 = new Car();
            car3.brand = "Toyota";
            car3.model = "Corolla";
            car3.color = MyColorEnum.Red;
            car3.topspeed = 280;
            car3.weight = 1300;
            car3.hp = 110;
            Console.WriteLine(car3);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("Sorteret af Acceleration");

            Car[] cars = new Car[3];
            cars[0] = car1;
            cars[1] = car2;
            cars[2] = car3;

            MyComparer mc = new MyComparer(); 
            int result = mc.Compare(car1, car2);
            Array.Sort(cars, new MyComparer());

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }

            //MyCompareBrand compBrand = new MyCompareBrand();
            //int Result = compBrand.Compare(cars[2], cars[3]);

            //Array.Sort(cars, compBrand);
            //Console.WriteLine("\nSorted Cars on Brand:");
            //foreach (Car c in cars)
            //{
            //    Console.WriteLine(c);
            //}

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            //MyCompareTopSpeed compTopSpeed = new MyCompareTopSpeed();
            //Array.Sort(cars, compTopSpeed);
            //Console.WriteLine("\nSorteret Cars on TopSpeed:");
            //foreach (Car c in cars)
            //{
            //    Console.WriteLine(c);
            //}

            //Console.WriteLine("Sortert af Brand");

            //CompareAll compbrand = new CompareAll("Brand");
            //Array.Sort(cars, compbrand);
            //foreach  (Car c in cars)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            //Console.WriteLine(" sorteret af TopSpeed");

            //CompareAll comptop = new CompareAll("TopSpeed");
            //Array.Sort(cars, comptop);
            //foreach (Car c in cars)
            //{
            //    Console.WriteLine(c);
            //}

            //Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            //Console.WriteLine("Accelerate");

            //CompareAll compacc = new CompareAll("Accelerate");
            //Array.Sort(cars, compacc);
            //foreach (Car c in cars)
            //{
            //    Console.WriteLine(c);
            //}

            CompareAll cmpBrand = new CompareAll(CarSortEnum.Brand);
            Array.Sort(cars, cmpBrand);
            Console.WriteLine("\nSorted Cars on Brand:");
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            CompareAll cmpTopSpeed = new CompareAll(CarSortEnum.TopSpeed);
            Array.Sort(cars, cmpTopSpeed);
            Console.WriteLine("\nSorted Cars on TopSpeed:");
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
