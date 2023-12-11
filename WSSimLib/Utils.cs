using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSSimLib;

public class Utils
{

    public static double CheckVoltage(Ader a, Ader b)
    {
        return a.Spannung - b.Spannung;
    }

}