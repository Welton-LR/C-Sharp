using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_de_Classes.bin
{
    public class Pessoa
    {
       private string nome;
       public string Nome
       {
        get 
        {
            return nome;
        }

        set
        {
            if(value.Length > 1)
                nome = value;
            else
                throw new Exception ("O nome precisa ter mais de uma letra!");
        }
       }
       public int Idade { get; set; }
       public void Apresentar()
       {
        Console.WriteLine($"Oi, me chamo {Nome} e tenho {Idade} de idade!");
       }
       
    }
}