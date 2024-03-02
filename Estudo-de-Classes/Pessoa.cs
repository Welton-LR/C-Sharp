using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
        get {return idade;}
        set
        {
            if (value > 0)
                idade = value;
            else
                throw new Exception ("A idade precisa ser maior que zero!");
        }
       }

       private string email;
       public string Email
       {
        get {return email;}
        set
        {
            if (IsValidEmail(value)) // Se o value for verdadeiro...
                email = value;
            else
                throw new Exception("Email inválido!");
        }
       }
        //Este é um método booleano privado. Ele recebe uma string como argumento e retorna um booleano.
       private bool IsValidEmail(string email)
       {
            // Expressão regular para validar o padrão de um email
        string padrao = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch( email , padrao); // Verifica se o email corresponde ao padrão da expressão regular
       }
       public void Apresentar()
       {
            Console.WriteLine($"Oi, me chamo {Nome.ToUpper()} e tenho {Idade} de idade. Email : {Email}");
       }
       
    }
}