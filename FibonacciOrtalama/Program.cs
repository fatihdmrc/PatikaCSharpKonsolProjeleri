while (true)
{
    try
    {
        System.Console.WriteLine("***** Fibonacci dizisi ortalama hesaplama ****\n***** Lütfen oluşturulacak fibonacci dizisinin uzunluğunu girin ****");
        string diziuzunluk = Console.ReadLine();
        if (Int32.TryParse(diziuzunluk, out int ddiziuzunluk)) // Sayısal bir ifade girildiyse
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi = Fibonacci.diziOlustur(ddiziuzunluk); // dizi oluşturuldu
            System.Console.WriteLine("***** Oluşturulan dizi ekranda yazdırılıyor *****");
            foreach (var item in sayiListesi) // Dizi ekranda yazdırılıyor
            {
                Console.Write(item + "  ");
            }
            System.Console.WriteLine("\n*************************************");
            Console.WriteLine("Dizinin ortalaması:" + Ortalama.ListeOrtalamaHesapla(sayiListesi).ToString("F2"));
        }
        else // Sayısal bir ifade girilmediyse
        {
            throw new Exception("Dizi uzunluğu sayısal bir değer değil!");
        }
    }
    catch (Exception ex)
    {
        System.Console.WriteLine("Hata:" + ex.Message);
    }

}