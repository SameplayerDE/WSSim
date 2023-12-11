using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSSimLib;

public class Leitung
{
    public List<Ader> Adern = new();
    public void Add(Ader ader)
    {
        Adern.Add(ader);
    }
}