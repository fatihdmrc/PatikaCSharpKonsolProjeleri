char[] sessizharfler = { 'z', 'y', 'v', 't', 'ş', 's', 'r', 'p', 'n', 'r', 'm', 'l', 'k', 'h', 'j', 'ğ', 'g', 'd', 'ç', 'c', 'b' };
Console.WriteLine("Lütfen bir cümle girin:");
string? metin = Console.ReadLine();
string[] ayrilmismetin = metin.Split();
foreach (string kelime in ayrilmismetin)
{
    if (yanyanaSessizHarf(kelime))
    {
        System.Console.WriteLine(kelime + "-->Yanyana iki adet sessiz harf bulundu.");
    }
}
bool sessizHarfMi(char karakter)
{
    bool durum = false;
    if (char.IsLetter(karakter)) // harf mi
    {
        foreach (char sessizharf in sessizharfler)
        {
            if (karakter == sessizharf)
            {
                durum = true;
                return durum;
            }
        }
    }
    else // harf değilse
    {
        durum = false;
    }
    return durum;
}
bool yanyanaSessizHarf(string metin)
{
    bool durum = false;
    for (int i = 0; i < metin.Length - 1; i++)
    {
        if (sessizHarfMi(metin[i]) && sessizHarfMi(metin[i + 1]))
        {
            durum = true;
            return durum;
        }
    }
    return durum;
}