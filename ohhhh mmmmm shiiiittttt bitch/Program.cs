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
            const int r = 1;
            string x, y;
            Console.Write("Enter x: ");
            x = Console.ReadLine();
            Console.Write("Enter y: ");
            y = Console.ReadLine();

            double s = Math.Sqrt(Math.Pow(double.Parse(x), 2) + Math.Pow(double.Parse(y), 2));

            Console.WriteLine($"Prinadleshit: {s == r}");
        }

    }

    class Human
    {

        public bool IsKukold { get; set; } = true;
        public string Name { get; set; }    
        public void Go()
        {
            Console.WriteLine("O");
        }
        public void Daun()
        {
            Console.WriteLine("UUUUU");
        }

        public void SuckDick(int howDeep)
        {
            if (howDeep > 15)
            {
                Console.WriteLine("Jopa lopnula");
            }
            Console.WriteLine("MMMM yammy dick");
        }
     
    }
}
