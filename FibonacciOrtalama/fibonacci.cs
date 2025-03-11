public static class Fibonacci
{
    public static List<int> diziOlustur(int listeuzunluk)
    {
        if (listeuzunluk < 3)
        {
            throw new Exception("Dizi uzunluğu 3 den küçük olamaz. Bir fibonacci dizisi en az 3 terimden oluşur.");
        }
        List<int> sayilistesi = new List<int>(listeuzunluk); // Dizi elemanlarını tutulacak liste
        sayilistesi.Add(1); // başlangıç elemanları ekleniyor
        sayilistesi.Add(2);
        for (int i = 2; i < listeuzunluk; i++) // dizi oluşturuluyor
        {
            sayilistesi.Add(sayilistesi[i - 1] + sayilistesi[i - 2]);
        }
        return sayilistesi;
    }

}