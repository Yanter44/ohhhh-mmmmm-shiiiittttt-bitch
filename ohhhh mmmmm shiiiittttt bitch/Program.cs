using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohhhh_mmmmm_shiiiittttt_bitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            h.go();
            h.Daun();
        }
      
    }

    class Human
    {
       public void go()
        {
            Console.WriteLine("O");
        }
        public void Daun()
        {
            Console.WriteLine("UUUUU");
        }

        public void SuckDick(int howDeep)
        {
            if(howDeep > 15)
            {
                Console.WriteLine("Jopa lopnula");
            }
            Console.WriteLine("MMMM yammy dick");
        }
    }
}
