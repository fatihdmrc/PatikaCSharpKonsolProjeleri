public class Dikdortgen : Sekil
{
    public Dikdortgen(double kisakenar, double uzunkenar)
    {
        Kisakenar = kisakenar;
        Uzunkenar = uzunkenar;
    }
    public double kisakenar;
    public double uzunkenar;
    public double Kisakenar
    {
        get => kisakenar;
        set
        {
            if (value < 0)
            {
                throw new Exception("Dikdörgenin kenarları 0 dan küçük olamaz!");
            }
            kisakenar = value;
        }
    }
    public double Uzunkenar
    {
        get => uzunkenar;
        set
        {
            if (value < 0)
            {
                throw new Exception("Dikdörgenin kenarları 0 dan küçük olamaz!");
            }
            uzunkenar = value;
        }
    }
    public override double alanHesapla()
    {
        return kisakenar * uzunkenar;
    }
    public override double cevreHesapla()
    {
        return 2 * (kisakenar + uzunkenar);
    }
}