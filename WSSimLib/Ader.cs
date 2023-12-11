namespace WSSimLib;

public class Ader
{
    public Farbe Farbe;
    public double Durchmesser;
    public double Spannung;

    public Ader(Farbe farbe, double durchmesser = 1.5)
    {
        Farbe = farbe;
        Durchmesser = durchmesser;
    }
}
