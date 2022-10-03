using System.Runtime.Intrinsics.Arm;

namespace lista_exercicios_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01
            //Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

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
            //Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

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
            //Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.

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
            //Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

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
            //Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

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
            /*Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
            a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
            b.	escreve: 	|22|7|31|63|0|21|9|3|40|7|*/

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
            /*Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
            a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
            b.	escreve: 	|40|0|22|7|3|9|21|63|31|7|*/

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
            /*Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
            a.	lê:          	|5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
            b.	escreve: 	|3|5|6|7|9|10|14|. . . */


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
            //Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.


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
            //Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.

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
            //Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos do vetor e após escrever os elementos na ordem inversa.


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
            /*Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões),
            senão escrever a mensagem "O número fornecido não existe no vetor!".*/

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
            /*Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8. O vetor terá no máximo 100 posições.
            Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.*/


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
            /*Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. Se o código for zero, termine o algoritmo. Se o código for 1, 
             * mostre o vetor na ordem em que foi lido. Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.*/

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
            /*Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, 
             * invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo. 
             * Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.*/

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
            /*Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
            •	A união de X com Y
            •	A diferença entre X e Y
            •	A interseção entre X e Y
            Escreva o vetor resultado de cada uma das operações.*/

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