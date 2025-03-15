public class Daire : Sekil
{
    public Daire(double yaricap)
    {
        Yaricap = yaricap;
    }
    public double yaricap;
    public double Yaricap
    {
        get => yaricap;
        set
        {
            if (value < 0)
            {
                throw new Exception("Dairenin yarıçap değeri 0 dan küçük olamaz");
            }
            yaricap = value;
        }
    }
    public override double alanHesapla()
    {
        double alan = Math.PI * Yaricap * Yaricap;
        return alan;
    }
    public override double cevreHesapla()
    {
        double cevre = 2 * Math.PI * yaricap;
        return cevre;
    }
}