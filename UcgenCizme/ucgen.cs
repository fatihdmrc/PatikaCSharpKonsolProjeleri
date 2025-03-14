public class Ucgen
{
    public Ucgen(int satiruzunlugu)
    {
        Ucgensatiruzunlugu = satiruzunlugu;
    }
    private int ucgensatiruzunlugu;
    public int Ucgensatiruzunlugu
    {
        get { return ucgensatiruzunlugu; }
        set
        {
            if (value < 2)
            {
                throw new Exception("Üçgenin taban genişliği 2 den küçük olamaz!");
            }
            ucgensatiruzunlugu = value;
        }
    }
    public void ucgenOlustur()
    {
        for (int i = 1; i <= Ucgensatiruzunlugu; i++)
        {
            if (i == Ucgensatiruzunlugu)
            {
                Console.Write("/"); // sol kenar yazar
                tabanYazdir(2 * (i - 1)); // taban oluşturur
                Console.Write("\\"); // sağ kenar yazar
            }
            else
            {
                boslukYazdir(Ucgensatiruzunlugu - i); // boşluk oluşturur
                Console.Write("/"); // sol kenar yazar
                if (i > 1)
                {
                    boslukYazdir(2 * (i - 1)); // boşluk oluşturur
                }
                Console.Write("\\"); // sağ kenar yazar
            }
            Console.Write("\n");
        }
    }
    public void tabanYazdir(int adet)
    {
        for (int i = 0; i < adet; i++)
        {
            Console.Write("_");
        }
    }
    public void boslukYazdir(int adet)
    {
        for (int i = 0; i < adet; i++)
        {
            Console.Write(" ");
        }
    }


}