using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SecaoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Constantes => São iguais variáveis, entretando possuem seus valores imutáveis
             * São muito utilizadas por características de segurança
             */

            const float pi = 3.14f;
            
            Console.WriteLine(pi);
            Console.WriteLine("------------------------------------");
            /*
             * Trabalhando com a entrada do usuário
             */
            
            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("O nome do usuário é: " + nome);
            Console.WriteLine("------------------------------------");

            /*
             * Trabalhando com operadores aritméticos
             */

            int soma = 20 + 20;
            int sub = 20 - 10;
            int mult = 10 * 20;
            
            // Devemos ficar atento, pois podem resultar em valores float (Caso for, ele irá arredondar para o valor menor)
            // int valor = 5 / 2 -> resulta em 2, pois arredonda para 2 e não para 3. Isso pode causar bugs na aplicação.
            int div = 20 / 10; 
            int resto = 20 % 10;
            
            Console.WriteLine(soma);
            Console.WriteLine(sub);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            Console.WriteLine(resto);
            
            Console.WriteLine("------------------------------------");
            
            /*
             * Trabalhando com estruturas condicionais
             *
             * Operadores condicionais:
             *  >
             *  <
             *  ==
             *  =>
             *  <=
             *  <>
             *  %
             */
            
            float number = 10;

            if (number > 10)
            {
                Console.WriteLine("O número é maior que 10!");
            } else if (number < 10)
            {
                Console.WriteLine("O número é menor que 10!");
            }
            else
            {
                Console.WriteLine("O numero é igual a 10");
            }
        }
    }
}