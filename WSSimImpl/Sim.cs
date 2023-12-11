using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSSimLib;

namespace WSSimImpl;

public class Sim
{
    public Stromquelle Stromquelle = new Stromquelle();
    public Leitung Zuleitung = LeitungsFactory.Create(LeitungsTyp.NYM525);

    public bool IsRunning { get; private set; }
    public double DeltaTime;
    public double TotalTime;

    public Sim() { }

    private double GetSystemSeconds()
    {
        return (DateTime.UtcNow - new DateTime(1999, 11, 10)).TotalSeconds;
    }

    public void Start()
    {
        IsRunning = true;
        double lastTime = GetSystemSeconds();
        double timer = 0;
        int updates = 0;

        while (IsRunning)
        {
            double currentTime = GetSystemSeconds();
            double delta = currentTime - lastTime;
            DeltaTime = delta;
            TotalTime += delta;
            lastTime = currentTime;
            timer += delta;

            while (timer >= 1.0 / Stromquelle.Hertz)
            {
                Tick();
                updates++;
                timer -= 1.0 / Stromquelle.Hertz;
            }

            if (updates >= Stromquelle.Hertz)
            {
                Console.WriteLine(Utils.CheckVoltage(Stromquelle.Outputs[0], Stromquelle.Outputs[3]));
                updates = 0;
            }

            Thread.Sleep(1);
        }
    }

    public void Tick()
    {
        Stromquelle.Update(TotalTime, DeltaTime);
        /*
        int spannung0 = (int)(Stromquelle.Outputs[0].Spannung / 10.0);
        int spannung1 = (int)(Stromquelle.Outputs[1].Spannung / 10.0);
        int spannung2 = (int)(Stromquelle.Outputs[2].Spannung / 10.0);

        for (int i = -23; i < 23; i++)
        {
            if (spannung0 == i)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("█"); // Blockzeichen
            }
            else if (spannung1 == i)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("█"); // Blockzeichen
            }
            else if (spannung2 == i)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("█"); // Blockzeichen
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ");
            }
        }

        Console.ResetColor(); // Setzt die Farbe zurück

        Console.WriteLine("");
        */
    }

    public void Stop()
    {
        IsRunning = false;
    }
}
