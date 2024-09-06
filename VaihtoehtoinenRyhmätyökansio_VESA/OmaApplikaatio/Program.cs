using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Heipa Miikka! Mä olen koittanut keksiä jotai mutta pää on ihan tyhjä!");
        Thread.Sleep(1000);
        Console.WriteLine("----");
        Thread.Sleep(1000);
        Console.WriteLine("Moro Vesa! Ei se mitään. Kokeillaan tehdä kuitenkin jokin toiminnallisuus tänne.");
        Thread.Sleep(1000);
        Console.WriteLine("----");
        Thread.Sleep(1000);

        //Oikea toiminnallisuus alkaa tästä:

        Console.WriteLine("Valitse toiminnallisuus");
        Console.WriteLine("1: Heitä noppaa. 2: Generoi satunnainen nimi");


        string vastaus = Console.ReadLine();
        int vastaus_int = 0;
        int.TryParse(vastaus, out vastaus_int);

        if (vastaus_int == 1)
        {
            Console.WriteLine("Valitsit nopan heiton");
            //TODO: Nopan heitto logiikka
        }
        else if (vastaus_int == 2)
        {
            Console.WriteLine("Valitsit nimen");
            //TODO: Nimi logiikka
        }
        else
        {
            Console.WriteLine("En ymmärtänyt vastaustasi");
        }



        Thread.Sleep(1000);
        Console.WriteLine("Ohjelma on päättynyt");


    }
}