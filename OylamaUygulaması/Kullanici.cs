using System;
using System.Security.Cryptography.X509Certificates;

namespace OylamaUygulaması;

public class Kullanici
{
    public Kullanici(string kullaniciadi, string sifre)
    {
        KullaniciAdi = kullaniciadi;
        Sifre = sifre;
        kullanicilar.Add(this);
    }
    private string kullaniciadi;
    private string sifre;

    private static List<Kullanici> kullanicilar = new List<Kullanici>();
    public string KullaniciAdi
    {
        get => kullaniciadi;
        set
        {
            if (value.Count() > 10 || value.Count() < 3)
            {
                throw new Exception("Kullanıcı adı 10 karakterden uzun, 3 karakterden kısa olamaz!");
            }
            if (value == "")
            {
                throw new Exception("Kullanıcı adı boş bırakılamaz!");
            }
            kullaniciadi = value;
        }
    }
    public string Sifre
    {
        set
        {
            if (value.Count() > 10 || value.Count() < 3)
            {
                throw new Exception("Kullanıcı şifresi 10 karakterden uzun, 3 karakterden kısa olamaz!");
            }
            if (value == "")
            {
                throw new Exception("Kullanıcı şifresi boş bırakılamaz!");
            }
            sifre = value;
        }
    }
    public static bool girisYap(out Kullanici kullanici)
    {
        System.Console.WriteLine("Lütfen kullanıcı adınızı girin:");
        string kullaniciadi = Console.ReadLine();
        System.Console.WriteLine("Lütfen şifrenizi girin:");
        string sifre = Console.ReadLine();
        bool girisdurum = false;
        foreach (Kullanici item in kullanicilar)
        {
            if (kullaniciadi == item.KullaniciAdi)
            {
                if (item.sifre == sifre)
                {
                    kullanici = item;
                    girisdurum = true;
                    return girisdurum;
                }
            }
        }
        kullanici = new Kullanici("-1", "-1");
        return girisdurum;
    }
    public static Kullanici uyeOl()
    {
        Console.WriteLine("Üye olma işlemi başlatıldı. Lütfen bilgilerinizi girin.");
        Console.WriteLine("Kullanıcı adıınz ne olsun:");
        string kullaniciadi = Console.ReadLine();
        Console.WriteLine("Şifreniz ne olsun:");
        string sifre = Console.ReadLine();
        Kullanici yenikullanici = new Kullanici(kullaniciadi, sifre);
        System.Console.WriteLine("Üye kaydınız başarıyla yapıldı " + yenikullanici.KullaniciAdi);
        return yenikullanici;
    }
}
