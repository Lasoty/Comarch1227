using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekarz.Model
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

        public abstract void Test();

        public virtual void Test2()
        {
            Console.WriteLine("");
        }
    }
}
