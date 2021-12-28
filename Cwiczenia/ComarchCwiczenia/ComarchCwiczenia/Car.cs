using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchCwiczenia
{
    internal class Car
    {
        public string Color;
        private string maker;

        public Car()
        {

        }

        public Car(string maker, string model)
        {
            Maker = maker;
            Model = model;
        }

        //public string FirstName { get; set; }

        //public string LastName { get; set; }

        //public string FullName
        //{
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //}

        public string Maker
        {
            get
            {
                Console.WriteLine("Odczytano Car.Maker = " + maker);
                return maker;
            }

            private set
            {
                Console.WriteLine("Zapisanie wartości Car.Maker = " + value);
                maker = value;
            }

        }

        public string Model { get; set; }

        public void SetMaker(string name)
        {
            Maker = name;
        }
    }
}
