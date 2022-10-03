using System.Diagnostics.CodeAnalysis;

namespace lista_exercicios_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01
            //Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

            //int[,] matriz = new int[5, 3];

            //Console.WriteLine("Preencha a 1º primeira coluna: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    matriz[i, 0] = int.Parse(Console.ReadLine());
            //    matriz[i, 1] = matriz[i, 0] + 10;
            //    matriz[i, 2] = matriz[i, 0] * 2;
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("[" + matriz[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}

            //Exercício 02
            /*Solicite ao usuário, preencher uma Matriz 3x3

            Informe ao usuário:
            *A soma dos elementos de cada linha
            -Ex: Linha 1: 30
            Linha 2: 17
            *A soma dos elementos de cada coluna
            -Ex: Coluna 1: 23
            Coluna 2: 36*/

            //int[,] matriz = new int[3, 3];
            //int[] coluna = new int[3], linha = new int[3];
            //int l = 0;

            //Console.WriteLine("Digite os número para preencher a matriz: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    coluna[i] = matriz[i, l] + matriz[i, l + 1] + matriz[i, l + 2];
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (linha[2] != 0)
            //        {
            //            break;
            //        }
            //        linha[j] = matriz[i, j] + matriz[i + 1, j] + matriz[i + 2, j];
            //    }

            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Coluna " + i + " = " + coluna[i]);
            //    Console.WriteLine("Linha " + i + " = " + linha[i]);
            //}

            //Exercício 03
            //Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

            //int[,] matriz = new int[4, 4];

            //Console.WriteLine("Preencha a matriz com números: ");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Os elementos da matriz diagonal principal são: ") ;
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(matriz[i,i]);
            //}

            //Exercício 04
            /*Popule uma matriz 5x5 e informe:
            -Quantos números são pares
            -Quantos números são impares
            -Quantos números são positivos
            -Quantos números são negativos
            -Quantos zeros existem!*/

            //int[,] matriz = new int[5, 5];
            //int par = 0, impar = 0, positivo = 0, negativo = 0, zero = 0;
            //Console.WriteLine("Preencha a matriz com números");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //        if (matriz[i,j] % 2 == 0)
            //        {
            //            par++;
            //        }
            //        else
            //        {
            //            impar++;
            //        }
            //        if (matriz[i, j] >= 0)
            //        {
            //            positivo++;
            //        }
            //        else
            //        {
            //            negativo++;
            //        }
            //        if (matriz[i, j] == 0)
            //        {
            //            zero++;
            //        }
            //    }
            //}
            //Console.WriteLine(+par+ " são pares.\n"+impar+" são impares.\n"+positivo+" são positivos.\n"+negativo+" são negativos.\nExistem "+zero+" zero.");

            //Exercício 05
            //Leia duas matrizes 2x3 de números double. Imprima a soma destas duas matrizes.

            //double[,] matriz1 = new double[2,3], matriz2 = new double[2,3];

            //Console.WriteLine("Preencha as duas matrizes: ");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matriz1[i, j] = double.Parse(Console.ReadLine());
            //        matriz2[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("A soma das matrizes é:");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("matriz 1 ["+i+"x"+j+"] + matriz 2 ["+i+"x"+j+"] = " + (matriz1[i, j] + matriz2[i,j]));
            //    }
            //}

            //Exercício 06
            /*Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
            Random random = new Random();
            int randomNumber = random.Next(0, 100);*/

            //int[,] m = new int[4, 4];

            //Random random = new Random();

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        m[i, j] = random.Next(0, 9);
            //    }
            //}
            //int maior = m[0, 0];
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (m[i,j] > maior)
            //        {
            //            maior = m[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine("O maior número da matriz é: "+maior);

            //Exercício 07
            //Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

            //int[,] a = new int[3, 3], b = new int[3, 3], c = new int[3, 3];

            //Random random = new Random();

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        a[i,j] = random.Next(0, 9);
            //        b[i,j] = random.Next(0, 9);
            //        c[i,j] = a[i,j] - b[i, j];
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("matriz A [" + i + "x" + j + "] - matriz B [" + i + "x" + j + "] = " +c[i, j]);
            //    }
            //}

            //Exercício 09
            //Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

            //int[,] matriz = new int[4, 4];

            //Console.WriteLine("Digite o números para preencher a matriz: ");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Essa é a matriz na ordem que foi digitada: ");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine(matriz[i,j]);
            //    }
            //}

            //Console.WriteLine("Essa é a matriz na ordem inversa que foi digitada: ");
            //for (int i = 3; i >= 0; i--)
            //{
            //    for (int j = 3; j >= 0; j--)
            //    {
            //        Console.WriteLine(matriz[i, j]);
            //    }
            //}

            //Exercício 10
            /*Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
            Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.*/

            //int[,] matriz = new int[3, 3];
            //Random random = new Random();

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matriz[i,j] = random.Next(0, 20);
            //    }
            //}
            //Console.WriteLine("Digite um número aleatório: ");
            //int numero = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (matriz[i,j] == numero)
            //        {
            //            Console.WriteLine("O número existe no vetor.");
            //            return;
            //        }
            //        else if (i == 2 && j == 2 )
            //        {
            //            Console.WriteLine("O número não existe no vetor.");
            //        }

            //    }
            //}

            //Exercício 11
            //Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.


            //int[,] a = new int[4, 4], b = new int[4, 4];
            //Random random = new Random();
            //int soma = 0, cont = 0, acima=0, baixo=0, naMedia=0;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        a[i, j] = random.Next(0, 10);
            //        b[i, j] = random.Next(0, 10);
            //        soma = a[i, j] + b[i, j] + soma;
            //        cont++;
            //    }
            //}
            //double media = soma / cont;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (a[i,j] > media)
            //        {
            //            acima++;
            //        }
            //        else if (a[i, j] < media)
            //        {
            //            baixo++;
            //        }                    
            //        if (b[i, j] > media)
            //        {
            //            acima++;
            //        }
            //        else if (b[i, j] < media)
            //        {
            //            baixo++;
            //        }
            //        else
            //        {
            //            naMedia++;
            //        }

            //    }
            //}
            //Console.WriteLine(+acima+" estão acima da média.\n"+media+" estão na média.\n"+naMedia+" estão a baixo da média.");

            //Exercício 12
            //Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

            //double[,] a = new double[3, 3], resultado = new double[3,3];
            //Random random = new Random();

            //Console.WriteLine("O resultado é: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        a[i,j] = random.Next(1, 20);
            //        resultado[i,j] = a[i,j] / ((i+1)+(j+1));
            //        Console.WriteLine(resultado[i,j]);
            //    }
            //}

        }
    }
}