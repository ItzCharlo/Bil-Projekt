using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bil_Projekt
{
    internal class CompareAll : IComparer
    {
        //private string CompType;
        //public CompareAll(string CompType)
        //{
        //    this.CompType = CompType;
        //}
        //public int Compare(object car1, object car2)
        //{
        //    if(CompType == "Brand")
        //    {
        //       return ((Car)car1).brand.CompareTo(((Car)car2).brand);
        //    }
        //    else if(CompType == "TopSpeed")
        //    {
        //        return ((Car)car1).topspeed - ((Car)car2).topspeed;
        //    }
        //    else if(CompType == "Acceleration")
        //    {
        //        return ((Car)car1).GetAcceleration().CompareTo(((Car)car2).GetAcceleration());
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        private CarSortEnum CompType;
        public CompareAll(CarSortEnum CompType)
        {
            this.CompType = CompType;
        }
        public int Compare(object car1, object car2)
        {
            switch(CompType)
            {
                case CarSortEnum.Brand:
                    return ((Car)car1).brand.CompareTo(((Car)car2).brand);
                    break;
                case CarSortEnum.TopSpeed:
                    return ((Car)car1).topspeed.CompareTo(((Car)car2).topspeed);
                    break;
                case CarSortEnum.Acceleration:
                    return ((Car)car1).GetAcceleration().CompareTo(((Car)car2).GetAcceleration());
                    break;
                default:
                    return 0;
                
            }
        }
    }
}
