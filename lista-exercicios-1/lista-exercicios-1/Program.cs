using System;
using System.Runtime.Intrinsics.X86;

namespace lista_exercicios_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01
            // Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

            //double a, b;
            //Console.WriteLine("Escreva o primeiro número: ");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Escreva o segundo número: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("O resultado da média aritimética é " + (a + b) / 2);


            //Exercício 02
            //Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

            //double a, b, c, d;
            //Console.WriteLine("Escreva o primeiro número: ");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Escreva o segundo número: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Escreva o primeiro número: ");
            //c = double.Parse(Console.ReadLine());
            //Console.WriteLine("Escreva o segundo número: ");
            //d = double.Parse(Console.ReadLine());
            //Console.WriteLine("O resultado da média aritimética é " + (a + b + c + d) / 4);



            //Exercício 03
            //Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre si os valores de duas variáveis A e B.


            //int a = 2, b = 3, c;
            //Console.WriteLine("Os valores de A=" + a + " B=" + b);
            //c = a;
            //a = b;
            //b = c;
            //Console.WriteLine("Os novos valores de A=" + a + " B=" + b);


            //Exercício 04
            //Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            //string d, m;
            //int a;
            //Console.WriteLine("Digite a data desejada, DDMMAAAA: ");
            //d = Console.ReadLine();
            //m = Console.ReadLine();
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("A data no formato AAAAMMDD é: " + a + "/" + m + "/" + d + " e no formato AAMMDD é: " + a.ToString().Substring(2, 2) + "/" + m + "/" + d);

            //Exercício 05
            /*Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel (medido em Km/ l), sendo que são conhecidos a distância total percorrida e o volume de combustível
            consumido para percorrê-la(medido em l).*/


            //int km, l;
            //Console.WriteLine("Digite a distância percorida: ");
            //km = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de litros consumiudo: ");
            //l = int.Parse(Console.ReadLine());
            //Console.WriteLine("O consumo médio foi de " + km / l + "km/l");


            //Exercício 6
            /*Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
            de IPI(única) a ser acrescentada.*/

            //double codA, codB, qtdA, qtdB, vlrA, vlrB, ipi;

            //Console.WriteLine("Digite o código do produto A: ");
            //codA = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade do produto A: ");
            //qtdA = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do produto A: ");
            //vlrA = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o código do produto B: ");
            //codB = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade do produto A: ");
            //qtdB = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do produto A: ");
            //vlrB = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o percentual de IPI a ser aplicado: ");
            //ipi = double.Parse(Console.ReadLine());

            //Console.WriteLine("O valor com IPI do produto A é: " + (ipi / vlrA) * 100);
            //Console.WriteLine("O valor com IPI do produto B é: " + (ipi / vlrB) * 100);

            //Exercício 7
            /*Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
            Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.*/


            //double nVend, sFixo, tVendas, percent, sFinal;

            //Console.WriteLine("Insira o número do vendedor: ");
            //nVend = double.Parse(Console.ReadLine());
            //Console.WriteLine("Insira o salário fixo: ");
            //sFixo = double.Parse(Console.ReadLine());
            //Console.WriteLine("Insira o valor total de vendas: ");
            //tVendas = double.Parse(Console.ReadLine());
            //Console.WriteLine("Insira a porcentagem de comissão: ");
            //percent = double.Parse(Console.ReadLine());

            //sFinal = sFixo + ((percent * tVendas) / 100);

            //Console.WriteLine("O salário final do vendedor " + nVend + " é de R$" + sFinal);

            //Exercício 8
            /*Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            A fórmula da conversão é F=(9*C+160)/5.*/

            //double c, f;
            //Console.WriteLine("Digite a temperatura em graus celsius: ");
            //c = double.Parse(Console.ReadLine());
            //f = (9 * c + 160) / 5;
            //Console.WriteLine("A temperatura em graus Fahrenheit é " + f + "°F");

            //Exercício 9
            /*Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
            do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
            Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
            se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
            Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            da entrada e das duas prestações, de acordo com as regras acima. 
            Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
            conseqüente pagamento dos boletos das duas prestações.*/

            //double vP, vE, p;

            //Console.WriteLine("Qual o valor do produto?");
            //vP = double.Parse(Console.ReadLine());
            //p = vP / 3;
            //p = Math.Floor(p);
            //vE = vP - (p * 2);
            //Console.WriteLine("O valor de entrada é R$" + vE + "\nO valor de cada parcela é R$" + p);

            //Exercício 10
            /*Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
            para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
            realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
            notas de menor valor fossem distribuídas em número mínimo possível. 
            Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
            uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
            Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
            de acordo com o critério da “distribuição ótima”.*/

            //double vS, c, cem = 0, cinquenta = 0, vinte = 0, dez = 0, cinco = 0, um = 0;
            //Console.WriteLine("Digite o valor que deseja sacar:");
            //vS = double.Parse(Console.ReadLine());
            //c = vS;

            //while (c > 0)
            //{
            //    if (c >= 100)
            //    {
            //        c = c - 100;
            //        cem++;
            //    }
            //    if (c < 100 && c >= 50)
            //    {
            //        c = c - 50;
            //        cinquenta++;
            //    }
            //    if (c < 50 && c >= 20)
            //    {
            //        c = c - 20;
            //        vinte++;
            //    }
            //    if (c < 20 && c >= 10)
            //    {
            //        c = c - 10;
            //        dez++;
            //    }
            //    if (c < 10 && c >= 5)
            //    {
            //        c = c - 5;
            //        cinco++;
            //    }
            //    if (c < 5 && c >= 1)
            //    {
            //        c = c - 1;
            //        um++;
            //    }
            //}
            //Console.WriteLine("Sacando... \nCalculando quantidade de cédulas... \nCédula de R$100: " + cem + "\nCédula de R$50: " + cinquenta + "\nCédula de R$20: " + vinte + "\nCédula de R$10: " + dez + "\nCédula de R$5: " + cinco + "\nCédula de R$1: " + um);
            //Console.WriteLine("Você sacou R$" + vS);

            //Exercício 11
            /* Escreva um algoritmo para ler o número de eleitores de um município, 
            o número de votos brancos, nulos e válidos.
            Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.*/

            //double nE, vB, vN, vV, pB, pN, pV;

            //Console.WriteLine("Digite o número de eleitores: ");
            //nE = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o número de votos brancos: ");
            //vB = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o número de votos nulos: ");
            //vN = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o número de votos válidos: ");
            //vV = double.Parse(Console.ReadLine());

            //pB = vB / nE;
            //pN = vN / nE;
            //pV = vV / nE;

            //Console.WriteLine("A porcentagem de votos é: \n" + pB.ToString().Substring(2, 2) + "% de votos brancos.\n" + pN.ToString().Substring(2, 2) + "% de votos nulos.\n" + pV.ToString().Substring(2, 2) + "% de votos válidos.");

            //Exercício 12
            /*Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
            marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
            dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.*/

            //double hodI, hodF, litG, vR, lucro = 0, cons;

            //Console.WriteLine("Digite o km inicial: ");
            //hodI = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o km final: ");
            //hodF = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite quantos litros foram gastos: ");
            //litG = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite qual total recebido: ");
            //vR = double.Parse(Console.ReadLine());

            //cons = (hodF - hodI) / litG;
            //lucro = vR - (litG * 6.90);


            //Console.WriteLine("O consumo médio foi " + cons + "Km/l \nO lucro foi de R$" + lucro);

            //Exercício 13
            /*Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
            preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
            vendidas pelo vendedor, calcule e mostre: o salário do empregado*/

            //double sM, pC, qV, sF;

            //Console.WriteLine("Digite o sslário mínimo: ");
            //sM = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor de custo de cada bicleta: ");
            //pC = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade vendida:");
            //qV = double.Parse(Console.ReadLine());


            //sF = (sM * 2) + (15 * (pC * qV) / 100);
            //Console.WriteLine("O salário do funcionário é R$" + sF);



            //Lista finalizada 26 / 09 / 2022






            Console.ReadKey(); // Aguarda o usuário precionar um tecla!
        }
    }
}