using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Color { Vermelho, Verde, Azul }

namespace Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cases Switchs

            // Primeiro Exemplo do Switch Statment:
            FirstExample();

            // Segundo Exemplo do Switch Statment:
            SecondExample();

            // Terceiro Exemplo do Switch Statment, utilizando o método DateTime():
            ThirdExample();

            // Quarto Exemplo do Switch Statment, utilizando User Input e outros operadores. 
            // Um pequeno game:
            CoffeGameExample();
           
        }

        static void FirstExample()
        {
            int swcase = 2;

            /* Neste primeiro exemplo, vemos um uso básico 
             * do switch statment, onde a expresão
             * que será printada na tela é definida na variável acima. 
             * Logo, o primeiro caso será escolhido.
             * Para manter o código limpo, iremos 
             * separar os exemplos em diferentes funções.
             */

            switch (swcase)
            {
                case 1:
                    Console.WriteLine("Caso 1");
                    break;

                case 2:
                    Console.WriteLine("Caso 2");
                    break;

                case 3:
                    Console.WriteLine("Caso 3");
                    break;

                default:
                    Console.WriteLine("Nenhum dos casos acima.");
                    break;
            }

            Console.ReadKey();
        }

        static void SecondExample()
        {
            /* Neste segundo exemplo, utilizando o Switch Statment como um alternativo
             * ao if-else. Onde uma expressão é testada sob três ou mais condições.
             * Por exemplo, iremos determinar uma variável do tipo Cor e ver se ela
             * possui um dos três valores, de forma randômica:
             */

            Color c = (Color)(new Random()).Next(0, 3);
            switch(c)

            {
                case Color.Vermelho:
                    Console.WriteLine("A cor é vermelha!");
                    break;

                case Color.Verde:
                    Console.WriteLine("A cor é verde!");
                    break;

                case Color.Azul:
                    Console.WriteLine("A cor é azul!");
                    break;

                default:
                    Console.WriteLine("A cor é indefinida.");
                    break;
            }

            Console.ReadKey();
        }

        static void ThirdExample()
        {
            /* Neste exemplo, utilizamos o método DateTime.Now.DayOfWeek onde os casos
             * serão escolhidos dependendo do dia do sistema atual. Colocando um output
             * na tela para cada dia da semana:
             */ 

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Hoje é Segunda-Feira");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine("Hoje é Terça-Feira");
                    break;

                case DayOfWeek.Wednesday:
                    Console.WriteLine("Hoje é Quarta-Feira");
                    break;

                case DayOfWeek.Thursday:
                    Console.WriteLine("Hoje é Quinta-Feira");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("Hoje é Sexta-Feira");
                    break;

                case DayOfWeek.Saturday:
                    Console.WriteLine("Hoje é Sábado");
                    break;

                case DayOfWeek.Sunday:
                    Console.WriteLine("Hoje é Domingo");
                    break;

                default:
                    Console.WriteLine("A data do sistema não está configurada!");
                    break;   
            }

            Console.ReadKey();        
        }

        static void CoffeGameExample()
        {

            /* Este é um pequeno jogo, seu intuito é utilizar o user input
             * do usuário e esperar sua escolha. Após isso, será feita uma
             * análise do caso, utilizar os operadores de soma e retornar um
             * valor de preço do produto.
             * Devido ao uso do goto statment no caso 2 e 3, a base de 25 centavos
             * é somada com o custo adicional do tamanho médio e largo do café. 
             */

            Console.WriteLine("Tamanhos do Café: 1 = Pequeno, 2 = Médio, 3 = Largo");
            start:
            Console.Write("Digite sua escolha: ");

            // User Input:
            string str = Console.ReadLine();
            int preco = 0;

            switch(str)
            {
                case "1":
                case "Pequeno":
                    preco += 25;
                    break;

                case "2":
                case "Médio":
                    preco += 25;
                    goto case "1";

                case "3":
                case "Grande":
                    preco += 50;
                    goto case "1";

                default:
                    Console.WriteLine("Seleção Inválida. Por favor selecione 1, 2 ou 3.");
                    goto start;      
            }

            if (preco !=0)
            {
                Console.WriteLine("Por favor, insira {0} centavos", preco);
            }
                Console.WriteLine("Obrigado pela sua escolha!");
                Console.ReadKey();
        }
                
    }
}
