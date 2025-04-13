using System;

namespace ATM_Uygulamasi;

public class ATM
{
    public ATM(int _id, string _adres)
    {
        id = _id;
        adres = _adres;
    }
    public int id;
    public string adres;

    public void paraCek(Kullanici kullanici, double miktar)
    {
        kullanici.Bakiye = kullanici.Bakiye - miktar;
        Log paraceklog = new Log(kullanici, kullanici, logTür.ParaCekme, miktar);
        Log.logKaydet(paraceklog);
    }
    public void paraYatir(Kullanici kullanici, double miktar)
    {
        kullanici.Bakiye = kullanici.Bakiye + miktar;
        Log parayatirlog = new Log(kullanici, kullanici, logTür.ParaYatirma, miktar);
        Log.logKaydet(parayatirlog);

    }
    public void paraGonder(Kullanici kullanici, Kullanici gonderilen, double miktar)
    {
        kullanici.Bakiye = kullanici.Bakiye - miktar;
        gonderilen.Bakiye = gonderilen.Bakiye + miktar;
        Log paragonderlog = new Log(kullanici, gonderilen, logTür.ParaGönderme, miktar);
        Log.logKaydet(paragonderlog);
    }

}
