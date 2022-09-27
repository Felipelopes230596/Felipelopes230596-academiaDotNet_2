using System;

namespace Lista_de_exercicios_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1

            //Console.WriteLine("Insira a base e a altura: ");
            //double b = double.Parse(Console.ReadLine());
            //double a = double.Parse(Console.ReadLine());

            //if (a == 0 || b == 0)
            //{
            //    Console.WriteLine("Digite um número diferente de zero.");
            //}
            //else
            //{
            //    double area = (b * a) / 2;
            //    Console.WriteLine("A área é " + area);
            //}

            //Exercício 2

            //Console.WriteLine("Digite um número: ");
            //int n = int.Parse(Console.ReadLine());
            //n = n % 2;
            //if (n == 0)
            //{
            //    Console.WriteLine("O número digitado é par.");
            //}
            //else
            //{
            //    Console.WriteLine("O número digitado é ímpar.");
            //}

            //Exercício 3

            //console.writeline("digite 4 números: ");
            //int a = int.parse(console.readline());
            //int b = int.parse(console.readline());
            //int c = int.parse(console.readline());
            //int d = int.parse(console.readline());

            //int m = (a + b + c + d) / 4;
            //console.writeline("a média é " + m);
            //if (a >= m)
            //{
            //    console.writeline("o número " + a + " é maior que a média.");
            //}
            //if (b >= m)
            //{
            //    console.writeline("o número " + b + " é maior que a média.");
            //}
            //if (c >= m)
            //{
            //    console.writeline("o número " + c + " é maior que a média.");
            //}
            //if (d >= m)
            //{
            //    console.writeline("o número " + d + " é maior que a média.");
            //}

            //Exercício 4

            //Console.WriteLine("Insira a quantidade de horas-aula dadas pelo professor A: ");
            //double pA = double.Parse(Console.ReadLine());
            //Console.WriteLine("Insira a quantidade de horas/aula dadas pelo professor B: ");
            //double pB = double.Parse(Console.ReadLine());
            //Console.WriteLine("Insira o valor da hora/aula: ");
            //double vH = double.Parse(Console.ReadLine());

            //pA = vH * pA;
            //pB = vH * pB;

            //if (pA > pB)
            //{
            //    Console.WriteLine("O professor A tem o maior salário.");
            //}
            //else if (pA == pB)
            //{
            //    Console.WriteLine("Os dois professores tem o mesmo salário.");
            //}
            //else
            //{
            //    Console.WriteLine("O professor B tem o maior salário.");
            //}

            //Exercício 5

            //Console.WriteLine("Digite duas notas do aluno: ");
            //double nota1 = double.Parse(Console.ReadLine());
            //double nota2 = double.Parse(Console.ReadLine());

            //double media = (nota1 + nota2) / 2;
            //if (media >= 7.0)
            //{
            //    Console.WriteLine("Aprovado!");
            //}
            //else
            //{
            //    Console.WriteLine("Digite a nota do exame: ");
            //    double exame = double.Parse(Console.ReadLine());
            //    double mediaF = (exame + media) / 2;
            //    if (mediaF >= 5.0)
            //    {
            //        Console.WriteLine("Aprovado!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Reprovado!");
            //    }
            //}

            //Exercício 6

            //Console.WriteLine("Digite seu nome: ");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Digite a sua altura em metros: ");
            //double altura = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o seu peso em Kg: ");
            //double peso = double.Parse(Console.ReadLine());

            //double imc = peso / (altura * altura);

            //Console.WriteLine(nome + " o seu IMC é: " + imc.ToString().Substring(4, 2));
            //if (imc < 0.0018)
            //{
            //    Console.WriteLine("Baixo peso.");
            //}
            //else if (imc >= 0.0018 && imc < 0.0025)
            //{
            //    Console.WriteLine("Peso normal.");
            //}
            //else if (imc >= 0.0025 && imc < 0.0030)
            //{
            //    Console.WriteLine("Sobrepeso.");
            //}
            //else if (imc >= 0.0030 && imc < 0.0035)
            //{
            //    Console.WriteLine("Obesidade.");
            //}
            //else if (imc >= 0.0035)
            //{
            //    Console.WriteLine("Obesidade grau sério.");
            //}

            //Exercício 7

            //Console.WriteLine("Digite uma frase: ");
            //string frase = Console.ReadLine();
            //Console.WriteLine("Digite uma palavra para pesquisar: ");
            //string palavra = Console.ReadLine();

            //if (frase.Contains(palavra))
            //{
            //    Console.WriteLine("A palavra encontra-se na frase.");
            //}
            //else
            //{
            //    Console.WriteLine("A palavra não se encontra na frase.");
            //}

            //Exercício 8

            //Console.WriteLine("Digite o código do vendedor: ");
            //double codigo = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o nome do vendedor: ");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Digite o salário base: ");
            //double salarioBase = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o total de vendas: ");
            //double totalVendas = double.Parse(Console.ReadLine());

            //if (totalVendas >= 5000)
            //{
            //    double salarioFinal = salarioBase + ((10 * totalVendas) / 100);
            //    Console.WriteLine("O salário final é R$" + salarioFinal);
            //}
            //else if (totalVendas >= 1000 && totalVendas < 5000)
            //{
            //    double salarioFinal = salarioBase + ((7 * totalVendas) / 100);
            //    Console.WriteLine("O salário final é R$" + salarioFinal);
            //}
            //else if (totalVendas >= 500 && salarioBase < 1000)
            //{
            //    double salarioFinal = salarioBase + ((5 * totalVendas) / 100);
            //    Console.WriteLine("O salário final é R$" + salarioFinal);
            //}

            //Exercício 9

            //int valor1, valor2, valor3, valorTotal;

            //Console.WriteLine("Digite 3 valores de glicemia medidos durante o dia: ");
            //valor1 = int.Parse(Console.ReadLine());
            //valor2 = int.Parse(Console.ReadLine());
            //valor3 = int.Parse(Console.ReadLine());

            //valorTotal = valor1 + valor2 + valor3;
            //if (valorTotal < 65)
            //{
            //    Console.WriteLine("Cuidado você corre risco de hipoglicemia.");
            //}
            //else if (valorTotal > 250)
            //{
            //    Console.WriteLine("Cuidado você corre risco de hiperglicemia.");
            //}
            //int media = (valor1 + valor2 + valor3) / 3;
            //if (media < 80)
            //{
            //    Console.WriteLine("É preciso diminuir 2 unidades de insulina");
            //}
            //else if (media > 150)
            //{
            //    Console.WriteLine("É preciso adicionar 2 unidades de insulina");
            //}

            //Exercício 10

            //Console.WriteLine("Digite o nome, idade e altura do atleta A:");
            //string nomeA = Console.ReadLine();
            //int idadeA = int.Parse(Console.ReadLine());
            //int alturaA = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o nome, idade e altura do atleta A:");
            //string nomeB = Console.ReadLine();
            //int idadeB = int.Parse(Console.ReadLine());
            //int alturaB = int.Parse(Console.ReadLine());

            //if (idadeA < idadeB)
            //{
            //    Console.WriteLine(nomeA + " é o mais novo.");
            //}
            //else
            //{
            //    Console.WriteLine(nomeB + " é o mais novo.");
            //}
            //if (alturaA > alturaB)
            //{
            //    Console.WriteLine(nomeA + " é mais alto.");
            //}
            //else
            //{
            //    Console.WriteLine(nomeB + " é mais alto");
            //}

            //Exercício 11
        }
    }
}