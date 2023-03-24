using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercício 1 ------> OK!

            // int n1 = int.Parse(Console.ReadLine());
            // int n2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("O resultado foi: " + (n1 + n2));

            // --------------------------------------------------------------------------------------------------

            // Exercício 2 ------> OK!

            // double pi = 3.14159;

            // double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // double A = pi * (raio * raio);

            // Console.WriteLine(A.ToString("F4", CultureInfo.InvariantCulture));

            // --------------------------------------------------------------------------------------------------

            // Exercício 3 ------> OK!

            // string[] valores = Console.ReadLine().Split(' ');

            // double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            // double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            // double C = double.Parse(valores[2], CultureInfo.InvariantCulture);
            // double D = double.Parse(valores[3], CultureInfo.InvariantCulture);

            // double dif = (A * B) - (C * D);

            // Console.WriteLine(dif.ToString("F2", CultureInfo.InvariantCulture));

            // --------------------------------------------------------------------------------------------------

            // Exercício 4 ------> OK!

            // int numeroFuncionario = int.Parse(Console.ReadLine());
            // int horas = int.Parse(Console.ReadLine());
            // double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // double salario = horas * valorHora;

            // Console.WriteLine("Numero do Funcionário = " + numeroFuncionario);
            // Console.WriteLine("Salário = " + salario.ToString("F2"));

            // --------------------------------------------------------------------------------------------------

            // Exercício 5 ------> OK!

            // int codigoPeca = int.Parse(Console.ReadLine());
            // int unidades = int.Parse(Console.ReadLine());
            // double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // double total = unidades * valor;

            // Console.WriteLine("Total a pagar = R$" + total.ToString("F2") + "Pela peça cujo código é: " + codigoPeca);

            // --------------------------------------------------------------------------------------------------
        }
    }
}