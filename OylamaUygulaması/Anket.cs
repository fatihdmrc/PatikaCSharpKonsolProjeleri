using System;

namespace OylamaUygulaması;

public class Anket
{
    public Anket(int kategorino, string soru, int anketno)
    {
        kategori = (Kategoriler)kategorino;
        this.soru = soru;
        this.anketno = anketno;
        anketler.Add(this);
    }
    public List<Kullanici> oylayankullanicilar = new List<Kullanici>();
    public int anketno;
    public Kategoriler kategori;
    public string soru;
    public Dictionary<int, string> secenekler = new Dictionary<int, string>();
    public List<int> isaretleme = new List<int>();
    public static List<Anket> anketler = new List<Anket>(); // tüm anketlerin tutulduğu liste
    public void anketOyla(int secenekno, Kullanici kullanici)
    {
        foreach (var item in secenekler)
        {
            if (secenekno == item.Key)
            {
                isaretleme[secenekno - 1]++;
                oylayankullanicilar.Add(kullanici);
            }
        }
    }
    public void anketGoster()
    {
        System.Console.WriteLine("Anket no:" + anketno);
        Console.WriteLine("Kategori:{0} \nSoru:{1}", kategori, soru);
        foreach (var item in secenekler)
        {
            Console.WriteLine("{0}){1}", item.Key, item.Value);
        }
        System.Console.WriteLine("*****************************************");

    }
    public void anketSonuclariGoster()
    {
        System.Console.WriteLine(anketno + " numaralı,\n" + soru + "\nanketinin cevaplarına oy verme sayıları:");
        for (int i = 0; i < isaretleme.Count; i++)
        {
            Console.WriteLine((i + 1) + ". seçenek: " + soru + "-->oy verme sayısı:" + isaretleme[i]);
        }
        System.Console.WriteLine("*****************************************");
    }
    public void secenekEkle(string[] ekleneceksecenekler)
    {
        for (int i = 0; i < ekleneceksecenekler.Length; i++)
        {
            secenekler.Add(i + 1, ekleneceksecenekler[i]);
            isaretleme.Add(0);
        }
    }

}
public enum Kategoriler
{
    Teknoloji = 1,
    Sağlık = 2,
    Film = 3
}

