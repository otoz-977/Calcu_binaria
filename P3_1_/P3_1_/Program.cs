using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_1_.animal;

namespace P3_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog huesos = new Dog();

            huesos.Talk();

            Cat simba = new Cat();
            simba.Talk();

            simba.meow();

        }
    }
}
