using System;
using AulaDebora2.Entities;

namespace AulaDebora2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente = new Paciente();
            Console.Write("Entre seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Entre sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Número de dependentes: ");
            int numeroDeDependentes = int.Parse(Console.ReadLine());
            Console.Write("Entre seu endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Entre seu CEP: ");
            string cep = Console.ReadLine();
            Console.Write("Entre com seu estado: ");
            string estado = Console.ReadLine();
            Console.Write("Entre seu tempo de empresa: ");
            int tempoDeEmpresa = int.Parse(Console.ReadLine());
            Console.Write("Entre seu Salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Tem doenças pré-existentes?");
            Console.WriteLine("(1) Sim\n(2) Não");
            bool doenca = false;
            int resp = int.Parse(Console.ReadLine());

            if(resp == 1)
            {
                doenca = true;
            }
            else
            {
                doenca = false;
            }

            paciente = new Paciente(nome, idade, numeroDeDependentes, endereco, cep, estado.ToUpper(), tempoDeEmpresa, salario, doenca);

            Console.WriteLine(paciente);

        }
    }
}
