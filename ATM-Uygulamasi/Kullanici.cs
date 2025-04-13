namespace ATM_Uygulamasi;

public class Kullanici
{
    public Kullanici(int _id, string _isim, string _soyisim, string _kartno, string _sifre, double _bakiye)
    {
        Id = _id;
        Isım = _isim;
        Soyisim = _soyisim;
        Kartno = _kartno;
        Sifre = _sifre;
        Bakiye = _bakiye;
        kullanicilistesi.Add(this);
    }
    public static List<Kullanici> kullanicilistesi = new List<Kullanici>();
    public int id;
    public string isim;
    public string soyisim;
    private string kartno;
    private string sifre;
    private double bakiye;
    public int Id
    {
        get => id;
        set
        {
            if (!Int32.TryParse(value.ToString(), out int did))
            {
                throw new Exception("Kullanıcı ID si sayısal bir değer olmalı!");
            }
            id = did;
        }
    }
    public string Isım
    {
        get => isim;
        set
        {
            if (value.Length > 30 || value.Length < 2)
            {
                throw new Exception("Kullanici ismi 30 karakterden fazla, 2 karakterden az olamaz.");
            }
            else if (!boslukKontrol(value))
            {
                throw new Exception("İsimde boşluk bulunmamalı!");
            }
            else if (!harfKontrol(value))
            {
                throw new Exception("İsim sadece harflerden oluşabilir!");
            }
            isim = value;

        }
    }
    public string Soyisim
    {
        get => soyisim;
        set
        {
            if (value.Length > 30 || value.Length < 2)
            {
                throw new Exception("Kullanici soyismi 30 karakterden fazla, 2 karakterden az olamaz!");
            }
            else if (!boslukKontrol(value))
            {
                throw new Exception("Soyisimde boşluk bulunmamalı!");
            }
            else if (!harfKontrol(value))
            {
                throw new Exception("Soyisim sadece harflerden oluşabilir!");
            }
            soyisim = value;
        }
    }
    public string Kartno
    {
        get => kartno;
        set
        {
            if (value.Length != 16)
            {
                throw new Exception("Kart numarası 16 haneli olmalıdır!");
            }
            else if (!sayiKontrol(value))
            {
                throw new Exception("Kart numarası sayısal değerlerden oluşmalıdır!");
            }
            kartno = value;
        }
    }
    public string Sifre
    {
        get => sifre;
        set
        {

            if (value.Length != 4)
            {
                throw new Exception("Kart şifresi 4 haneden oluşmalıdır!");
            }
            else if (!boslukKontrol(value))
            {
                throw new Exception("Kart şifresinde boşluk bulunamaz!");
            }
            else if (!sayiKontrol(value))
            {
                throw new Exception("Kart şifresi rakamlardan oluşmalıdır!");
            }
            this.sifre = value;
        }
    }
    public double Bakiye
    {
        get => bakiye;
        set
        {
            string _bakiye = value.ToString();
            if (!Double.TryParse(_bakiye, out double dbakiye))
            {
                throw new Exception("Bakiye değeri sayısal olmalıdır!");
            }
            else if (dbakiye < 0)
            {
                throw new Exception("Bakiye 0 dan küçük olamaz!");
            }
            bakiye = dbakiye;
        }
    }
    public static bool harfKontrol(string metin) // Girilen metin harf mi bunu kontrol eder
    {
        bool durum = true;
        for (int i = 0; i < metin.Length; i++)
        {
            if (!char.IsLetter(metin[i]))
            {
                durum = false;
                break;
            }
        }
        return durum;
    }
    public static bool sayiKontrol(string metin) // Girilen metin sayı mı kontrol eder
    {
        bool durum = true;
        for (int i = 0; i < metin.Length; i++)
        {
            if (!char.IsNumber(metin[i]))
            {
                durum = false;
                break;
            }
        }
        return durum;
    }
    public static bool boslukKontrol(string metin) // Metinde boşluk var mı kontrol eder
    {
        bool durum = true;
        for (int i = 0; i < metin.Length; i++)
        {
            if (char.IsWhiteSpace(metin[i]))
            {
                durum = false;
                break;
            }
        }
        return durum;
    }
    public static Kullanici kullaniciDogrulama(string kartno, string sifre, out bool durum)
    {
        if (kartno.Length != 16 || sifre.Length != 4)
        {
            throw new Exception("Kart numarası veya şifre yanlış girildi! Kart numarası 16 haneli olmalı. Şifre ise 4 haneli olmalıdır!");
        }
        else if (!sayiKontrol(kartno) || !sayiKontrol(sifre))
        {
            throw new Exception("Kart numarası veya şifre rakam olmalıdır!");
        }
        else
        {
            durum = false;
            foreach (var item in kullanicilistesi)
            {
                if (item.Kartno == kartno)
                {
                    if (item.Sifre == sifre)
                    {
                        durum = true;
                        return item;
                    }
                    else
                    {
                        Log hataligiris = new Log(item, item, logTür.HatalıGiriş, 0);
                        Log.logKaydet(hataligiris);
                        durum = false;
                    }
                }
            }
            return null;
        }

    }
    public static Kullanici kullaniciAra(string kartno)
    {
        foreach (var item in kullanicilistesi)
        {
            if (item.kartno == kartno)
            {
                return item;
            }
        }
        return null;
    }
}
