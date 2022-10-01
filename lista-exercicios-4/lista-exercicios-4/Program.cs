using System.Runtime.Intrinsics.Arm;

namespace lista_exercicios_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01

            //int[] vetor = new int[10];
            //int i, contPares = 0, contImpar = 0;
            //Console.WriteLine("Digite 10 números: ");
            //for (i = 0; i < 10; i++)
            //{
            //    Console.Write("Digite o "+(i+1)+"º número: ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //for (i = 0; i < 10; i++)
            //{
            //    if (vetor[i] % 2 == 0)
            //    {
            //        contPares++;
            //    }
            //    else
            //    {
            //        contImpar++;
            //    }
            //}
            //Console.WriteLine("São " + contPares + " números par e " + contImpar + " números ímpar.");  

            //Exercício 02

            //int[] vetor1 = new int[20], vetor2 = new int[20], vetor3 = new int[20];
            //int i, soma = 0;

            //Console.WriteLine("Digite 20 números: ");
            //for (i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("Digite o " + (i + 1) + "º número do 1º vetor: ");
            //    vetor1[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o " + (i + 1) + "º número do 2º vetor: ");
            //    vetor2[i] = int.Parse(Console.ReadLine());
            //    vetor3[i] = vetor1[i] + vetor2[i];
            //}
            //for (i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("Os valores armazenados no 3º vetor são posição " + i + " " + vetor3[i]);
            //}

            //Exercício 03

            //int[] vetor = new int[20];
            //int i, contador = 0;
            //Console.WriteLine("Digite 20 números: ");
            //for (i = 0; i < 5; i++)
            //{
            //    vetor[i]=int.Parse(Console.ReadLine());
            //}
            //for (i = 0; i < 5; i++)
            //{
            //    contador = 0;
            //    for (int verificador = 1; verificador <= vetor[i]; verificador++)
            //    {
            //        if (vetor[i] % verificador == 0)
            //        {
            //            contador++;

            //        }
            //        if (verificador == vetor[i] && contador == 2)
            //        {
            //            Console.WriteLine("A posição " + i + " do vetor é primo");
            //        }
            //    }
            //}

            //Exercício 04

            //int[] vetor1 = new int[10], vetor2 = new int[10], resultado = new int[10];
            //int i;
            //Console.WriteLine("Digite 10 valores: ");
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Digite o valor para o 1º vetor: ");
            //    vetor1[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor para o 2º vetor: ");
            //    vetor2[i] = int.Parse(Console.ReadLine());
            //    resultado[i] = vetor1[i] * vetor2[i];
            //}
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("O resultado da posição "+i+" é: " + resultado[i]);
            //}

            //Exercício 05

            //int[] vetor = new int[80];
            //int posicao = 0;
            //Console.WriteLine("Digite 80 números inteiros: ");
            //for (int i = 0; i < 80; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //int menorNumero = vetor[0];
            //for (int i = 0; i < 80; i++)
            //{
            //    if (vetor[i] < menorNumero )
            //    {
            //        menorNumero = vetor[i];
            //        posicao = i;
            //    }
            //}
            //Console.WriteLine(menorNumero+" é o menor número registrado e a posição dele é "+posicao);

            //Exercício 06

            //int[] vetor = new int[10];

            //Console.WriteLine("Digite 10 números: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine()) ;
            //}
            //Console.WriteLine("Esses são os números armazenados no vetor: ");
            //for (int i = 9; i >=0 ; i--)
            //{
            //    Console.WriteLine(vetor[i]);
            //}

            //Exercício 07

            //int[] vetor = new int[10];

            //Console.WriteLine("Digite 10 números: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    vetor[i]= int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("Esses são todos os números par: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (vetor[i]%2==0)
            //    {
            //        Console.WriteLine(vetor[i]);
            //    }
            //}
            //Console.WriteLine("Esses são todos os números ímpar: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (vetor[i] % 2 == 1)
            //    {
            //        Console.WriteLine(vetor[i]);
            //    }
            //}

            //Exercício 08

            //double[] vetor = new double[30];

            //Console.WriteLine("Digite 30 números reais: ");
            //for (int i = 0; i < 30; i++)
            //{
            //    vetor[i] = double.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 30; i++)
            //{
            //    if  (vetor[i] < 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Exercício 09

            //int[] vetor1 = new int[10], vetor2 = new int[10];

            //Console.WriteLine("Digite 10 números: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    vetor1[i] = int.Parse(Console.ReadLine());
            //}

            //int aux = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = i + 1; j < 10; j++)
            //    {
            //        if (vetor1[i] > vetor1[j])
            //        {
            //            aux = vetor1[i];
            //            vetor1[i] = vetor1[j];
            //            vetor1[j] = aux;
            //        }
            //    }

            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    vetor2[i] = vetor1[i];
            //}
            //Console.WriteLine("Os números organizados em ordem crescente: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(vetor2[i]);
            //}

            //Exercício 10

            //int[] vetor1 = new int[20], vetor2 = new int[20];

            //Console.WriteLine("Digite 20 números: ");
            //for (int i = 0; i < 20; i++)
            //{
            //    vetor1[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    if (vetor1[i] == 0)
            //    {
            //        vetor2[i] = 2;
            //    }
            //    else
            //    {
            //        vetor2[i] = vetor1[i];
            //    }
            //}
            //Console.WriteLine("Vetor 1: ");
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(vetor1[i]);
            //}
            //Console.WriteLine("Vetor 2: ");
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(vetor2[i]);
            //}

            //Exercício 11

            //int[] vetor = new int[5];
            //int aux = 0;
            //Console.WriteLine("Digite 5 números: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    vetor[i]=int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Vetor posição normal: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(vetor[i]);
            //}
            //Console.WriteLine("Vetor posição invertida: ");
            //for (int i = 4; i >= 0; i--)
            //{
            //    Console.WriteLine(vetor[i]);
            //}

            //Exercício 12

            //int[] v = new int[10];
            //int n = 0;
            //bool existe = false;
            //Console.WriteLine("Digite 10 números: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    v[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Digite o número que deseja pesquisar: ");
            //n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 10; i++)
            //{
            //    if (v[i] == n)
            //    {
            //        Console.WriteLine("A posição do número é "+i);
            //        existe = true;
            //    }
            //}
            //if (existe == false)
            //{
            //    Console.WriteLine("O número fornecido não existe no vetor!");
            //}

            //Exercício 13

            //int[] vetor = new int[100];
            //int contador2 = 0, contador4 = 0, contador8 = 0;
            //Console.WriteLine("Digite 100 números:");
            //for (int i = 0; i < 100; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine());
            //    if (vetor[i] == -1 || i == 99)
            //    {
            //        break;
            //    }
            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    if (vetor[i] == 2)
            //    {
            //        contador2++;
            //    }
            //    else if (vetor[i] == 4)
            //    {
            //        contador4++;
            //    }
            //    else if (vetor[i] == 8)
            //    {
            //        contador8++;
            //    }
            //}
            //Console.WriteLine("O número 2 apareceu "+contador2+" vezes.\nO número 4 apareceu "+contador4+" vezes. \nO número 8 apareceu "+contador8+" vezes.");

            //Exercício 14

            //int codigo;
            //int[] vetor = new int[50];

            //Console.WriteLine("Digite 50 números para preencher o vetor:  ");
            //for (int i = 0; i < 5; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine()) ;   
            //}
            //Console.WriteLine("-------Digite 1 para exibir o vetor em ordem------- \n-------Digite 2 para exibir o vetor em ordem inversa------- \n-------Digite zero para finalizar-------");
            //codigo = int.Parse(Console.ReadLine());
            //if (codigo == 1)
            //{
            //    for (int i = 0; i < 50; i++)
            //    {
            //        Console.WriteLine(vetor[i]);
            //    }
            //}
            //else if (codigo == 2)
            //{
            //    for (int i = 49; i >= 0 ; i--)
            //    {
            //        Console.WriteLine(vetor[i]);
            //    }
            //}
            //else if (codigo == 0)
            //{
            //    Console.WriteLine("Programa finalizado.");
            //    return;
            //}

            //Exercício 15

            //int[] vetor1 = new int[20], vetor2 = new int[20];

            //Console.WriteLine("Digite 20 números: ");
            //for (int i = 0; i < 20; i++)
            //{
            //    vetor1[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 19; j >=0 ; j--)
            //    {
            //        if (vetor2[j] == 0)
            //        {
            //            vetor2[j] = vetor1[i];
            //            break;
            //        }
            //    }
            //}

            //    Console.WriteLine("-------Vetor ordem normal-------");
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(+vetor1[i]);
            //}
            //Console.WriteLine("-------Vetor ordem inversa-------");
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(vetor2[i]);
            //}

            //Exercício 16

            //int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, y = new int[10] { 1, 6, 30, 4, 5, 60, 7, 9, 10, 11 }, uniao = new int[20], diferenca = new int[10], intercecao = new int[10];
            //int posicaoIntercecao = 0, posicaoDiferenca = 0, posicaoUniao = 10;

            //x.CopyTo(uniao, 0);

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (x[i] == y[j])
            //        {
            //            intercecao[posicaoIntercecao] = x[i];
            //            posicaoIntercecao++;
            //            break;
            //        }
            //    }
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (x[i] == y[j])
            //        {
            //            break;
            //        }
            //        if (j == (x.Length - 1))
            //        {
            //            diferenca[posicaoDiferenca] = x[i];
            //            posicaoDiferenca++;
            //        }
            //    }
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (x[j] == y[i])
            //        {
            //            break;
            //        }
            //        if (j == (x.Length - 1))
            //        {
            //            diferenca[posicaoDiferenca] = y[i];
            //            posicaoDiferenca++;
            //        }
            //    }
            //}


            //for (int i = 0; i < y.Length; i++)
            //{
            //    for (int j = 0; j < x.Length; j++)
            //    {
            //        if (y[i] == x[j])
            //        {
            //            break;
            //        }
            //        if (j == (x.Length - 1))
            //        {
            //            uniao[posicaoUniao] = y[i];
            //            posicaoUniao++;
            //        }
            //    }
            //}
            //Console.WriteLine("A união é");
            //for (int i = 0; uniao[i]!=0; i++)
            //{
            //    Console.WriteLine(uniao[i]);
            //}
            //Console.WriteLine("A diferença é");
            //for (int i = 0; diferenca[i] !=0 ; i++)
            //{
            //    Console.WriteLine(diferenca[i]);
            //}
            //Console.WriteLine("A interceção é");
            //for (int i = 0; intercecao[i] !=0; i++)
            //{
            //    Console.WriteLine(intercecao[i]);
            //}

            //Lista finalizada 01/10/2022

        }
    }
}