while (true)
{
    System.Console.WriteLine("Bu program girilen metinden , girilen indekse karşılık gelen değeri metinden siler.");
    System.Console.WriteLine("Lütfen metin giriniz:(Metin,sayi)");
    System.Console.WriteLine("------------------------------------------------------------");
    string metinsayi = Console.ReadLine();
    string[] dizi = metinsayi.Split(",");
    string metin = dizi[0];
    int sayi = Convert.ToInt32(dizi[1]);
    metin = metin.Remove(sayi, 1);
    Console.WriteLine(metin);
}
