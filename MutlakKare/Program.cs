while (true)
{
    Console.WriteLine("Lütfen sayıları virgül ile ayırarak giriniz:");
    string sayilar = Console.ReadLine();
    string[] sayilardizi = sayilar.Split(",");
    int farktoplam = 0;
    int farkkaretoplam = 0;
    for (int i = 0; i < sayilardizi.Length; i++)
    {
        int sayi = Convert.ToInt32(sayilardizi[i]);
        if (sayi > 67)
        {
            farkkaretoplam = farkkaretoplam + (sayi - 67) * (sayi - 67);
        }
        else
        {
            farktoplam = farktoplam + (67 - sayi);
        }
    }
    Console.WriteLine("67 den küçüklerin farklarının toplamı :" + farktoplam + "\n67 den büyüklerin farklarının karelerinin toplamı:" + farkkaretoplam);
}
