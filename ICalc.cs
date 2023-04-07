using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Out
{
    interface ICalc
    {
         int Less(int valueToCompare);//возвращает кол-во маленьких знач чем valueToCompare
        int Greater(int valueToCompare);//возврат кол-во больших знач. чем valueToCompare
    }
}
