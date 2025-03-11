public static class Ortalama
{
    public static double ListeOrtalamaHesapla(List<int> liste)
    {
        if (liste.Count == 0) // listede eleman yoksa, 0 elemanlı ise
        {
            throw new Exception("Sayı dizisinde eleman bulunamadı!");
        }
        double ortalama = Convert.ToDouble(liste.Sum()) / Convert.ToDouble(liste.Count);
        return ortalama;
    }
}