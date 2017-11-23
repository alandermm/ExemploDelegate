using System;

namespace ExemploDelegate
{
    class Program
    {
        delegate void Cortador(string queijo);

        static void Main(string[] args)
        {
            Cortador vera = new Cortador(Data);
            vera("Olá, eu sou um delegate");
            Cortador filha = new Cortador(DataCompleta);
            
            //Data("Olá ");
            //Console.WriteLine(DataCompleta("Alander"));
        }

        static void Data(string texto){
            Console.WriteLine(texto + " Hoje é " + DateTime.Now.ToShortDateString());
        }

        static string DataCompleta(string nome){
            return "Olá " + nome + " Hoje é " + DateTime.Now.ToLongDateString();
        }
    }
}