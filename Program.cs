using System;

namespace Aula7Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Mastercard master = new Mastercard();

            master.usuario = "Gustavo";
            master.parcelas = 2;
            Console.WriteLine($"Seja Bem vindo {master.usuario}");
            master.ComprarComDescontoMastercard(25f);  
            
        }
    }
}
