using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forma a  = new Forma();
            Forma b = new Triangulo();
            Forma c = new Circulo();
            Forma d = new Retangulo();

            a.Desenhar();
            Console.WriteLine("Forma");
            b.Desenhar();
            Console.WriteLine("Triangulo");
            c.Desenhar();
            Console.WriteLine("Circulo");
            d.Desenhar();
            Console.WriteLine("Retangulo");

            Console.ReadKey();
        }
    }
}
