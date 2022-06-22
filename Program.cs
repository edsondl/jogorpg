// See https://aka.ms/new-console-template for more information

using System;
//using (namespace JogoRpg.src.entities);

namespace dotnet_JgoRpg
{

    class Program
    {
        static void Main(String[] args)    
        {

            Vaqueiro vaqueiro = new Hero("Jerimum", 23, "Vaqueiro");
            Wizard feiticeiraBranca = new Wizard("Urucum", 200, "Feiticeira Branca");
            
            Console.WriteLine(vaqueiro.Attack(10));
            Console.WriteLine(feiticeiraBranca.Attack(1));
            Console.WriteLine(feiticeiraBranca.Attack(200));
        }
    }
}
