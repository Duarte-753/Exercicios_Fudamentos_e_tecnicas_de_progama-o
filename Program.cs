using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_exercícios_extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NOME: Julio Duarte Batista RA:6322046 Curso: ADS 17/05/2022

            /*
            // 1) Faça um programa que leia dois valores e mostre uma das três mensagens a seguir:
            int numero1, numero2;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.Write("\nNúmeros iguais!");
            }
            else if (numero1 > numero2)
            {
                Console.Write("\nPrimeiro número é maior!");
            }
            else if (numero1 < numero2)
            {
                Console.Write("\nSegundo número é maior!");
            }*/

            /*
            // 2) Faça um programa que leia uma data , no formato ddmmaaaa, mostrar se a data é válida ou não.
            int dia, mes, ano;

            Console.Write("Digite o dia com dois digitos: ");
            dia = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("\nDigite o mês com dois digitos: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite o ano com quatro digitos: ");
            ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + dia + "/" + mes + "/" + ano);

            if (dia <= 31 && mes <= 12 && ano >= 1000 && ano <= 9999)
            {
                Console.Write("\n" + "Data válida");
            }

            else
            {
                Console.Write("\n" + "Data inválida");
            }
            */

            /*
            // 3) Faça um programa que receba o código correspondente ao cargo de um funcionário e seu salário atual. 
            // O programa deverá calcular o aumento e mostrar o cargo, o aumento e o novo salário.
            // Os cargos e o percentual de aumento estão na tabela a seguir:
            //
            // Código|Cargo     | Percentual de aumento
            // 1     |Secretário|    35%
            // 2     |caixa     |    20%
            // 3     |Gerente   |    15%

            double novoSalario, percentual, salario;
            string cargo;

            Console.WriteLine("Código|Cargo     | Percentual de aumento");
            Console.WriteLine("1     |Secretário|    35%");
            Console.WriteLine("2     |caixa     |    20%");
            Console.WriteLine("3     |Gerente   |    15%");

            Console.WriteLine("\nDigite o Código correspondente ao cargo funcionário e seu Salário atual: ");
            Console.Write("\nNúmero do cargo: ");
            cargo = Console.ReadLine();
            Console.Write("\nDigite o salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (cargo == "1")
            {
                novoSalario = salario + (salario * 0.35);
                
                Console.WriteLine("\nO cargo de Secretário com salário R$"+salario+" vai ter um percentual de aumento de 35% e seu novo salário vai ser R$"+novoSalario);
            }
            else if (cargo == "2")
            {
                novoSalario = salario + (salario * 0.20);

                Console.WriteLine("\nO cargo de Caixa com salário R$" + salario + " vai ter um percentual de aumento de 20% e seu novo salário vai ser R$" + novoSalario);
            }
            else if (cargo == "3")
            {
                novoSalario = salario + (salario * 0.15);

                Console.WriteLine("\nO cargo de Gerente com salário R$" + salario + " vai ter um percentual de aumento de 15% e seu novo salário vai ser R$" + novoSalario);
            }
            else
            {
                Console.WriteLine("\nDigite somente os código presente na tabela, tente novamente!");
            }*/

            Console.ReadKey();
        }
    
    }
}
