public class Ucgen : Sekil
{
    public Ucgen(double kenar1, double kenar2, double kenar3, double taban, double yukseklik)
    {
        Kenar1 = kenar1;
        Kenar2 = kenar2;
        Kenar3 = kenar3;
        Taban = taban;
        Yukseklik = yukseklik;
    }
    public double taban;
    public double yukseklik;
    public double kenar1;
    public double kenar2;
    public double kenar3;
    public double Taban
    {
        get => taban;
        set
        {
            if (value < 0)
            {
                throw new Exception("Üçgenin taban değeri 0 dan küçük olamaz!");
            }
            taban = value;
        }
    }
    public double Yukseklik
    {
        get => yukseklik;
        set
        {
            if (value < 0)
            {
                throw new Exception("Üçgenin yükseklik değeri 0 dan küçük olamaz!");
            }
            yukseklik = value;
        }
    }
    public double Kenar1
    {
        get => kenar1;
        set
        {
            if (value < 0)
            {
                throw new Exception("Üçgenin kenar değeri 0 dan küçük olamaz!");
            }
            kenar1 = value;
        }
    }
    public double Kenar2
    {
        get => kenar2;
        set
        {
            if (value < 0)
            {
                throw new Exception("Üçgenin kenar değeri 0 dan küçük olamaz!");
            }
            kenar2 = value;
        }
    }
    public double Kenar3
    {
        get => kenar3;
        set
        {
            if (value < 0)
            {
                throw new Exception("Üçgenin kenar değeri 0 dan küçük olamaz!");
            }
            kenar3 = value;
        }
    }
    public override double alanHesapla()
    {
        return (Taban * Yukseklik) / 2;
    }
    public override double cevreHesapla()
    {
        return Kenar1 + Kenar2 + Kenar3;
    }
}