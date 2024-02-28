using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_de_Classes.bin
{
    public class Pessoa
    {
        public string  Nome { get; set; }
        public int Idade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Oi, me chamo {Nome} e tenho {Idade} anos de idade!");
        }
    }
}