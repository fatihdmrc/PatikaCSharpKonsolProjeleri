using OylamaUygulaması;
bool girisyapilmismi = false;
Kullanici kullanici = new Kullanici("-1111", "-1111");
// Anket 1 oluşturuluyor
Anket anket1 = new Anket(1, "En çok kullandığınız programlama dili hangisi?", 1);
string[] anket1cevaplar = { "C#", "Java", "GO", "Rust", "C++" };
anket1.secenekEkle(anket1cevaplar);
// Anket 2 oluşturuluyor
Anket anket2 = new Anket(2, "Covid 19 virüsüne yakalandınız mı?", 2);
string[] anket2cevaplar = { "Evet", "Hayır" };
anket2.secenekEkle(anket2cevaplar);
// Anket 3 oluşturuluyor
Anket anket3 = new Anket(3, "En sevdiğiniz kolpaçino filmi hangisi?", 3);
string[] anket3cevaplar = { "Kolpaçino 1", "Kolpaçino 2 Bomba", "Kolpaçino 3. Devre", "Kolpaçino 4 lük" };
anket3.secenekEkle(anket3cevaplar);
while (true)
{
    try
    {
        System.Console.WriteLine("*****************************************");
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz\n(1)Anketleri Göster\n(2)Anket oyla\n(3)Üye Ol\n(4)Giriş Yap\n(5)Anket sonuçlarını göster\n(6)Çıkış Yap\n*****************************************");
        string islemno = Console.ReadLine();
        if (Int32.TryParse(islemno, out int dislemno))
        {
            switch (dislemno) // işlem seçimi
            {
                case 1:
                    foreach (Anket item in Anket.anketler) // anketleri göster
                    {
                        item.anketGoster();
                    }
                    break;
                case 2: // Anket oylama
                    if (girisyapilmismi)
                    {
                        System.Console.WriteLine("Hangi anketi oylamak istiyorsunuz? Anket numarasını girin:");
                        string anketno = Console.ReadLine();
                        bool aynikullanici = false;
                        if (Int32.TryParse(anketno, out int danketno))
                        {
                            foreach (var item in Anket.anketler)
                            {
                                if (item.anketno == danketno)
                                {
                                    foreach (var x in item.oylayankullanicilar)
                                    {
                                        if (x.KullaniciAdi == kullanici.KullaniciAdi)
                                        {
                                            aynikullanici = true;
                                        }
                                    }
                                    if (!aynikullanici)
                                    {
                                        System.Console.WriteLine("Hangi seçeneği oylamak istiyorsun?");
                                        string secenekno = Console.ReadLine();
                                        if (Int32.TryParse(secenekno, out int dsecenekno))
                                        {
                                            item.anketOyla(dsecenekno, kullanici);
                                            Console.WriteLine("Anket oylaması yapıldı.");
                                        }
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Aynı kullanıcı bir anketi birden fazla oylama işlemi yapamaz!");
                                    }

                                }
                            }
                        }
                        else
                        {
                            throw new Exception("Anket numarası hatalı girildi!");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Lütfen üye olun veya kullanıcı girişi yapın! Sadece kullanıcılar anketlere oy verebilir.");
                    }
                    break;
                case 3: // Üye ol
                    if (girisyapilmismi)
                    {
                        System.Console.WriteLine("Zaten kullanıcı giriş yapılmış. Eğer yeni kullanıcı oluşturmak istiyorsanız öncelikle çıkış yapın.");
                    }
                    else
                    {
                        Kullanici yenikullanici = Kullanici.uyeOl();
                    }

                    break;
                case 4: // Giriş yapma
                    {
                        if (girisyapilmismi)
                        {
                            System.Console.WriteLine("Zaten giriş yapılmış...");
                        }
                        else
                        {
                            bool girisdurum = Kullanici.girisYap(out Kullanici gkullanici);
                            if (girisdurum)
                            {
                                System.Console.WriteLine("Giriş yapıldı.");
                                girisyapilmismi = true;
                                kullanici = gkullanici;
                            }
                        }
                    }
                    break;
                case 5:
                    foreach (var item in Anket.anketler) // anket sonuçlarını göster
                    {
                        item.anketSonuclariGoster();
                    }
                    break;
                case 6:
                    if (girisyapilmismi)
                    {
                        girisyapilmismi = false;
                        System.Console.WriteLine("Kullanıcı hesabından çıkış yapıldı!");
                    }
                    else
                    {
                        System.Console.WriteLine("Kullanıcı girişi yapılmadan çıkış işlemi yapılamaz!");
                    }

                    break;
            }
        }
        else
        {
            throw new Exception("İşlem numarası hatalı girildi");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Hata:" + ex.Message);
    }

}





