using System;

namespace lista_exercicios_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 1

           double a, b;
           Console.WriteLine("Escreva o primeiro número: ");
           a = double.Parse(Console.ReadLine());
           Console.WriteLine("Escreva o segundo número: ");
           b = double.Parse(Console.ReadLine());
           Console.WriteLine("O resultado da média aritimética é " + (a+b)/2);


           //Exercício 2
           double a, b, c, d;
           Console.WriteLine("Escreva o primeiro número: ");
           a = double.Parse(Console.ReadLine());
           Console.WriteLine("Escreva o segundo número: ");
           b = double.Parse(Console.ReadLine());
           Console.WriteLine("Escreva o primeiro número: ");
           c = double.Parse(Console.ReadLine());
           Console.WriteLine("Escreva o segundo número: ");
           d = double.Parse(Console.ReadLine());
           Console.WriteLine("O resultado da média aritimética é " + (a + b + c + d) / 4);



           //Exercício 3

           int a = 2, b = 3, c;
           Console.WriteLine("Os valores de A="+a+" B="+b);
           c = a;
           a = b;
           b = c;
           Console.WriteLine("Os novos valores de A=" + a + " B=" + b);


           //Exercício 4

           string d, m;
           int a;
           Console.WriteLine("Digite a data desejada, DDMMAAAA: ");
           d = Console.ReadLine();
           m = Console.ReadLine();
           a = int.Parse(Console.ReadLine());
           Console.WriteLine("A data no formato AAAAMMDD é: " + a+"/"+m+"/"+d+ " e no formato AAMMDD é: "+ a.ToString().Substring(2, 2)+"/"+m+"/"+d);

           //Exercício 5

           int km, l;
           Console.WriteLine("Digite a distância percorida: ");
           km = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite a quantidade de litros consumiudo: ");
           l = int.Parse(Console.ReadLine());
           Console.WriteLine("O consumo médio foi de "+km/l+"km/l");

           
            //Exercício 6

            double codA, codB, qtdA, qtdB, vlrA, vlrB, ipi;

            Console.WriteLine("Digite o código do produto A: ");
            codA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto A: ");
            qtdA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto A: ");
            vlrA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código do produto B: ");
            codB = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto A: ");
            qtdB = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto A: ");
            vlrB = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual de IPI a ser aplicado: ");
            ipi = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor com IPI do produto A é: " + (ipi / vlrA) * 100);
            Console.WriteLine("O valor com IPI do produto B é: " + (ipi / vlrB) * 100);
            
            //Exercício 7

            double nVend, sFixo, tVendas, percent, sFinal;

            Console.WriteLine("Insira o número do vendedor: ");
            nVend = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o salário fixo: ");
            sFixo = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor total de vendas: ");
            tVendas = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a porcentagem de comissão: ");
            percent = double.Parse(Console.ReadLine());

            sFinal = sFixo + ((percent * tVendas)/100 ) ;

            Console.WriteLine("O salário final do vendedor "+nVend+" é de R$"+ sFinal);
            
            //Exercício 8

            double c,f;
            Console.WriteLine("Digite a temperatura em graus celsius: ");
            c = double.Parse(Console.ReadLine());
            f = (9 * c + 160) / 5;
            Console.WriteLine("A temperatura em graus Fahrenheit é "+ f+"°F");
            
            //Exercício 9

            double vP, vE, p;

            Console.WriteLine("Qual o valor do produto?");
            vP = double.Parse(Console.ReadLine());
            p = vP / 3;
            p = Math.Floor(p);
            vE = vP - (p * 2);
            Console.WriteLine("O valor de entrada é R$"+vE+"\nO valor de cada parcela é R$"+p);
            
            //Exercício 10

            double vS, c, cem=0, cinquenta=0, vinte=0, dez=0, cinco=0, um=0;
            Console.WriteLine("Digite o valor que deseja sacar:");
            vS = double.Parse(Console.ReadLine());
            c = vS;

            while(c > 0){
                if (c >= 100)
                {
                    c = c - 100;
                    cem++;
                }
                if (c < 100 && c >= 50)
                {
                    c = c - 50;
                    cinquenta++;
                }
                if (c < 50 && c >= 20)
                {
                    c = c - 20;
                    vinte++;
                }
                if (c < 20 && c >= 10)
                {
                    c = c - 10;
                    dez++;
                }
                if (c < 10 && c >= 5)
                {
                    c = c - 5;
                    cinco++;
                }
                if (c < 5 && c >= 1)
                {
                    c = c - 1;
                    um++;
                } }
             Console.WriteLine("Sacando... \nCalculando quantidade de cédulas... \nCédula de R$100: "+cem+"\nCédula de R$50: "+cinquenta+"\nCédula de R$20: "+vinte+"\nCédula de R$10: "+dez+"\nCédula de R$5: "+cinco+"\nCédula de R$1: "+um);
            Console.WriteLine("Você sacou R$"+vS);
            
            //Exercício 11

            double nE, vB, vN, vV, pB, pN, pV;

            Console.WriteLine("Digite o número de eleitores: ");
            nE = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de votos brancos: ");
            vB = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de votos nulos: ");
            vN = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de votos válidos: ");
            vV = double.Parse(Console.ReadLine());

            pB = vB / nE;
            pN = vN / nE;
            pV = vV / nE;
            
            Console.WriteLine("A porcentagem de votos é: \n"+pB.ToString().Substring(2,2)+"% de votos brancos.\n"+pN.ToString().Substring(2,2)+"% de votos nulos.\n"+pV.ToString().Substring(2,2)+"% de votos válidos.");
            
            //Exercício 12

            double hodI, hodF, litG, vR, lucro=0, cons;

            Console.WriteLine("Digite o km inicial: ");
            hodI = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o km final: ");
            hodF = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos litros foram gastos: ");
            litG = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite qual total recebido: ");
            vR = double.Parse(Console.ReadLine());

            cons = (hodF - hodI) / litG;
            lucro = vR - (litG * 6.90);


            Console.WriteLine("O consumo médio foi "+cons+"Km/l \nO lucro foi de R$"+lucro);
            
            //Exercício 13

            double sM, pC, qV, sF;

            Console.WriteLine("Digite o sslário mínimo: ");
            sM = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de custo de cada bicleta: ");
            pC = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade vendida:");
            qV = double.Parse(Console.ReadLine());


            sF = (sM * 2) + (15 *(pC * qV)/100); 
            Console.WriteLine("O salário do funcionário é R$"+sF);
	        

            */
            //Lista finalizada 26/09/2022

           
            
            
            
            
            Console.ReadKey(); // Aguarda o usuário precionar um tecla!
        }
    }
}