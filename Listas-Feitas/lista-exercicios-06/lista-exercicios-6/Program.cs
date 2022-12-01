using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace lista_exercicios_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01
            /*Fazer um programa em VS que popule uma lista de nomes, com nomes completos obrigatoriamente.
            Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no mínimo duas palavras e 
            que não esteja na lista. Ao final, caso o nome não esteja na lista, cadastra-lo em maiúsculo e 
            exibir a lista ordenada.*/

            //List<string> nomeCompleto = new List<string>();
            //string nome;

            //do
            //{
            //    Console.WriteLine("Digite o nome completo ou sair: ");
            //    nome = Console.ReadLine().ToUpper();

            //    if (nome.Contains(" "))
            //    {
            //        if (nomeCompleto.Contains(nome))
            //        {
            //            Console.WriteLine("Nome duplicado!");
            //        }
            //        else
            //        {
            //            nomeCompleto.Add(nome);
            //        }
            //    }
            //    else if (nome == "SAIR")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nome incorreto!");
            //    }
            //} while (true);

            //Console.WriteLine("Essa é a lista completa");
            //foreach (var item in nomeCompleto)
            //{
            //    Console.WriteLine(item);
            //}

            //Exercício 02
            /*Fazer um programa em VS que popule uma lista com números inteiros (0 a 1000) que sejam sorteados
            randomicamente. O programa deve pedir ao usuário quantos números deseja armazenar. Ao final, o programa
            deve exibir os números populados na lista.*/

            //List<int> lista = new List<int>();
            //Random numeros = new Random();

            //Console.WriteLine("Quantos números deseja armazenar na lista? ");
            //int quantidade = int.Parse(Console.ReadLine());

            //while (lista.Count < quantidade)
            //{
            //    lista.Add(numeros.Next(0, 1000));
            //}
            //Console.WriteLine("Esses são os números digitado: ");
            //foreach (int i in lista)
            //{
            //    Console.WriteLine(i);
            //}

            //Exercício 03
            /*Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
            Os emails digitados devem ser cadastrados em uma lista e não pode haver emails duplicados, ou seja,
            o programa deve controlar essa situação. Quando o usuário solicitar a listagem dos emails, além dessa
            lista, o programa deve listar os domínios de emails cadastrados no programa.*/

            //List<string> lista = new List<string>();
            //int opcaoMenu;

            //do
            //{
            //    Console.WriteLine("Menu\n1 - Cadastrar email\n2 - Listar\n3 - Sair\nDigite a opção desejada: ");
            //    opcaoMenu = int.Parse(Console.ReadLine());
            //    if (opcaoMenu == 1)
            //    {
            //        Console.WriteLine("Digite o email: ");
            //        lista.Add(Console.ReadLine());
            //    }else if (opcaoMenu == 2)
            //    {
            //        Console.WriteLine("Os emails cadastrados são: \n");
            //        foreach (string i in lista)
            //        {
            //            Console.WriteLine(i);
            //            string[] email = i.Split("@");
            //            Console.WriteLine("Domínio: " + email[1]+"\n");
            //        }
            //    }else if (opcaoMenu == 3)
            //    {
            //        break;
            //    }
            //} while (true);

            //Exercício 04
            /*Fazer um programa em VS que realize um CRUD (inserir, pesquisar, atualizar e deletar) 
            completo em uma lista de nomes de criptomoedas. Neste programa, somente o nome da criptomoeda deve 
            ser cadastrado (em maiúsculo). Ao cadastrar, não pode haver duplicidade de dados na lista. Sempre
            que a opção listar for acionada, a listagem deve ser exibida de forma ordenada. No processo de 
            remoção, o usuário entra com o nome da criptomoeda que deseja remover. Caso o programa a encontre,
            deve remover e avisar o usuário que a operação ocorreu corretamente, e caso não a encontre, avisar
            ao usuário que nome não foi encontrado.*/

            //List<string> lista = new List<string>();
            //int menu;

            //do
            //{
            //    Console.WriteLine("Menu \n1 - Cadastrar criptomoeda \n2 - Listar criptomoedas \n3 - Remover criptomoeda \n4 - Sair \nOpção: ");
            //    menu = int.Parse(Console.ReadLine());
            //    if (menu == 1)
            //    {
            //        Console.WriteLine("Digite a moeda que deseja cadastrar: ");
            //        string moeda = Console.ReadLine().ToUpper();

            //        if (lista.Contains(moeda))
            //        {
            //            Console.WriteLine("Moeda já existente!");
            //        }
            //        else
            //        {
            //            lista.Add(moeda);
            //        }
            //    }
            //    else if (menu == 2)
            //    {
            //        Console.WriteLine("Essas são as criptomoedas cadastradas: ");
            //        foreach (var item in lista)
            //        {
            //            Console.WriteLine(item);
            //        }
            //    }
            //    else if (menu == 3)
            //    {
            //        Console.WriteLine("Digite a moeda que deseja remover: ");
            //        string moeda = Console.ReadLine().ToUpper();

            //        if (lista.Contains(moeda))
            //        {
            //            lista.Remove(moeda);
            //            Console.WriteLine("Removido com sucesso!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Moeda digitada não existe na lista!");
            //        }

            //    }
            //    else if (menu == 4)
            //    {
            //        break;
            //    }
            //} while (true);

            //Exercício 05
            /*Crie um programa em VS que popule duas listas (lista1 e lista2) com números aleatórios (100 a 200).
            A quantidade de números deve ser informada pelo usuário.Em seguida, o programa deve listar os
            conteúdos das duas listas e exibir os números que aparecem em ambas as listas.*/

            //List<int> lista1 = new List<int>(), lista2 = new List<int>();

            //Random random = new Random();

            //Console.WriteLine("Digite quantos números desaja:");
            //int quantidade = int.Parse(Console.ReadLine());

            //for (int i = 0; i < quantidade; i++)
            //{
            //    lista1.Add(random.Next(100, 200));
            //    lista2.Add(random.Next(100, 200));
            //}

            //Console.WriteLine("Conteúdo lista 1");
            //foreach (var item in lista1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Conteúdo lista 2");
            //foreach (var item in lista2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Esses são os números contidos em ambas as listas:");
            //foreach (int i in lista1)
            //{
            //    if (lista2.Contains(i))
            //    {                    
            //        Console.WriteLine(i);
            //    }
            //}

            //Exercício 06
            /*Continuação do exercício 1. Entretanto, quando listar os nomes, mostrar somente os sobrenomes.
            Além disso, o programa deve mostrar as pessoas que são da mesma família.*/

            //List<string> nomeCompleto = new List<string>();
            //List<string> familia = new List<string>();
            //string nome;

            //do
            //{
            //    Console.WriteLine("Digite o nome completo ou sair: ");
            //    nome = Console.ReadLine().ToUpper();

            //    if (nome.Contains(" "))
            //    {
            //        if (nomeCompleto.Contains(nome))
            //        {
            //            Console.WriteLine("Nome duplicado!");
            //        }
            //        else
            //        {
            //            nomeCompleto.Add(nome);
            //        }
            //    }
            //    else if (nome == "SAIR")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nome incorreto!");
            //    }
            //} while (true);

            
            //foreach (var item in nomeCompleto)
            //{
            //    string[] sobrenome = item.Split(" ");
            //    Console.WriteLine(sobrenome[1]);
            //}

            //foreach (var item in nomeCompleto)
            //{
            //    string[] sobrenomes = item.Split(" ");
  
            //    familia.AddRange(nomeCompleto.Where(pessoa => pessoa.Contains(sobrenomes[1]) && pessoa != item).ToList());
            //     // 

            //}
            //Console.WriteLine("repetidos: ");
            //familia.ForEach(i => Console.WriteLine("{0}\t", i));














        }
    }
}