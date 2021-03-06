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
            Console.WriteLine("7. Tworzenie obiektu");

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
                    result = Calculator.Calculate(operand: "+", y: y, x: x);
                    Console.WriteLine($"Wynik {x} + {y} = {result}.");
                }

                if (choise == 2)
                {
                    int result = Calculator.Subtract(x, y);
                    Console.WriteLine($"Wynik {x} - {y} = {result}.");
                }

                if (choise == 3)
                {
                    int result = Calculator.Multiply(x, y);
                    Console.WriteLine($"Wynik {x} * {y} = {result}.");
                }

                if (choise == 4)
                {
                    //if (y == 0)
                    //{
                    //    Console.WriteLine("Pamiętaj cholero! Nie dziel przez 0!");
                    //    return;
                    //}

                    float result = Calculator.Divide(x, y);
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



                    try
                    {
                        Calculator.ShowArray(tab);
                        //Calculator.ShowArray(null);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wystąpił nieprzewidziany wyjątek");
                        Console.ResetColor();
                        throw;
                    }
                }

                if (choise == 6)
                {
                    int[] tab = new int[20];
                    Random rand = new Random((int)DateTime.Now.Ticks);

                    for (int i = 0; i < tab.Length; i++)
                    {
                        tab[i] = rand.Next(x, y);
                    }
                    Calculator.ShowArray(tab);

                    int[] sortettab = Calculator.SortArray(tab);
                    Calculator.ShowArray(sortettab);
                }

                if (choise == 7)
                {
                    Car car = new Car();
                    car.SetMaker("Audi");
                    car.Model = "A6";

                    Console.WriteLine($"Marka: {car.Maker}, Model: {car.Model}.");
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
