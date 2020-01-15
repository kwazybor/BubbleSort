using System;

namespace Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile liczb chcesz sortować?");
            int dlugosc = int.Parse(Console.ReadLine());
            int[] liczby = new int[dlugosc];
            Console.WriteLine("Podaj liczby po enterze");
            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = int.Parse(Console.ReadLine());
            }
            int najLiczba = 0;
            sortowanie:
            Console.WriteLine("Jak chcesz sortować?");
            Console.WriteLine("1.Szukaj największej liczby");
            Console.WriteLine("2.Szukaj najmniejszej liczby");
            int wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    najLiczba = 0;
                    for (int i = 0; i < liczby.Length; i++)
                    {
                        if (liczby[i] > najLiczba)
                        {
                            najLiczba = liczby[i];
                        }
                        Console.WriteLine("Największa liczba to: {0}", najLiczba);
                    }
                    break;
                case 2:
                    najLiczba = 99999999;
                    for (int i = 0; i < liczby.Length; i++)
                    {
                        if (liczby[i] < najLiczba)
                        {
                            najLiczba = liczby[i];
                        }
                        Console.WriteLine("Najmniejsza liczba to: {0}", najLiczba);
                    }
                    break;
                default:
                    Console.WriteLine("Błędna opcja");
                    goto sortowanie;
            }
            Console.ReadLine();

        }
    }
}
