using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    partial class Pessoa
    {

        public void Apresentar()
        {
            Console.WriteLine("Ola eu sou " + nome);

        }

        public static int CalculaIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}
