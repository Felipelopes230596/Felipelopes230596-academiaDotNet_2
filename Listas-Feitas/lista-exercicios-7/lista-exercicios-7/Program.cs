using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace lista_exercicios_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01
            /*Crie uma classe Livro que represente os dados básicos de um livro. 
             Faça a leitura pelo teclado dos atributos e crie um construtor para fazer o instanciamento.*/

            //string nome, autor, genero;

            //Console.WriteLine("Digite o nome do livro: ");
            //nome = Console.ReadLine();
            //Console.WriteLine("DIgite o nome do autor: ");
            //autor = Console.ReadLine();
            //Console.WriteLine("DIgite o gênero do livro: ");
            //genero = Console.ReadLine();

            //Livro livro = new Livro(nome, autor, genero);

            //livro.exibeInfo();

            //Exercício 02
            /*Escreva uma classe Pessoa contendo todos os atributos de uma pessoa. Faça métodos para apresentar os dados.
             * Faça a leitura pelo teclado dos atributos e crie um construtor para fazer o instanciamento.*/

            //Console.WriteLine("Escreva o nome da pessoa: ");
            //string n = Console.ReadLine();
            //Console.WriteLine("Escreva o gênero da pessoa: ");
            //string g = Console.ReadLine();
            //Console.WriteLine("Escreva a idade da pessoa: ");
            //int i = int.Parse(Console.ReadLine());
            //Console.WriteLine("Escreva a altura da pessoa: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Escreva o peso da pessoa: ");
            //double p = double.Parse(Console.ReadLine());

            //Pessoa pessoa = new Pessoa(n, g, i, a, p);

            //pessoa.exibeInfo();

            //Exercício 03 
            /*Faça um programa para controlar o aluguel de carros. Deve ter as classes Carro, aluguel e cliente.*/

            //string nome, endereco, dataNascimento;

            //Aluguel aluguel = new Aluguel();  
            //Carro carro = new Carro();
            //Cliente cliente = new Cliente();                   


            //Console.WriteLine("Seja bem vindo a Loca-Auto, siga os passos a baixo para alugar o seu veículo\nDigite o seu nome: ");
            //nome= Console.ReadLine();

            //Console.WriteLine("Digite a data de nascimento: ");
            //dataNascimento= Console.ReadLine();

            //Console.WriteLine("Digite o seu endereço: ");
            //endereco= Console.ReadLine();   
            //cliente.getDadosCliente(nome, endereco, dataNascimento);

            //Console.WriteLine("Digite a categoria desejada.\n1 - SUV\n2 - HATCH\n3 - SEDAN");
            //carro.setCategoria(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Digite quantas diárias necessita:");
            //aluguel.quantidadeDiarias = (int.Parse(Console.ReadLine())) ;

            //Console.WriteLine("´Sr(a) "+nome+" o seu véiculo é um "+carro.marca+" "+carro.modelo+" "+carro.motor+", o valor da diária é R$"+carro.diaria+" e o total ficará R$"+(carro.diaria*aluguel.quantidadeDiarias)+".");

            //Exercício 04
            /*Faça um programa que represente a arvore genealógica da tua familia. 
            Para isso, uma classe Pessoa precisa ser indicar quem são seus pais, alem de informações básicas sobre a pessoa.*/

            //Familia filho = new Familia();
            //filho.idade = 15;
            //filho.nome = "Felipe";

            //Familia mae = new Familia();
            //mae.idade = 48;
            //mae.nome = "Sonia";

            //Familia pai = new Familia();
            //pai.idade = 52;
            //pai.nome = "Pedro";

            //Familia avoPai = new Familia();
            //avoPai.idade = 72;
            //avoPai.nome = "João";


            //Exercício 05
            /*Identifique as classes e implemente um programa para a seguinte especificação: "O	supermercado vende diferentes tipos de produtos. 
            Cada produto tem um preço e uma quantidade em estoque. Um pedido de um cliente é composto de itens,	onde cada item especifica o	produto	que	o cliente deseja e a respectiva	quantidade.
            Esse pedido	pode ser pago em dinheiro, cheque ou cartão."*/

            //Produtos p1 = new Produtos();
            //p1.produto = "Pão de Forma";
            //p1.preco = 3.50;
            //p1.quantidadeEstoque = 30;

            //Produtos p2 = new Produtos();
            //p2.produto = "Leite";
            //p2.preco = 4.80;
            //p2.quantidadeEstoque = 20;

            //Produtos p3 = new Produtos();
            //p3.produto = "Requeijão";
            //p3.preco = 7.50;
            //p3.quantidadeEstoque = 40;

            //Pedido pd1 = new Pedido();
            //pd1.produto = "Pão de Forma";
            //pd1.quantidade = 2;

            //Pedido pd2 = new Pedido();
            //pd2.produto = "Leite";
            //pd2.quantidade = 3;

            //Pedido pd3 = new Pedido();
            //pd3.produto = "Requeijão";
            //pd3.quantidade = 1;

            //double total = (p1.preco * pd1.quantidade) + (p2.preco * pd2.quantidade) + (p3.preco * pd3.quantidade);

            //Pedido fPag = new Pedido();
            //fPag.formaPagamento = "dinheiro";
            //fPag.dinheiro = 50;
            //Console.WriteLine("A lista de compras ficou:\nItem          Qtd. Preco unid.\n" + pd1.produto + " | " + pd1.quantidade + " | R$" + p1.preco +
            //    "\n" + pd2.produto + "        | " + pd2.quantidade + " | R$" + p2.preco + "\n" + pd3.produto + "    | " + pd3.quantidade + " | R$" + p3.preco +
            //    "\n\nTotal: R$" + total);
            //Console.WriteLine("-----------------------------");

            //Console.WriteLine("\nForma de pagamento: "+ fPag.formaPagamento +"\nTroco para R$" + fPag.dinheiro + "\nDevolver troco de R$" + (fPag.dinheiro - total));


            //Exercício 06 
            /*Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes operações:
            void armazenaPessoa(String nome, int idade, float altura);
            void removePessoa(String nome);
            Pessoa buscaPessoa(String nome);retorna a pessoa com o nome informado
            void imprimeAgenda();imprime os dados de todas as pessoas da agenda*/

            //Agenda agenda = new Agenda();
            //int opcao = 1;
            //int idade = 0;
            //string nome = "";
            //float altura = 0;

            //while (opcao != 0)
            //{
            //    Console.WriteLine("Menu\n1 - Imprimir agenda\n2 - Cadastrar novo nome\n3 - Exluir um nome\n4 - Pesquisar\n0 - sair");
            //    opcao = int.Parse(Console.ReadLine());

            //    switch (opcao)
            //    {
            //        case 1:
            //            agenda.imprimeAgenda();
            //            break;
            //        case 2:
            //            Console.WriteLine("Digite o nome que deseja cadastrar: ");
            //            nome = Console.ReadLine();
            //            Console.WriteLine("Digite a idade: ");
            //            idade = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Digite a altura: ");
            //            altura = float.Parse(Console.ReadLine());
            //            agenda.armazenaPessoa(nome, idade, altura);
            //            break;
            //        case 3:
            //            Console.WriteLine("Digite o nome que deseja excuir");
            //            agenda.removePessoa(Console.ReadLine());
            //            break;
            //        case 4:
            //            Console.WriteLine("Digite o nome que deseja consultar: ");
            //            agenda.buscaPessoa(Console.ReadLine());
            //            break;
            //        case 0: return;

            //        default:
            //            break;
            //    }
            //}

            //Exercício 07
            /*Crie uma classe denominada Elevador para armazenar as informações de um elevador dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), 
            total de andares no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão presentes nele. A classe deve também disponibilizar os seguintes métodos:
            Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no térreo e vazio);
            Entra : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);
            Sai : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);
            Sobe : para subir um andar (não deve subir se já estiver no último andar);
            Desce : para descer um andar (não deve descer se já estiver no térreo);
            Encapsular todos os atributos da classe (criar os métodos set e get).*/

            //Elevador elevador = new Elevador();
            //int capacidade, totalAndares;

            //Console.WriteLine("Digite quantos andares tem o prédio e qual capacidade de pessoas:");
            //capacidade = int.Parse(Console.ReadLine());
            //totalAndares = int.Parse(Console.ReadLine());
            //elevador.setInicializa(capacidade, totalAndares);

            //int opcao = 1;
            //while (opcao != 0)
            //{

            //    Console.WriteLine("Menu\n1 - Entra\n2 - Sai\n3 - Sobe\n4 - Desce\n0 - Finalizar");
            //    opcao = int.Parse(Console.ReadLine());
            //    switch (opcao)
            //    {
            //        case 1:
            //            elevador.entra();
            //            break;
            //            case 2:
            //            elevador.sai();
            //            break;
            //        case 3:
            //            elevador.sobe();
            //            break;
            //        case 4:
            //            elevador.desce();
            //            break;
            //    }
            //}

            //Exercício 08
            /*Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume e trocar os canais da televisão. O controle de volume permite:
            - aumentar ou diminuir a potência do volume de som em uma unidade de cada vez;
            - aumentar e diminuir o número do canal em uma unidade
            - trocar para um canal indicado;
            - consultar o valor do volume de som e o canal selecionado.*/

            //Televisao televisao = new Televisao();
            //ControleRemoto controleRemoto = new ControleRemoto();   

            //string opcao = "1";
            //while (opcao !="0")
            //{

            //    Console.WriteLine("Menu\n+ Volume\n- Volume\n1 - Mudar canal\n2 - Ver canal atual\n3 - Ver volume atual\n0 - Finalizar");
            //    opcao = Console.ReadLine();
            //    switch (opcao)
            //    {
            //        case "+":
            //            controleRemoto.volumeMais(televisao);
            //            break;
            //        case "-":
            //            controleRemoto.volumeMenos(televisao);
            //            break;
            //        case "1":
            //            Console.WriteLine("Digite o canal desejado: ");
            //            controleRemoto.trocaCanal(int.Parse(Console.ReadLine()),televisao);
            //            break;
            //            case"2":
            //            Console.WriteLine("O canal atual é o "+televisao.getCanal());
            //            break;
            //            case"3":
            //            Console.WriteLine("O volume atual é "+televisao.getVolume());
            //            break;
            //        case "0":
            //            return;
            //    }
            //}









        }
    }
}