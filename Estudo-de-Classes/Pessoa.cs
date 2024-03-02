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
        get {return nome;}

        set
        {
            if(value.Length > 1)
                nome = value;
            else
                throw new Exception ("O nome precisa ter mais de uma letra!");
        }
       }
       private int idade;
       public int Idade
       {
        get {return Idade;}
        set
        {
            if (value > 0)
                idade = value;
            else
                throw new Exception ("A idade precisa ser maior que zero!");
        }
       }
       public void Apresentar()
       {
        Console.WriteLine($"Oi, me chamo {Nome.ToUpper()} e tenho {Idade} de idade!");
       }
       
    }
}