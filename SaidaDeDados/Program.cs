using System;
using System.Globalization;

namespace SaidaDeDados;

class Program
{
    static void Main(string[] args)
    {
        char genero = 'F';
        int idade = 32;
        double saldo = 10.35784;
        string nome = "Maria";

        Console.WriteLine($"{nome} tem {idade} e tem saldo igual a {saldo:F2} reais.");


        //Console.Write("Bom dia");
        //Console.WriteLine("Boa Tarde");
        //Console.WriteLine("----------------------------------");
        //Console.WriteLine(genero);
        //Console.WriteLine(idade);
        //Console.WriteLine(nome);
        //Console.WriteLine(saldo);
        //Console.WriteLine(saldo.ToString("F2"));
        //Console.WriteLine(saldo.ToString("F4"));
        //Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture)); //Para usar o ponto para separar as casas. Obs: Utilizar o System.Globalization no usyn
    }
}
