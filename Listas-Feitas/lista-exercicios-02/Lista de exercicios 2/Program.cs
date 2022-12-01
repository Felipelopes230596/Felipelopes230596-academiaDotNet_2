using System;
using static System.Net.Mime.MediaTypeNames;

namespace Lista_de_exercicios_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01
            /*Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            Área do triangulo = (base * altura) / 2;
            Teste se a base ou a altura digitada não foi igual a zero.*/

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

            //Exercício 02
            //Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 

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

            //Exercício 03
            //Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

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

            //Exercício 04
            /*Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
            Mostrar na tela qual dos professores tem o maior salário total.*/

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

            //Exercício 05
            /*Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
            se a média das duas notas for maior ou igual a 7,0.
            Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
            é a média entre a nota do exame e a média das 2 notas. 
            Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
            escrever “Reprovado”.*/

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

            //Exercício 06
            /*Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
            O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
            O cálculo do imc = peso / (altura * altura)

            IMC 
            menor que 18                -> baixo peso
            maior que 18 e menor que 25 -> peso normal
            maior que 25 e menor que 30 -> sobrepeso
            maior que 30 e menor que 35 -> obesidade
            maior que 35                -> obesidade grau sério*/

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

            //Exercício 07
            /*Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
            exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.*/

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

            //Exercício 08
            /*Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
            Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
            Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
            E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
            total de vendas.*/

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

            //Exercício 09
            /*Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
            diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
            Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
            Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
            Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
            menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
            150, avisá-lo que será necessário adicionar 2 unidades de insulina.*/

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
            /*Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
            O programa deve mostrar os dados do atleta mais novo e mais alto.*/

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
            /*Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
            O programa deve exibir se a hora digitada está ou não válida. 
            Lembre que usaremos o padrão de hora com 24h, de 0 a 23.*/


            //int h=0, m=0;
            //Console.WriteLine("Digite a hora desejada: ");
            //h = int.Parse(Console.ReadLine());

            //if (h < 0 || h > 23)
            //{
            //    Console.WriteLine("Hora inválida: ");
            //}

            //Console.WriteLine("Digite os minutos: ");
            //m = int.Parse(Console.ReadLine());

            //Exercício 12
            /*Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
            número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
            R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
            armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
            No final do processamento, exibir o salário total e o salário excedente do operário.*/

            //int codigo, numeroHoras, salario, extra = 0;

            //Console.Write("Digite o código do operário: ");
            //codigo = int.Parse(Console.ReadLine());
            //Console.Write("Digite a quantidade de horas trabalhadas: ");
            //numeroHoras = int.Parse(Console.ReadLine());

            //if (numeroHoras > 50)
            //{
            //    extra = (numeroHoras - 50) * 20;
            //    salario = 10 * numeroHoras;
            //}
            //else
            //{
            //    salario = 10 * numeroHoras;
            //}

            //Console.WriteLine("O salario total do operario é R$"+salario+"\nO excedente é R$"+extra);

            //Exercício 13
            /*Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
            seu peso ideal, utilizando as seguintes fórmulas:
            Para homens: (72.7 * h) - 58
            Para mulheres: (62.1 * h) - 44.7*/

            //Console.Write("Digite a altura com (0,00): ");
            //double altura = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o sexo: ");
            //string sexo = Console.ReadLine();

            //if (sexo == "masculino")
            //{
            //    double pesoIdealH = (72.7 * altura) - 58;
            //    Console.WriteLine("O seu peso ideal é " + pesoIdealH.ToString().Substring(0,4));
            //}
            //else
            //{
            //    double pesoIdealM = (62.1 * altura) - 44.7;
            //    Console.WriteLine("O seu peso ideal é " + pesoIdealM.ToString().Substring(0, 4));
            //}

            //Exercício 14
            /*Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
            link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
            do arquivo usando este link (em minutos).*/

            //Console.Write("Digite o tamanho do arquivo que deseja fazer o download em Mb: ");
            //int tamanho = int.Parse(Console.ReadLine());
            //Console.Write("Digite a velocidade da internet em Mbps: ");
            //int velocidade = int.Parse(Console.ReadLine());

            //int tempo = (tamanho / velocidade) / 60 ;

            //Console.WriteLine("O tempo aproximado que será gasto para o download com a velocidade de "+velocidade+"Mbps será de "+tempo+" Minutos");

            //Exercício 15
            /*Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
            da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
            e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
            Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.*/

            //int quantidadeL, quantidadeLatas, total;
            //Console.Write("Quanto metros quandrados serão pintados? ");
            //int metros = int.Parse(Console.ReadLine());

            //quantidadeL = metros / 3; 

            //if (quantidadeL <= 18)
            //{
            //    Console.WriteLine("Será apenas uma lata de tinta com 18L total de R$80");
            //}
            //else
            //{
            //    quantidadeLatas = quantidadeL / 18;
            //    total = quantidadeLatas * 80;
            //    Console.WriteLine("Serão gastas "+quantidadeLatas+" latas de tinta e o valor total é R$"+total);
            //}

            //Exercício 16
            /*Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
            na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
            enfrentar novamente em um novo jogo.
            ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
            ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
            plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.*/

            //int casa, fora;

            //Console.Write("Digite o placar do jogo, primeiro time de casa: ");
            //casa = int.Parse(Console.ReadLine());
            //Console.Write("agora time de fora: ");
            //fora = int.Parse(Console.ReadLine());

            //if (casa == (fora + 1))
            //{
            //    Console.WriteLine("Os dois times se enfrentarão em um novo jogo!");
            //    Console.Write("Digite o placar do jogo, primeiro time de casa: ");
            //    casa = int.Parse(Console.ReadLine());
            //    Console.Write("agora time de fora: ");
            //    fora = int.Parse(Console.ReadLine());
            //    if (fora == casa)
            //    {
            //        Console.WriteLine("Jogo empatado!");
            //    }
            //    else if(fora > casa)
            //    {
            //        Console.WriteLine("O time de fora se classificou para a proxima fase!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("O time de casa se classificou para a proxima fase!");
            //    }
            //}
            //else if (casa > (fora +1))
            //{
            //    Console.WriteLine("O time de casa já se classificou");
            //}
            //else
            //{
            //    Console.WriteLine("O time de fora se classificou!");
            //}

            //Exercício 17
            /*Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
            formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
            os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).*/

            //Console.WriteLine("Digite 3 medidas para um triangulo: ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //if (a <= (b + c) || b <= (c + a) || c <= (b + a))
            //{
            //    if (a == b && b == c)
            //    {
            //        Console.WriteLine("Esse triangulo é equilátero!");
            //    }
            //    else if (a == b || b == c || c == a)
            //    {
            //        Console.WriteLine("Esse triangulo é isoceles!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Esse triangulo é escaleno!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Essas medidas não formam um triangulo!");
            //}

            //Exercício 18
            /*Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.*/

            //Console.WriteLine("Digite 3 valores:");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //if (a > b && a > c)
            //{
            //    Console.WriteLine(a+" é o maior valor!");
            //}else if (b > a && b > c)
            //{
            //    Console.WriteLine(b+" é o maior valor!");
            //}
            //else
            //{
            //    Console.WriteLine(c+" é o maior valor!");
            //}

            //Exercício 19
            //Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

            //int primeiro = 0, segundo = 0, terceiro = 0;

            //Console.WriteLine("Digite 3 valores:");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a < b && a < c)
            //{
            //    primeiro = a;
            //}
            //else if (b < c && b < a)
            //{
            //    primeiro = b;
            //}
            //else
            //{
            //    primeiro = c;
            //}

            //if ((a > b && a < c) || (a > c && a < b))
            //{
            //    segundo = a;
            //}
            //else if ((b > a && b < c) || (b > c && b < a))
            //{
            //    segundo = b;
            //}
            //else
            //{
            //    segundo = c;
            //}

            //if (a > b && a > c)
            //{
            //    terceiro = a;
            //}
            //else if (b > a && b > c)
            //{
            //    terceiro = b;
            //}
            //else
            //{
            //    terceiro = c;
            //}

            //Console.WriteLine(primeiro+"\n"+segundo+"\n"+terceiro);

            //Exercício 20
            /*Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            plus: você pode gerar o número de forma randomica (função random c#).*/

            //int nSecreto = 8;

            //Console.WriteLine("Digite um número: ");
            //int numero = int.Parse(Console.ReadLine());
            //if (numero > nSecreto)
            //{
            //    Console.WriteLine("é menor!");
            //}
            //else if (numero == nSecreto)
            //{
            //    Console.WriteLine("acertou!");
            //}
            //else
            //{
            //    Console.WriteLine("é maior");
            //}
            //Console.WriteLine("Digite novamente: ");
            //numero = int.Parse(Console.ReadLine());
            //if (numero > nSecreto)
            //{
            //    Console.WriteLine("é menor!");
            //}
            //else if (numero == nSecreto)
            //{
            //    Console.WriteLine("acertou!");
            //}
            //else
            //{
            //    Console.WriteLine("é maior");
            //}
            //Console.WriteLine("Digite novamente: ");
            //numero = int.Parse(Console.ReadLine());
            //if (numero > nSecreto)
            //{
            //    Console.WriteLine("é menor!");
            //}
            //else if (numero == nSecreto)
            //{
            //    Console.WriteLine("acertou!");
            //}
            //else
            //{
            //    Console.WriteLine("é maior");
            //}
        }
    }
}