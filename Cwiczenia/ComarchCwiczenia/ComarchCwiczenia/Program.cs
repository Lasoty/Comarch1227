﻿using System;

namespace ComarchCwiczenia
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Jak masz na imię: ");
            //string imie = Console.ReadLine();
            //Console.Write("Ile masz lat: ");
            //string wiekText = Console.ReadLine();
            //int wiek1 = Convert.ToInt32(wiekText);
            //int wiek2 = int.Parse(wiekText);

            //Console.WriteLine($"Witaj {imie}! Masz {wiek1} lat.");

            //Class1 zmienna1 = new Class1();
            //int x = zmienna1.publicInt;
            //float y = zmienna1.internalFloat;
            //double z = zmienna1.protectedDouble;
            //decimal zz = zmienna1.privateDecimal;

            Console.WriteLine("KALKULATOR 1.0-alfa");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");

            Console.Write("Podaj pozycje menu: ");
            if (int.TryParse(Console.ReadLine(), out int choise))
            {
                Console.Write("Podaj X: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Podaj Y: ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (choise == 1)
                {
                    int result = Calculator.Calculate(x, y, "+");
                    Console.WriteLine($"Wynik {x} + {y} = {result}.");
                }
            }
            else
            {
                Console.WriteLine("Błędny wybór.");
            }


            Console.ReadLine();
        }
    }
}