while (true)
{
    System.Console.WriteLine("Çizilecek dairenin yarıçapını giriniz:");
    string yaricap = Console.ReadLine();
    if (Int32.TryParse(yaricap, out int dyaricap))
    {
        for (int y = -dyaricap; y <= dyaricap; y++)
        {
            for (int x = -dyaricap; x <= dyaricap; x++)
            {
                // Dairenin denklemi: x^2 + y^2 = r^2
                if (x * x + y * y <= dyaricap * dyaricap)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}