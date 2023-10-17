using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GoogeRA.Sprint2.TaskRewiev.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Sin(x) <= 1) && ((y > 0) && (y <= 0.5 ) && (x >= 0)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res; ;
        }
    }
}
