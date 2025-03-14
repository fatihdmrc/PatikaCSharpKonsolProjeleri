while (true)
{
    System.Console.Write("Lütfen oluşturmak istediğiniz üçgenin satır uzunluğunu giriniz:");
    string satiruzunluk = Console.ReadLine();
    if (Int32.TryParse(satiruzunluk, out int dsatiruzunluk))
    {
        try
        {
            Ucgen yeniucgen = new Ucgen(dsatiruzunluk);
            yeniucgen.ucgenOlustur();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    else
    {
        System.Console.WriteLine("Lütfen sayısal bir değer girin!");
    }
}