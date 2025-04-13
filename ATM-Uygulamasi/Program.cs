using ATM_Uygulamasi;
Kullanici kullanici1 = new Kullanici(1, "Fatih", "Demirci", "1234123412341234", "5683", 100); Kullanici kullanici2 = new Kullanici(2, "Fatma", "Demirci", "4567456745674567", "0609", 150);
try
{
    while (true)
    {
        Uygulama.girisYap();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


