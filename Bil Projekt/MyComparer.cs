using System;
using System.Collections;

namespace Bil_Projekt
{
    public class MyComparer : IComparer
    {
        //public int compare(object care1, object car2)
        //{
        //    return ((Car)care1).GetAcceleration() - ((Car)car2).GetAcceleration();
        //    if (result > 0)
        //        return 1;
        //    else if (result < 0)
        //        return - 1;
        //    else
        //        return 0;
        //}

        public int Compare(object x, object y)
        {
            double result = ((Car)x).GetAcceleration() - ((Car)y).GetAcceleration();
            if (result > 0)
                return 1;
            else if (result < 0)
                return -1;
            else
                return 0;
        }
    }
}