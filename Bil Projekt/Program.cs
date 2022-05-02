﻿using System;
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
            Console.WriteLine("Sorteret");

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

            Console.ReadLine();
        }
    }
}
