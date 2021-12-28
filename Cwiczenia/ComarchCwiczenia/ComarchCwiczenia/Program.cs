using System;

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
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("5. Licznik");
            Console.WriteLine("6. Sortowanie");

            Console.Write("Podaj pozycje menu: ");
            if (int.TryParse(Console.ReadLine(), out int choise))
            {
                Console.Write("Podaj X: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Podaj Y: ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (choise == 1)
                {
                    int result = Calculator.Add(x, y);
                    Console.WriteLine($"Wynik {x} + {y} = {result}.");
                }

                if (choise == 2)
                {
                    int result = Calculator.Calculate(x, y, "-");
                    Console.WriteLine($"Wynik {x} - {y} = {result}.");
                }

                if (choise == 3)
                {
                    int result = Calculator.Calculate(x, y, "*");
                    Console.WriteLine($"Wynik {x} * {y} = {result}.");
                }

                if (choise == 4)
                {
                    if (y == 0)
                    {
                        Console.WriteLine("Pamiętaj cholero! Nie dziel przez 0!");
                        return;
                    }

                    int result = Calculator.Calculate(x, y, "/");
                    Console.WriteLine($"Wynik {x} / {y} = {result}.");
                }

                if (choise == 5)
                {
                    int lenght = (y - x) + 1;
                    int[] tab = new int[lenght];
                    for (int i = 0; i < lenght; i++)
                    {
                        tab[i] = x + i;
                    }

                    Calculator.ShowArray(tab);
                }

                if (choise == 6)
                {
                    int[] tab = new int[20];
                    Random rand = new Random((int)DateTime.Now.Ticks);

                    for (int i = 0; i < tab.Length ; i++)
                    {
                        tab[i] = rand.Next(x, y);
                    }
                    Calculator.ShowArray(tab);

                    int[] sortettab = Calculator.SortArray(tab);
                    Calculator.ShowArray(sortettab);
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
