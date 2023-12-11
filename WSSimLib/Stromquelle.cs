using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSSimLib;

public class Stromquelle
{
    public double Hertz;
    public readonly double Spannung = 230;

    public List<Ader> Outputs = new List<Ader>();

    public Stromquelle(double hertz = 50.0)
    {
        Hertz = hertz;
        Outputs = new()
        {
            new Ader(Farbe.Brown),
            new Ader(Farbe.Gray),
            new Ader(Farbe.Black),
            new Ader(Farbe.Blue),
            new Ader(Farbe.Green_Yellow),
        };
    }

    public void Update(double total, double delta)
    {
        for (int i = 0; i < 3; i++)
        {
            double phaseShift = i * 120;
            Outputs[i].Spannung = BerechneSpannung(total, phaseShift);
        }
    }

    private double BerechneSpannung(double time, double phaseShift)
    {
        double result =  Spannung * Math.Sin(2 * Math.PI * time + DegreeToRad(phaseShift));
        return result;
    }

    private double DegreeToRad(double degree)
    {
        return degree * (Math.PI / 180.0);
    }

}
