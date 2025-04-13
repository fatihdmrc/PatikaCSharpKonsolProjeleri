namespace ATM_Uygulamasi;
public static class Uygulama
{
    public static void girisYap()
    {
        Console.WriteLine("ATM ye hoşgeldin. Lütfen kart numaranı ve şifreni yaz.");
        Console.Write("Kart Numarası:");
        string kartno = Console.ReadLine();
        Console.Write("Kart şifresi:");
        string kartsifre = Console.ReadLine();
        Kullanici kullanici = Kullanici.kullaniciDogrulama(kartno, kartsifre, out bool durum);
        if (durum)
        {
            Console.WriteLine("Hoşgeldin " + kullanici.Isım + " " + kullanici.Soyisim);
            Uygulama.islemSec(kullanici);
        }
        else
        {
            Console.WriteLine("Kart numarası veya şifre yanlış girildi!");
            girisYap();

        }
    }
    public static void islemSec(Kullanici kullanici)
    {
        Console.WriteLine("Hesap Bakiyeniz:" + kullanici.Bakiye.ToString("F2"));
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
        Console.WriteLine("(1) Para Çek\n(2) Para Gönder\n(3) Para Yatır\n(4) Çıkış");
        string islemno = Console.ReadLine();
        if (Int32.TryParse(islemno, out int dislemno) && dislemno >= 1 && dislemno <= 4)
        {
            ATM atm = new ATM(1, "Bandırma Merkez");
            islemYap(dislemno, kullanici, atm);
        }
        else
        {
            Console.WriteLine("İşlem numarası yanlış girildi!");
            islemSec(kullanici);
        }
    }
    public static void islemYap(int islemno, Kullanici kullanici, ATM atm)
    {
        switch (islemno)
        {
            case 1: // Para çekimi
                Console.Write("Lütfen para çekilecek miktarı girin:");
                string miktar = Console.ReadLine();
                if (Double.TryParse(miktar, out double dmiktar))
                {
                    if (kullanici.Bakiye >= dmiktar && dmiktar > 0)
                    {
                        atm.paraCek(kullanici, dmiktar);
                        Console.WriteLine(kullanici.Isım + " " + kullanici.Soyisim + " hesabınızdan " + dmiktar.ToString("F2") + " tutarında para çekimi işlemi yapıldı.");
                        islemSec(kullanici);
                    }
                    else if (dmiktar > kullanici.Bakiye)
                    {
                        Console.WriteLine("Hesabınızda yeterli bakiye buluanamadı!");
                        islemSec(kullanici);
                    }
                    else if (dmiktar < 0)
                    {
                        Console.WriteLine("Çekilecek para tutarı negatif olamaz!");
                        islemSec(kullanici);
                    }
                }
                else
                {
                    Console.WriteLine("Para çekiminde girilen tutar yalnızca sayısal olabilir!");
                    islemSec(kullanici);
                }
                break;
            case 2: // Para gönderme
                Console.Write("Para gönderilecek kişinin kart numarasını girin:");
                string gonderilenkartno = Console.ReadLine();
                Kullanici gonderilenkullanici = Kullanici.kullaniciAra(gonderilenkartno);
                if (gonderilenkullanici != null && kullanici.Kartno != gonderilenkartno)
                {
                    Console.Write("Gönderilecek tutarı girin:");
                    string gonderilenmiktar = Console.ReadLine();
                    if (Double.TryParse(gonderilenmiktar, out double dgonderilenmiktar))
                    {
                        if (dgonderilenmiktar <= kullanici.Bakiye && dgonderilenmiktar > 0)
                        {
                            atm.paraGonder(kullanici, gonderilenkullanici, dgonderilenmiktar);
                            Console.WriteLine(gonderilenkullanici.Isım + " " + gonderilenkullanici.Soyisim + " hesabına " + dgonderilenmiktar.ToString("F2") + " TL gönderildi.");
                            islemSec(kullanici);
                        }
                        else if (dgonderilenmiktar > kullanici.Bakiye)
                        {
                            Console.WriteLine("Yeterli bakiye bulunamadı!");
                            islemSec(kullanici);
                        }
                        else if (dgonderilenmiktar < 0)
                        {
                            Console.WriteLine("Gönderilen tutar 0 dan küçük olamaz!");
                            islemSec(kullanici);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Gönderilen para tutarı yanlış girildi! Para tutarı sayısal olmalıdır!");
                        islemSec(kullanici);
                    }
                }
                else
                {
                    Console.WriteLine("Para gönderilecek kişinin kart numarası yanlış girildi!");
                    islemSec(kullanici);
                }

                break;
            case 3: // Para yatırma
                Console.Write("Lütfen yatırılacak tutarı giriniz:");
                string yatirilanmiktar = Console.ReadLine();
                if (Double.TryParse(yatirilanmiktar, out double dyatirilanmiktar))
                {
                    if (dyatirilanmiktar > 0)
                    {
                        atm.paraYatir(kullanici, dyatirilanmiktar);
                        Console.WriteLine(kullanici.Isım + " " + kullanici.Soyisim + " hesabınıza " + dyatirilanmiktar.ToString("F2") + " tutarında para yatırıldı.");
                        islemSec(kullanici);
                    }
                    else
                    {
                        Console.WriteLine("Yatırılan miktar 0 veya 0 dan küçük olamaz!");
                        islemSec(kullanici);
                    }

                }
                else
                {
                    Console.WriteLine("Yatırılan tutar yanlış girildi!");
                    islemSec(kullanici);
                }
                break;
            case 4:
                Console.WriteLine("Çıkış yapıldı!");
                girisYap();
                break;
        }
    }
}

