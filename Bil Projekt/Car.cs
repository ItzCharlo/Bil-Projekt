using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_Projekt
{
    internal class Car
    {
        private string _Brand;
        private string _Model;
        private MyColorEnum _Color;
        private int _Topspeed;
        private double _Weight;
        private int _HP;

        public Car() { }

        public Car (string brand, string model, MyColorEnum color)
        {
            _Brand = brand;
            _Model = model;
            _Color = color;
        }

        public Car (string brand, string model, MyColorEnum color, int top, double weight, int hp)
            : this(brand, model, color)
        {
            //_Brand = brand;
            //_Model = model;
            //_Color = color;
            _Topspeed = top;
            _Weight = weight;
            _HP = hp;

        }
        
        public string brand 
        {
            get { return _Brand; }
            set { _Brand = value; }
        }

        public string model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        public MyColorEnum color
        {
            get { return _Color;}
            set { _Color = value;}
        }
            

        public int topspeed
        {
            get { return _Topspeed; }
            set { _Topspeed = value; }
        }

        public double weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public int hp
        {
            get { return _HP; }
            set { _HP = value; }
        }

        public double GetAcceleration()
        {
           return _Weight / _HP;
        }

        public override string ToString()
        {
            return String.Format("Brand : {0,-8}, Model: {1,-8}, Color: {2,-8}, TopSpeed: {3,-8}, Weight: {4,-8}, HP: {5,-8}, 0-100: {6,-8}", this.brand, this.model, this.color, this.topspeed, this.weight, this.hp, GetAcceleration());
        }
    }
}
