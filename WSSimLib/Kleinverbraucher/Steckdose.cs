namespace WSSimLib.Kleinverbraucher;

public class Steckdose : Verbraucher
{
    public AderAnschluss L = new ();
    public AderAnschluss N = new ();
    public AderAnschluss PE = new ();
}
