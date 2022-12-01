using System.Security.Cryptography.X509Certificates;

namespace lista_exercicios_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 02
            /*2. Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
            Os emails digitados devem ser cadastrados em uma lista e depois em um arquivo .csv e não pode haver emails duplicados, 
            ou seja, o programa deve controlar essa situação. Quando o usuário solicitar a listagem dos emails, além dessa
            lista, o programa deve listar os domínios de emails cadastrados no programa.*/

            //Utilidade util = new Utilidade();
            List<Utilidade> lista = new List<Utilidade>();
            Utilidade.populaListaEmail(lista, "listaEmail.csv");
            
            int op = 0;
            do
            {
                Console.Write("Menu\r\n1 - Cadastrar email\r\n2 - Listar \r\n3 - Sair \r\nOpção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        break;
                    default:
                        break;
                }
            } while (op != 3);








            //Exercicio 03
            /*Fazer um programa em VS para gerenciar figurinhas da copa. O programa deve possuir um Menu 

            Menu
            1 - Cadastrar figurinha repetida
            2 - Cadastrar figurinha faltante
            3 - Listar figurinhas repetidas
            4 - Listar figurinhas faltantes
            5 - Sair
            Opção:

            Para este programa, usar a classe Figurinha (codigo_figurinha, selecao, nome_jogador), lista que armazena as figurinhas em memória,
            arquivo .csv com os dados das figurinhas persistidos em disco.

            Para as figurinhas repetidas, deve haver uma lista e um arquivo .csv; o mesmo para as figurinhas faltantes. Toda vez que as opções 3 ou 4 foram selecionadas,
            além da listagem na tela, gerar um arquivo de saída com os mesmos dados da tela. Esse arquivo é o utilizado para mandar aos amigos.


            nos arquivos .csv. Por exemplo, arquivo de figurinhas repetidas, repetidas.csv

            codigo figurinha;seleçao;nome do jogador 
            codigo figurinha;seleçao;nome do jogador 
            codigo figurinha;seleçao;nome do jogador 
            codigo figurinha;seleçao;nome do jogador 
            codigo figurinha;seleçao;nome do jogador */

            //List<Figurinha> listaRepetidas = new List<Figurinha>();
            //List<Figurinha> listaFaltantes = new List<Figurinha>();


            //void cadastrarFigurinhaRepetida()
            //{
            //    string codigo;
            //    string selecao;
            //    string jogador;

            //    Console.Write("Cadastrando Figurinha repetida\nDigite os dados:\nCódigo da figurinha: ");
            //    codigo = Console.ReadLine().ToUpper();

            //    Console.WriteLine("Seleção: ");
            //    selecao = Console.ReadLine().ToUpper();

            //    Console.WriteLine("Nome do jogador: ");
            //    jogador = Console.ReadLine().ToUpper();

            //    Figurinha figurinha = new Figurinha(codigo, selecao, jogador);

            //    if (Util.jaNaListaFigurinha(figurinha, listaRepetidas))
            //    {
            //        Console.WriteLine("Figurinha já cadastrada!");
            //    }
            //    else
            //    {
            //        listaRepetidas.Add(figurinha);
            //        Util.gravarFigurinhaArquivo(figurinha, "repetidas.csv");
            //    }

            //}

            //Util.popularArquivoNaListaFigurinha(listaRepetidas, "repetidas.csv");
            //Util.popularArquivoNaListaFigurinha(listaFaltantes, "faltantes.csv");

            //int op = 0;
            //string codFigurinha;
            //string selecao;
            //string nomeJogador;
            //while (op != 5)
            //{
            //    Console.WriteLine("Menu\n1 - Cadastrar figurinha repetida\n2 - Cadastrar figurinha faltante\n3 - Listar figurinhas repetidas\n4 - Listar figurinhas faltantes\n5 - Sair");
            //    op = int.Parse(Console.ReadLine());
            //    switch (op)
            //    {
            //        case 1:
            //            cadastrarFigurinhaRepetida();
            //            break;
            //        case 2:
            //            break;
            //        case 3:
            //            Util.mostrarListaFigurinhas(listaRepetidas, "minhasRepetidas.txt", "Repetidas" );
            //            break;
            //        default:
            //            Console.WriteLine("Opção inválida!");
            //            break;
            //    }
            //}


        }
    }
}