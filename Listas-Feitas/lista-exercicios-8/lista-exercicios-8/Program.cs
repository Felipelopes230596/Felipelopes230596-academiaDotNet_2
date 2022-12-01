namespace lista_exercicios_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01
            /*Implemente um programa em C# no qual o usuário deverá informar o nome e o poder (0 a 10) de três personagens. 
            O programa deverá informar o nome do personagem que possuir o maior poder.

            Regras que deverão ser seguidas para a implementação do algoritmo:

            É obrigatório o uso de classe para representar um Personagem e a mesma deverá possuir como propriedades (características) um nome e um poder.
            A classe também deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e o poder do personagem em questão.
            Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que 
            irá receber o nome e o poder de um personagem*/

            //string nome;
            //int poder;
            //Personagem p1;
            //Personagem p2;
            //Personagem p3;

            //Console.WriteLine("Digite o nome do personagem 1: ");
            //nome = Console.ReadLine();
            //Console.WriteLine("Digite o poder entre 0 e 10: ");
            //poder = int.Parse(Console.ReadLine());
            //while (poder < 0 || poder > 10)
            //{
            //        Console.WriteLine("O poder tem que ser de 0 a 10.\nDigite novamente:");
            //        poder = int.Parse(Console.ReadLine());
            //}
            //p1 = new Personagem(nome, poder);

            //Console.WriteLine("Digite o nome do personagem 2: ");
            //nome = Console.ReadLine();
            //Console.WriteLine("Digite o poder entre 0 e 10: ");
            //poder = int.Parse(Console.ReadLine());
            //while (poder < 0 || poder > 10)
            //{
            //        Console.WriteLine("O poder tem que ser de 0 a 10.\nDigite novamente:");
            //        poder = int.Parse(Console.ReadLine());
            //}
            //p2 = new Personagem(nome, poder);

            //Console.WriteLine("Digite o nome do personagem 3: ");
            //nome = Console.ReadLine();
            //Console.WriteLine("Digite o poder entre 0 e 10: ");
            //poder = int.Parse(Console.ReadLine());
            //while (poder < 0 || poder > 10)
            //{              
            //        Console.WriteLine("O poder tem que ser de 0 a 10.\nDigite novamente:");
            //        poder = int.Parse(Console.ReadLine());            
            //}
            //p3 = new Personagem(nome, poder);

            //Console.WriteLine("Dados personagens:");
            //p1.ExibirDados();
            //p2.ExibirDados();
            //p3.ExibirDados();

            //if (p1.getPoder() > p2.getPoder() && p1.getPoder() > p3.getPoder())
            //{
            //    Console.WriteLine(p1.getNome() + " é o mais poderoso!");
            //}
            //else if (p2.getPoder() > p1.getPoder() && p2.getPoder() > p3.getPoder())
            //{
            //    Console.WriteLine(p2.getNome() + " é o mais poderoso!");
            //}
            //else
            //{
            //    Console.WriteLine(p3.getNome() + " é o mais poderoso!");
            //}

            //Exercício 02
            /*Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
            O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

            Regras que deverão ser seguidas para a implementação do programa:

            Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
            Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
            É obrigatório criar uma classe para representar o Animal.
            A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
            A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).*/

            //Animal a1 = new Animal();
            //Animal a2 = new Animal();
            //Animal a3 = new Animal();
            //Animal a4 = new Animal();
            //Animal a5 = new Animal();

            //int cachorro = 0;
            //int gato = 0;
            //int peixe = 0;

            //Console.WriteLine("Digite o nome do animal 1:");
            //a1.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o tipo, gato, cachorro ou peixe");
            //a1.Tipo = Console.ReadLine();
            //while (a1.Tipo != "gato" && a1.Tipo != "cachorro" && a1.Tipo != "peixe")
            //{
            //    Console.WriteLine("Tipo inválido, digite novamente:");
            //    a1.Tipo = Console.ReadLine();
            //}
            //if (a1.Tipo == "peixe" )
            //{
            //    peixe++;
            //}else if (a1.Tipo == "gato")
            //{
            //    gato++;
            //}
            //else 
            //{
            //    cachorro++;
            //}

            //Console.WriteLine("Digite o nome do animal 2:");
            //a2.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o tipo, gato, cachorro ou peixe");
            //a2.Tipo = Console.ReadLine();
            //while (a2.Tipo != "gato" && a2.Tipo != "cachorro" && a2.Tipo != "peixe")
            //{
            //    Console.WriteLine("Tipo inválido, digite novamente:");
            //    a2.Tipo = Console.ReadLine();
            //}
            //if (a2.Tipo == "peixe")
            //{
            //    peixe++;
            //}
            //else if (a2.Tipo == "gato")
            //{
            //    gato++;
            //}
            //else 
            //{
            //    cachorro++;
            //}

            //Console.WriteLine("Digite o nome do animal 3:");
            //a3.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o tipo, gato, cachorro ou peixe");
            //a3.Tipo = Console.ReadLine();
            //while (a3.Tipo != "gato" && a3.Tipo != "cachorro" && a3.Tipo != "peixe")
            //{
            //    Console.WriteLine("Tipo inválido, digite novamente:");
            //    a3.Tipo = Console.ReadLine();
            //}
            //if (a3.Tipo == "peixe")
            //{
            //    peixe++;
            //}
            //else if (a3.Tipo == "gato")
            //{
            //    gato++;
            //}
            //else 
            //{
            //    cachorro++;
            //}

            //Console.WriteLine("Digite o nome do animal 4:");
            //a4.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o tipo, gato, cachorro ou peixe");
            //a4.Tipo = Console.ReadLine();
            //while (a4.Tipo != "gato" && a4.Tipo != "cachorro" && a4.Tipo != "peixe")
            //{
            //    Console.WriteLine("Tipo inválido, digite novamente:");
            //    a4.Tipo = Console.ReadLine();
            //}
            //if (a4.Tipo == "peixe")
            //{
            //    peixe++;
            //}
            //else if (a4.Tipo == "gato")
            //{
            //    gato++;
            //}
            //else 
            //{
            //    cachorro++;
            //}

            //Console.WriteLine("Digite o nome do animal 5:");
            //a5.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o tipo, gato, cachorro ou peixe");
            //a5.Tipo = Console.ReadLine();
            //while (a5.Tipo != "gato" && a5.Tipo != "cachorro" && a5.Tipo != "peixe")
            //{
            //    Console.WriteLine("Tipo inválido, digite novamente:");
            //    a5.Tipo = Console.ReadLine();
            //}
            //if (a5.Tipo == "peixe")
            //{
            //    peixe++;
            //}
            //else if (a5.Tipo == "gato")
            //{
            //    gato++;
            //}
            //else 
            //{
            //    cachorro++;
            //}
            //Console.WriteLine("Foram digitados:\n"+cachorro+" cachorro.\n"+gato+" gato.\n"+peixe+" peixe.");

            //Exercício 03
            /*Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que represente
            uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
            um plano cartesiano), tamanho do asteroide (1 a 10), velocidade do asteroide (1 a 5) e energia (1 a 5). Para esses atributos privados, gerar os métodos de acesso
            (propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo Asteroide, e um 
            terceiro que constrói um asteroide com posição x e posição y. 
            O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal, construir um método de classe que exiba todos os
            asteróides da lista.*/

            //List<Asteroides> lista = new List<Asteroides>();

            //int op = 0, contador = 1;

            //Console.WriteLine("Vamos preencher uma lista de asteróides.");
            //while (op != 1)
            //{
            //    Asteroides asteroide = new Asteroides();

            //    Console.WriteLine("Asteroide número "+contador);
            //    Console.WriteLine("Digite a posição X");
            //    asteroide.PosicaoX = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite a posição Y");
            //    asteroide.PosicaoY = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite o tamanho (1 a 10):");
            //    asteroide.Tamanho = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite a velocidade (1 a 5)");
            //    asteroide.Veelocidade = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite a energia (1 a 5)");
            //    asteroide.Energia = int.Parse(Console.ReadLine());

            //    lista.Add(asteroide);

            //    Console.WriteLine("Deseja adicionar mais um asteroid?\n0 - Sim\n1 - Não");
            //    op = int.Parse(Console.ReadLine());

            //    contador++;
            //}
            //foreach (var item in lista)
            //{
            //Console.WriteLine("Posição X: {0} \nPosição Y: {1} \nTamanho: {2} \nVelocidade: {3} Mph \nEnergia: {4}", item.PosicaoX, item.PosicaoY, item.Tamanho, item.Veelocidade, item.Energia );

            //}

            //Exercício 04 
            /*Crie uma classe para representar um item de cenário, com os atributos privados de:
            * descrição (string), 
            * data de criação (date) e
            * altura (float). 

            Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
            todos dados de um item de cenário. 
            Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
            a classe criada.*/

            //Console.WriteLine("Digite a descrição do item:");
            //string descricao = Console.ReadLine();

            //Console.WriteLine("Digite a altura:");
            //float altura = float.Parse(Console.ReadLine());

            //Cenario cenario = new Cenario(descricao, DateTime.Now , altura);

            //cenario.imprimirDados();

            //cenario.calcular();

            //Exercício 05
            /*Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
            tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
            um método para exibir um objeto (x,y).
            Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
            os objetos da lista.*/

            //List<ClassXY> list = new List<ClassXY>();

            //int op = 0;

            //while (op != 1)
            //{
            //    Console.WriteLine("Digite o valor de X:");
            //    int x = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite o valor de Y:");
            //    int y = int.Parse(Console.ReadLine());

            //    ClassXY classe = new ClassXY(x,y);

            //    classe.exibeDados();    

            //    list.Add(classe);

            //    Console.WriteLine("Deseja adicionar mais objetos?\n0 - Sim\n1 - Não");
            //    op = int.Parse(Console.ReadLine());
            //}

            //int i = 1;

            //foreach (var item in list)
            //{
            //    Console.WriteLine($"Objeto {i}: ({item.X}, {item.Y})");
            //}

            //Exercício 06
            /*Crie uma classe para funcionário. Ele deve ter o nome do funcionário, o departamento onde trabalha, seu salário (double), a data de entrada no banco (String), seu RG (String) e 
            um valor booleano que indique se o funcionário ainda está ativa na empresa no momento ou se já foi mandado embora.
            Você deve criar alguns métodos de acordo com sua necessidade. Além deles, crie um método bonifica que aumenta o salario do funcionário de acordo com o parâmetro passado como argumento. Crie, também, um
            método demite, que não recebe parâmetro algum, só modifica o valor booleano indicando que o funcionário não trabalha mais aqui.
            Crie uma lista de funcionários e faça um menu iterativo onde você pode inserir e consultar todos os funcionários cadastratos.

            Utilizando o exercício anterior, faça um método abstrato na classe funcionário chamado "ExecutaTrabalho". Haverá duas implementações da classe Funcionario chamada de Gerente e Operador. 
            Nos metodos de cada uma das classes Gerente e Operador deverá aparecer a mensagem informando qual é a função desempenhada pelo funcionário*/

            List<Funcionario> lista = new List<Funcionario>();
            int op = -1;
            while (op !=0)
            {
                if (op == 1)
                {
                    Funcionario f = new Funcionario();
                    Console.WriteLine("Digite o departamento:");
                    f.Departamento = Console.ReadLine();

                    Console.WriteLine("Digite o salário:");
                    f.Salario = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a data de admissão:");
                    f.DataInicio = Console.ReadLine();

                    Console.WriteLine("Digite o RG:");
                    f.Rg = Console.ReadLine();

                    Console.WriteLine("Está ativo na empresa? ");
                    string resposta = Console.ReadLine();
                    f.Ativo = resposta  == "sim"? true: false;

                    lista.Add(f);
                }else if (op == 2)
                {
                    foreach (var item in lista)
                    {
                        Console.WriteLine($"Departamento: {item.Departamento}");
                    }
                }
            }



        }
    }
}