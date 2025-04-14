using NetBarcode;
while (true)
{
    try
    {
        System.Console.WriteLine("Barkod oluşturma programına hoşgeldiniz. Varsayılan olarak CODE 128 standartında barkodlar üretilecektir.\n-----------------------------------------------------\n Lütfen barkod değerini giriniz:");
        string deger = Console.ReadLine();
        if (deger != null)
        {
            Console.WriteLine("Barkod dosyasının ismini girin:");
            string dosyaismi = Console.ReadLine();
            var barcode = new Barcode(deger, true); // Barcode sınıfından barcode nesenesi oluşturuldu
            string dosyayolu = String.Format("C:\\Users\\fathd\\Desktop\\{0}.png", dosyaismi);
            barcode.SaveImageFile(dosyayolu, ImageFormat.Png); // Method ile masaüstüne kaydedildi
            Console.WriteLine(dosyaismi + ".png" + " barkodu Masaüstü konumuna kaydedildi.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Hata:" + ex.Message);
    }
}
