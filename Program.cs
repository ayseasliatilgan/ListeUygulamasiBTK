internal class Program
{
    static void Main(string[] args)
    {

        var sehirler = new List<string>()
        {
            "Ankara",
            "İstanbul",
            "Van",
            "Samsun",
            "Ordu",
        };
        //foreach (var s in sehirler) 
        //{ 
        //    Console.WriteLine(s);
        //}

        // Lambda expression : Liste üzerinde dolaşma işlemlerini daha kolay yapabiliriz
        // Hatta foreach döngüsü yerine kullanılabilir

        Console.WriteLine(new string('-',50));

        var iller = sehirler;
        iller.ForEach(i => Console.WriteLine(i));

        sehirler.Add("Sinop");
        Console.WriteLine();
        sehirler.ForEach(s => Console.WriteLine(s));
        Console.WriteLine();
        iller.ForEach(i => Console.WriteLine(i));

        iller.Remove("Ankara");
        Console.WriteLine();
        iller.ForEach(i => Console.WriteLine(i));

        Console.WriteLine();
        sehirler.ForEach(s => Console.WriteLine(s));

        Console.ReadKey();
    }
}