public class Kare : Sekil
{
    public Kare(double kenar)
    {
        Kenar = kenar;
    }
    public double kenar;
    public double Kenar
    {
        get => kenar;
        set
        {
            if (value < 0)
            {
                throw new Exception("Karenin kenar değeri 0 dan küçük olamaz!");
            }
            kenar = value;
        }
    }
    public override double alanHesapla()
    {
        return kenar * kenar;
    }
    public override double cevreHesapla()
    {
        return 4 * kenar;
    }
}