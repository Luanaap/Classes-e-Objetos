﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    sealed internal class Carro : Veiculo
    {
        public int VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("O carro ligou o motos");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o carro!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou o carro!");
        }
    }
}
