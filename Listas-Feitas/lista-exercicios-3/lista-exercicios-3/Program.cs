using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace lista_exercicios_3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //Exercício 01
            /*Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
            (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

            Exemplo:
            Digite um número inteiro positivo: -8
            Valor incorreto!
            Digite um número inteiro positivo: 8
            Numero digitado: 8
            Números inteiros pares entre 1 e 8: 2, 4, 6.*/

            //int contador = 0;
            //Console.WriteLine("Digite um número inteiro positivo: ");
            //int numero = int.Parse(Console.ReadLine());

            //while (numero < 0)
            //{
            //    Console.WriteLine("Valor incorreto!");
            //    Console.WriteLine("Digite um número inteiro positivo:");
            //    numero = int.Parse(Console.ReadLine());
            //}
            //for (int i = 1; i <= numero; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine("Numeros pares entre 1 e "+numero+" são: " +i);
            //    }
            //}

            //Exercício 02
            /*Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
            informar um outro número. Caso positivo, o programa em VS deve ser repetido.

            Exemplo:
            Digite um número inteiro positivo: 8
            Numero digitado: 8
            Números inteiros pares entre 1 e 8: 2, 4, 6.

            Deseja informar outro número (s/n)? S

            Digite um número inteiro positivo: 12
            Numero digitado: 20
            Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.

            Deseja informar outro número (s/n)? N */

            //int numero = 0;
            //string escolha = "s";
            //while (escolha == "s")
            //{
            //    Console.WriteLine("Digite um número inteiro positivo: ");
            //    numero = int.Parse(Console.ReadLine());
            //    while (numero <= 0)
            //    {
            //        Console.WriteLine("Valor incorreto!");
            //        Console.WriteLine("Digite um número inteiro positivo:");
            //        numero = int.Parse(Console.ReadLine());
            //    }

            //    Console.WriteLine("Números pares entre 1 e " + numero + " são: ");
            //    for (int i = 1; i <= numero; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //    Console.WriteLine("Deseja informar outro número (s/n)?");
            //    escolha = Console.ReadLine();
            //} 

            //Exercício 03
            /*Fazer um laço (repetição) que fique solicitando números ao usuário. 
            Se o usuário digitar 0 o programa em VS deve parar. 
            Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.*/

            //int divisor = 0;   
            //int numero = 1;
            //while(numero != 0)
            //{
            //    Console.WriteLine("Digite um número: ");
            //    numero = int.Parse(Console.ReadLine());
            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine("Esse número é par!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Esse número é ímpar!");
            //    }
            //    for (int i = 1; i <= numero; i++)
            //    {
            //        if(numero % i == 0)
            //        {
            //            divisor++;
            //        }
            //    }
            //    if (divisor == 2)
            //    {
            //        Console.WriteLine("É primo!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Não é primo!");
            //    }

            //}

            //Exercício 04
            /*Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
            Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
            Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
            Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
            escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
            de votos em branco. */

            //int joao = 0, zeca = 0, branco = 0;
            //string voto = null;
            //while(true)
            //{
            //    Console.WriteLine("Em quem deseja votar joao, zeca ou branco?");
            //    voto = Console.ReadLine();
            //    if(voto == "joao")
            //    {
            //        joao++;
            //    }else if(voto == "zeca")
            //    {
            //        zeca++;
            //    }else if(voto == "fim")
            //    {
            //        Console.WriteLine("O resultado da votação é: \nJoão: "+joao+" votos. \nZeca: "+zeca+" votos. \nBranco: "+branco+" votos.");
            //        break;
            //    }
            //    else
            //    {
            //        branco++;
            //    }

            //}

            //Exercício 05
            /*Modifique o programa em VS anterior para aceitar votos nulos 
            (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
            Ao final, informe o nome do candidato vencedor, o número de votos nulos 
            e o número de pessoas que votaram.*/

            //int joao = 0, zeca = 0, branco = 0, nulo = 0;
            //string voto = null;
            //while (true)
            //{
            //    Console.WriteLine("Em quem deseja votar joao, zeca ou branco?");
            //    voto = Console.ReadLine();
            //    if (voto == "joao")
            //    {
            //        joao++;
            //    }
            //    else if (voto == "zeca")
            //    {
            //        zeca++;
            //    }
            //    else if (voto == "fim")
            //    {
            //        Console.WriteLine("O resultado da votação é: \nJoão: " + joao + " votos. \nZeca: " + zeca + " votos. \nBranco: " + branco + " votos. \nNulo: "+nulo + "\n"+(nulo+zeca+joao+branco)+" pessoas votaram.");
            //        if(joao > zeca && joao > branco && joao > nulo)
            //        {
            //            Console.WriteLine("Joao venceu a votação! \nForam " + nulo + " votos nulo. \n" + (nulo + zeca + joao + branco) + " votaram.");
            //        }else if(zeca > joao && zeca > branco && zeca > nulo)
            //        {
            //            Console.WriteLine("Zeca venceu a votação! \nForam "+nulo+" votos nulo.");
            //        }else if(branco > joao && branco > zeca && branco > nulo)
            //        {
            //            Console.WriteLine("Houve mais votos branco por isso não houve vencedor");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Houve mais votos nulo por isso não houve vencedor");
            //        }
            //        break;
            //    }else if (voto != "zeca" && voto != "zeca" && voto != "branco" && voto != "fim")
            //    {
            //        nulo++;
            //    }
            //    else
            //    {
            //        branco++;
            //    }

            //}

            //Exercício 06
            /*Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
            ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
            Ao final, mostre a idade digitada.*/

            //Console.WriteLine("Digite sua idade: ");
            //int idade = int.Parse(Console.ReadLine());

            //while (idade <= 0)
            //{
            //    Console.WriteLine("Idade incorreta digite novamente");
            //    idade = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("A idade digitada é "+idade);  

            //Exercício 07
            /*Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
            A cada solicitação, teste se o usuário informou um valor válido. 
            Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            informe que ele está incorreto e saia do programa em VS. 
            Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
            informe que está errada e saia. Se estiver correta, solicite o salário. 
            Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
            Se estiver correto, mostre todos os valores lidos.*/

            //int saida;
            //string nome = "";

            //Console.WriteLine("Digite o seu nome: ");
            //nome = Console.ReadLine();

            //bool eNumero = int.TryParse(nome, out saida);

            //if (eNumero || nome == "")
            //{
            //    Console.WriteLine("Nome incorreto!");
            //    Environment.Exit(0);
            //}
            //else { 

            //Console.WriteLine("Digite sua idade: ");
            //int idade = int.Parse(Console.ReadLine());


            //if (idade <= 0)
            //{
            //    Console.WriteLine("Idade incorreta!");
            //    Environment.Exit(0);
            //}

            //Console.WriteLine("Digite seu salário: ");
            //int salario = int.Parse(Console.ReadLine());

            //if (salario <= 0)
            //{
            //    Console.WriteLine("Salário incorreto!");
            //    Environment.Exit(0);
            //}

            //Console.WriteLine("Nome: " + nome + "\nIdade: " + idade + " anos.\nSalário: R$" + salario);
            //}

            //Exercício 08
            /*Faça um programa em VS que solicite um numero inteiro. S
            e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
            Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
            */

            //string decisao = "s";

            //while (decisao == "s") {
            //Console.WriteLine("Digite um número inteiro: ");
            //float numero = float.Parse(Console.ReadLine());
            //    while (numero != (int)numero)
            //    {
            //        Console.WriteLine("Digite um número inteiro: ");
            //        numero = float.Parse(Console.ReadLine());
            //    }
            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine("O número digitado é par.\nGostaria de repetir? (s/n)");
            //        decisao = Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("O número digitado é ímpar.\nGostaria de repetir? (s/n)");
            //        decisao = Console.ReadLine();
            //    }
            //}

            //Exercício 09
            /*Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
            o zoológico num determinado dia, imprimindo:
            Quantas pessoas tem entre 1 e 3 filhos.
            Quantas pessoas tem entre 4 e 7 filhos.
            Quantas pessoas tem mais de 8 filhos.
            Quantas pessoas não tem filhos.*/

            //int cont1=0, cont2=0, cont3=0, cont4=0;

            //for (int i = 1; i <= 30 ; i++)
            //{
            //    Console.WriteLine("Digite quantos filhos tem a " +i+"º pessoa: ");
            //    int p = int.Parse(Console.ReadLine());

            //    if (p >= 1 && p <= 3)
            //    {
            //        cont1++;
            //    }else if(p >= 4 && p <= 7)
            //    {
            //        cont2++;
            //    }else if(p >= 8)
            //    {
            //        cont3++;
            //    }
            //    else
            //    {
            //        cont4++;
            //    }
            //}

            //Console.WriteLine(cont1+ " pessoas tem entre 1 e 3 filhos.\n"+cont2+" pessoas tem entre 4 e 7 filhos.\n"+cont3+" pessoas tem mais de 8 filhos.\n"+cont4+" pessoas não tem filhos.");

            //Exercício 10
            /*Ler nome, sexo e idade de 50 pessoas e após imprimir:
            Número de pessoas do sexo masculino.
            Número de pessoas do sexo feminino.
            Número de pessoas com idade inferior a 30 anos.
            Número de pessoas com idade superior a 60 anos.
            Média de idade das mulheres.*/

            //int masculino = 0, feminino = 0, inferior30 = 0, superior60 = 0, mediaIdade = 0, somaIdades = 0, idade = 0;
            //string nome = "", sexo = "";

            //for (int i = 0; i <= 50; i++)
            //{
            //    Console.Write("Preencha as informações a baixo: \nNome: ");
            //    nome = Console.ReadLine();
            //    Console.Write("Sexo: ");
            //    sexo = Console.ReadLine();
            //    Console.Write("Idade: ");
            //    idade = int.Parse(Console.ReadLine());

            //    if (sexo == "masculino")
            //    {
            //        masculino++;
            //    }
            //    else if (sexo == "feminino")
            //    {
            //        feminino++;
            //        somaIdades = idade + idade;
            //    }
            //    if (idade < 30)
            //    {
            //        inferior30++;
            //    }
            //    else if (idade > 60)
            //    {
            //        superior60++;
            //    }
            //}
            //mediaIdade = somaIdades / feminino;

            //Console.WriteLine(masculino + " pessoas do sexo masculino.\n"
            //    + feminino + " pessoas do sexo feminino.\n"
            //    + inferior30 + " pessoas com idade inferior a 30 anos.\n"
            //    + superior60 + " pessoas com idade superior a 60 anos.\n"
            //    + "A média de idade das mulheres é " + mediaIdade + " anos.");

            //Exercício 11
            /*Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
            a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.*/

            //int nota = 0, mediaNotas = 0, quantidadeA = 0, encerrar = 0, compareNotaAlta = 0, compareNotaBaixa = 0, somaNotas = 0;

            //for (int i = 1; nota != -1; i++)
            //{
            //    Console.WriteLine("Digite a nota do " + i + "º aluno: ");
            //    nota = int.Parse(Console.ReadLine());
            //    quantidadeA++;
            //    somaNotas += nota;
            //    if (nota > compareNotaAlta)
            //    {
            //        compareNotaAlta = nota;
            //    }
            //    else if (nota < compareNotaBaixa && nota >=0)
            //    {
            //        compareNotaBaixa = nota;
            //    }
            //    if (compareNotaBaixa == 0)
            //    {
            //        compareNotaBaixa = nota;
            //    }
            //}
            //mediaNotas = somaNotas / quantidadeA;

            //Console.WriteLine("A nota mais alta foi "+compareNotaAlta+" pontos.\n" +
            //    "A nota mais baixa foi "+compareNotaBaixa+" pontos.\n" +
            //    "A média aritimética da turma foi "+mediaNotas
            //    +" pontos.\nO número de launos é "+quantidadeA);

            //Exercício 12
            //Apresentar o total da soma dos cem primeiros números inteiros.

            //int numero = 1, soma = 0;

            //for (int i = 2; i <= 100 ; i++)
            //{
            //    if (soma == 0)
            //    {
            //        soma = numero + i;
            //    }
            //    soma += i;
            //}

            //Console.WriteLine("O total da soma dos cem primeiros números é " + soma);

            //Exercício 13
            //Elaborar um programa que apresente o somatório dos valores pares existentes entre 1 e 500.

            //int soma = 0;  

            //for (int i = 2; i < 500; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        soma += i;
            //    }
            //}   
            //Console.WriteLine("A soma dos números pares é "+soma);

            //Exercício 14
            //Mostrar as potências de 2 variando de 0 a 10.


            //int potencia = 1, numero = 2;

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (potencia == 1)
            //    {
            //        Console.WriteLine("2 elevado a 0 = " + potencia);
            //    }
            //    potencia = potencia * numero;
            //    Console.WriteLine("2 elevado a " + i + " = " + potencia);
            //}

            //Exercício 15
            /*Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
            ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
            Considerar nota 7,0 como mínima para aprovação.*/

            //double nota = 0, soma = 0, media = 0, peso2 = 0, peso4 = 0, peso1 = 0;

            //for (int i = 1; i <= 4; i++)
            //{
            //    Console.Write("Digite a " + i + "º nota: ");
            //    nota = double.Parse(Console.ReadLine());
            //    if (i == 1 || i == 3)
            //    {
            //        peso2 = nota * 2;
            //        soma += peso2;
            //    }
            //    else if (i == 4)
            //    {
            //        peso4 = nota * 4;
            //        soma += peso4;
            //    }
            //    else
            //    {
            //        peso1 = nota;
            //        soma += peso1;
            //    }
            //}
            //media = soma / 4;
            //if (media >= 7.0)
            //{
            //    Console.WriteLine("A média é "+media+" pontos.\nAprovado!");
            //}
            //else
            //{
            //    Console.WriteLine("A média é " + media + " pontos.\nReprovado!");
            //}

            //Exercício 16
            /*Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
            multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
            (N*3; N*3*3; N*3*3*3; etc).*/

            //double n = 0, produto = 0;

            //while (n > 50 || n == 0)
            //{
            //    Console.WriteLine("Digite um número qualquer menor que 50: ");
            //    n = double.Parse(Console.ReadLine());
            //}
            //do
            //{
            //    if (n * 3 > 250)
            //    {
            //        break;
            //    }
            //    n = n * 3;
            //} while (n < 250);

            //Console.Write("O resultado é "+n);

            //Exercício 17
            //Apresentar os quadrados dos números inteiros de 15 a 200.

            //for (int i = 15; i <= 200; i++)
            //{
            //    double quadrado = i * i;
            //    Console.WriteLine(i + " ao quadrado = "+quadrado);
            //}

            //Exercício 18
            /*Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
            elevada a um expoente qualquer, ou seja, NM.*/


            //Console.Write("Digite a base: ");
            //double nBase = double.Parse(Console.ReadLine());
            //Console.Write("Digite o expoente: ");
            //double expoente = double.Parse(Console.ReadLine());

            //double potencia = 1;


            //for (int i = 0; i < expoente; i++)
            //{
            //    potencia = potencia * nBase;
            //}
            //Console.WriteLine("O resultado é: "+potencia);

            //Exercício 19
            /*A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
            coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 

            a) média do salário da população;
            b) média do número de filhos;
            c) maior salário;
            d) percentual de pessoas com salário até R$ 100,00.
            O final da leitura de dados se dará com a entrada de um salário negativo.*/

            //double salario = 0, nFilhos = 0, somaS = 0, somaF = 0, salarioA = 0, menos100 = 0, mediaF, mediaS, populacao = 0;
            //double porcentagem;

            //for (int i = 1;; i++)
            //{
            //    Console.Write("Digite o salário do " + i + "º habitante: ");
            //    salario = int.Parse(Console.ReadLine());
            //    if (salario < 0)
            //    {
            //        break;
            //    }
            //    Console.Write("Digite a quantidade de filhos do " + i + "º habitante: ");
            //    nFilhos = int.Parse(Console.ReadLine());

            //    somaS = somaS + salario;
            //    somaF = somaF + nFilhos;
            //    populacao++;

            //    if (salario > salarioA)
            //    {
            //        salarioA = salario;
            //    }
            //    if (salario < 100)
            //    {
            //        menos100++;
            //    }
            //}
            //mediaS = somaS / populacao;
            //mediaF = somaF / populacao;
            //porcentagem = menos100 / populacao;
            //Console.WriteLine("A média do salário da população é: " + mediaS +
            //    "\nA média do número de filhos é: " + mediaF +
            //    "\nO maior salário é: " + salarioA +
            //    "\nO percentual de pessoas com salário até R$ 100,00 é: " +porcentagem.ToString().Substring(2, 2)+"%");

            //Exercício 20
            /*Foi realizada uma pesquisa de algumas características físicas da população de uma 
            certa região, a qual coletou os seguintes dados referentes a cada habitante para 
            serem analisados:
            - sexo (masculino e feminino)
            - cor dos olhos (azuis, verdes ou castanhos)
            - cor dos cabelos ( louros, castanhos, pretos)
            - idade 

            Faça um algoritmo que determine e escreva: 

            - a maior idade dos habitantes
            - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
            e que tenham olhos verdes e cabelos louros.
            O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.*/

            //string sexo = "", olho = "", cabelo = "";
            //int idade = 0, cont1 = 0, mIdade = 0;

            //while (idade != -1)
            //{
            //    Console.Write("Digite o sexo: ");
            //    sexo = Console.ReadLine();
            //    Console.Write("Digite a cor dos olhos (azuis, verdes ou castanhos): ");
            //    olho = Console.ReadLine();
            //    Console.Write("Digite a cor dos cabelos ( louros, castanhos ou pretos): ");
            //    cabelo = Console.ReadLine();
            //    Console.WriteLine("Qual a idade: ");
            //    idade = int.Parse(Console.ReadLine());

            //    if (mIdade == 0)
            //    {
            //        mIdade = idade;
            //    }else if(idade > mIdade)
            //    {
            //        mIdade = idade;
            //    }

            //    if (sexo == "feminino" && olho == "verdes" && idade > 18 && idade < 35 && cabelo == "louros")
            //    {
            //        cont1++;
            //    }
            //}
            //Console.WriteLine("A maior idade dos habitantes é "+mIdade+" anos.");
            //Console.WriteLine("A quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos e que tem olhos verdes e cabelos louros é "+cont1+".");

















        }
    }
}