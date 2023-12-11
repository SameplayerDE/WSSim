namespace WSSimLib;

public class LeitungsFactory
{
    public static Leitung Create(LeitungsTyp type)
    {
        var result = new Leitung();
        switch (type)
        {
            case LeitungsTyp.NYM525:
                {
                    result.Add(new Ader(Farbe.Brown, 2.5));
                    result.Add(new Ader(Farbe.Gray, 2.5));
                    result.Add(new Ader(Farbe.Black, 2.5));
                    result.Add(new Ader(Farbe.Blue, 2.5));
                    result.Add(new Ader(Farbe.Green_Yellow, 2.5));
                    break;
                }
            case LeitungsTyp.NYM515:
                {
                    result.Add(new Ader(Farbe.Brown, 1.5));
                    result.Add(new Ader(Farbe.Gray, 1.5));
                    result.Add(new Ader(Farbe.Black, 1.5));
                    result.Add(new Ader(Farbe.Blue, 1.5));
                    result.Add(new Ader(Farbe.Green_Yellow, 1.5));
                    break;
                }
            case LeitungsTyp.NYM325:
                {
                    result.Add(new Ader(Farbe.Brown, 2.5));
                    result.Add(new Ader(Farbe.Blue, 2.5));
                    result.Add(new Ader(Farbe.Green_Yellow, 2.5));
                    break;
                }
            case LeitungsTyp.NYM315:
                {
                    result.Add(new Ader(Farbe.Brown, 1.5));
                    result.Add(new Ader(Farbe.Blue, 1.5));
                    result.Add(new Ader(Farbe.Green_Yellow, 1.5));
                    break;
                }
        }
        return result;
    }
}
