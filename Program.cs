using System;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Bem-vindo ao programa de soma simples.");
            
            Console.Write("Por favor, insira seu nome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine($"Prazer em te conhecer, {nome}!");
            
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double soma = numero1 + numero2;

            Console.WriteLine($"A soma de {numero1} e {numero2} é: {soma}");

            Console.WriteLine("Obrigado por usar o programa. Até mais!");
        }
    }
}
