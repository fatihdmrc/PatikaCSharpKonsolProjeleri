while (true)
{
    try
    {
        Console.WriteLine("Lütfen şekil seçin 1(Daire) 2(Dikdörtgen) 3(Kare) 4(Ucgen)");
        string? secim = Console.ReadLine();
        if (Int32.TryParse(secim, out int dsecim))
        {
            switch (dsecim)
            {
                case 1:
                    System.Console.WriteLine("Lütfen dairenin yarıçapını girin:");
                    string yaricap = Console.ReadLine();
                    if (Double.TryParse(yaricap, out double dyaricap))
                    {
                        Daire yenidaire = new Daire(dyaricap);
                        System.Console.WriteLine("Daire oluşturuldu. Daire için yapılacak işlemi seçin. (1) Alan Hesapla (2) Çevre Hesapla");
                        string daireislemsecim = Console.ReadLine();
                        if (Int32.TryParse(daireislemsecim, out int ddaireislemsecim))
                        {
                            if (ddaireislemsecim == 1)
                            {
                                System.Console.WriteLine("Dairenin alanı:" + yenidaire.alanHesapla());
                            }
                            else if (ddaireislemsecim == 2)
                            {
                                System.Console.WriteLine("Dairenin çevresi:" + yenidaire.cevreHesapla());
                            }
                        }
                        else
                        {
                            throw new Exception("Daire için yanlış işlem numarası girildi!");
                        }

                    }
                    else
                    {
                        throw new Exception("Daire yarıçapı hatalı girildi!");
                    }
                    break;
                case 2:
                    System.Console.WriteLine("Lütfen Dikdörgenin kısa kenarını girin:");
                    string kisakenar = Console.ReadLine();
                    System.Console.WriteLine("Lütfen Dikdörgenin uzun kenarını girin:");
                    string uzunkenar = Console.ReadLine();
                    if (Double.TryParse(kisakenar, out double dkisakenar) && Double.TryParse(uzunkenar, out double duzunkenar))
                    {
                        Dikdortgen yenidikdortgen = new Dikdortgen(dkisakenar, duzunkenar);
                        System.Console.WriteLine("Dikdörgen oluşturuldu. Dikdörtgen için yapılacak işlemi seçin. (1) Alan Hesapla (2) Çevre Hesapla");
                        string dikdörtgenislemsecim = Console.ReadLine();
                        if (Int32.TryParse(dikdörtgenislemsecim, out int ddikdörtgenislemsecim))
                        {
                            if (ddikdörtgenislemsecim == 1)
                            {
                                System.Console.WriteLine("Dikdörtgenin alanı:" + yenidikdortgen.alanHesapla());
                            }
                            else if (ddikdörtgenislemsecim == 2)
                            {
                                System.Console.WriteLine("Dikdörtgenin çevresi:" + yenidikdortgen.cevreHesapla());
                            }
                        }
                        else
                        {
                            throw new Exception("Dikdörgen için yanlış işlem numarası girildi!");
                        }

                    }
                    else
                    {
                        throw new Exception("Dikdörtgenin kenarlarından biri hatalı girildi!");
                    }
                    break;
                case 3:
                    System.Console.WriteLine("Lütfen Karenin kenarını girin:");
                    string karekkenar = Console.ReadLine();
                    if (Double.TryParse(karekkenar, out double dkarekenar))
                    {
                        Kare yenikare = new Kare(dkarekenar);
                        System.Console.WriteLine("Kare oluşturuldu. Kare için yapılacak işlemi seçin. (1) Alan Hesapla (2) Çevre Hesapla");
                        string kareislemsecim = Console.ReadLine();
                        if (Int32.TryParse(kareislemsecim, out int dkareislemsecim))
                        {
                            if (dkareislemsecim == 1)
                            {
                                System.Console.WriteLine("Karenin alanı:" + yenikare.alanHesapla());
                            }
                            else if (dkareislemsecim == 2)
                            {
                                System.Console.WriteLine("Karenin çevresi:" + yenikare.cevreHesapla());
                            }
                        }
                        else
                        {
                            throw new Exception("Kare için yanlış işlem numarası girildi!");
                        }

                    }
                    else
                    {
                        throw new Exception("Karenin kenarı hatalı girildi!");
                    }
                    break;
                case 4:
                    System.Console.WriteLine("Lütfen Üçgenin 1. kenarını girin:");
                    string ucgenkenar1 = Console.ReadLine();
                    System.Console.WriteLine("Lütfen Üçgenin 2. kenarını girin:");
                    string ucgenkenar2 = Console.ReadLine();
                    System.Console.WriteLine("Lütfen Üçgenin 3. kenarını girin:");
                    string ucgenkenar3 = Console.ReadLine();
                    System.Console.WriteLine("Lütfen Üçgenin Taban kenarını girin:");
                    string ucgentaban = Console.ReadLine();
                    System.Console.WriteLine("Lütfen Üçgenin yükseklik değerini girin:");
                    string ucgenyukseklik = Console.ReadLine();
                    if (Double.TryParse(ucgenkenar1, out double ducgenkenar1) && Double.TryParse(ucgenkenar2, out double ducgenkenar2) && Double.TryParse(ucgenkenar3, out double ducgenkenar3) && Double.TryParse(ucgenyukseklik, out double ducgenyukseklik) && Double.TryParse(ucgentaban, out double ducgentaban))
                    {
                        Ucgen yeniucgen = new Ucgen(ducgenkenar1, ducgenkenar2, ducgenkenar3, ducgentaban, ducgenyukseklik);
                        System.Console.WriteLine("Üçgen oluşturuldu. Üçgen için yapılacak işlemi seçin. (1) Alan Hesapla (2) Çevre Hesapla");
                        string ucgenislemsecim = Console.ReadLine();
                        if (Int32.TryParse(ucgenislemsecim, out int ducgenislemsecim))
                        {
                            if (ducgenislemsecim == 1)
                            {
                                System.Console.WriteLine("Üçgenin alanı:" + yeniucgen.alanHesapla());
                            }
                            else if (ducgenislemsecim == 2)
                            {
                                System.Console.WriteLine("Karenin çevresi:" + yeniucgen.cevreHesapla());
                            }
                        }
                        else
                        {
                            throw new Exception("Üçgen için yanlış işlem numarası girildi!");
                        }

                    }
                    else
                    {
                        throw new Exception("Üçgenin kenarı hatalı girildi!");
                    }
                    break;

            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Hata:" + ex.Message);
    }
}