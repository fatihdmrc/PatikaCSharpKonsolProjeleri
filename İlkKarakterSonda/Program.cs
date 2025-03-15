while (true)
{
    Console.WriteLine("Girilen kelimenin ilk harfini en sona getirir\n*************************************************\n Lütfen kelime girin:");
    string metin = Console.ReadLine();
    Console.WriteLine(degistir(metin));
}
static string degistir(string metin)
{
    char ilkkarakter = metin[0];
    string kalan = metin.Substring(1);
    kalan += ilkkarakter;
    return kalan;
}