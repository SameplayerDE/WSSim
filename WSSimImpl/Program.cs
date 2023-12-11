using System.Timers;
using WSSimLib;


namespace WSSimImpl;

public class Program
{
    public static void Main(string[] args)
    {
        var sim = new Sim();
        sim.Start();
    }
}