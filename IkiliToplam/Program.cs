while (true)
{
    System.Console.WriteLine("***********************************************************");
    System.Console.WriteLine("Sayıları girerken virgül ile ayıarak giriniz. Örneğin: 12,32,45,50 şeklinde.");
    System.Console.WriteLine("Çift adette sayı girilmelidir!");
    System.Console.WriteLine("Lütfen sayıları girin:");
    System.Console.WriteLine("***********************************************************");
    string sayilar = Console.ReadLine();
    string[] sayidizisi = sayilar.Split(",");
    if (sayidizisi.Length % 2 != 0) // Çift adette sayı girilmiş mi kontrol
    {
        System.Console.WriteLine("Lütfen çift adette sayı giriniz!");
        continue;
    }
    foreach (var item in sayidizisi) // Sayısal değer girilmiş mi kontrol
    {
        if (!Int32.TryParse(item, out int ditem))
        {
            System.Console.WriteLine("Girdiğiniz değerler sayısal değil!");
            continue;
        }
    }
    for (int i = 0; i < sayidizisi.Length; i = i + 2) // İkili toplamları hesaplama
    {
        int sayi1 = Convert.ToInt32(sayidizisi[i]);
        int sayi2 = Convert.ToInt32(sayidizisi[i + 1]);
        if (sayi1 == sayi2)
        {
            Console.WriteLine(Math.Pow(sayi1 + sayi2, 2));
        }
        else
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }

}