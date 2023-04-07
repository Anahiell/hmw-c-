using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Out
{
    interface ICalc2
    {
        int CountDistinct();//кол-во уникальных значений в массиве
        int EqualToValue(int valueToComp);//кол-во значений равному valueToComp
    }
}
