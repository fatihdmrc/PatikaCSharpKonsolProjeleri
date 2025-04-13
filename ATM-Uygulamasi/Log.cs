using System;

namespace ATM_Uygulamasi;

public class Log
{
    public Log(Kullanici _islemyapan, Kullanici _islemyapilan, logTür _islemtürü, double _islemmiktar)
    {
        islemyapan = _islemyapan;
        islemyapilan = _islemyapilan;
        tür = _islemtürü;
        miktar = _islemmiktar;
        zaman = DateTime.Now;
        loglar.Add(this);
    }
    public static List<Log> loglar = new List<Log>();
    public int id;
    public Kullanici islemyapan;
    public Kullanici islemyapilan;
    public logTür tür;
    public double miktar;
    public DateTime zaman;
    public static void logKaydet(Log kaydedileceklog)
    {
        string filepath = "C:\\Users\\fathd\\Desktop\\ATMLog.txt";
        string logmetin = string.Format("İŞLEM_YAPAN:{0} İŞLEM_YAPILAN:{1} İŞLEM:{2} İŞLEM_MİKTARI:{3} İŞLEM ZAMANI:{4} \n", kaydedileceklog.islemyapan.Isım, kaydedileceklog.islemyapilan.Isım, kaydedileceklog.tür, kaydedileceklog.miktar.ToString("F2"), kaydedileceklog.zaman);
        if (File.Exists(filepath)) // Eğer ATMLog.txt adında bir dosya varsa
        {
            File.AppendAllText(filepath, logmetin);
        }
        else // ATMLog.txt dosyası yoksa
        {
            File.Create(filepath).Close();
            File.AppendAllText(filepath, logmetin);
        }
    }

}
public enum logTür
{
    ParaGönderme = 1,
    ParaCekme,
    ParaYatirma,
    HatalıGiriş
}
