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
            * 1.Crie um Programa em C# que receba três números do usuário, informe na tela qual
              é o MENOR deles ou exiba se eles são iguais.
            */

           // A função Console.ReadLine() ela retorna uma string
           // Por isso realizar a transformação para float, usando o float.Parse()
           float valueOne = float.Parse(Console.ReadLine());
           float valueTwo = float.Parse(Console.ReadLine());
           float valueThree = float.Parse(Console.ReadLine());

           if (valueOne < valueTwo && valueOne < valueThree)
           {
               Console.WriteLine("O menor valor é valor 1: " + valueOne);
           } else if (valueTwo < valueOne && valueTwo < valueThree)
           {
               Console.WriteLine("O menor valor é o valor 2: " + valueTwo);
           } else if (valueThree < valueOne && valueThree < valueTwo)
           {
               Console.WriteLine("O menor valor é o valor 3:" + valueThree);
           }
           else
           {
               Console.WriteLine("Todos são iguais");
           }
           
           /*
            * 2.Crie um Programa em C# que, receba três números do usuário, informe na tela qual
              é o MAIOR deles ou exiba se eles são iguais.
            */
           float valueOneTest = float.Parse(Console.ReadLine());
           float valueTwoTest = float.Parse(Console.ReadLine());
           float valueThreeTest = float.Parse(Console.ReadLine());
           if (valueOneTest > valueTwoTest && valueOneTest > valueThreeTest)
           {
               Console.WriteLine("O maior valor é valor 1: " + valueOneTest);
           } else if (valueTwoTest > valueOneTest && valueTwoTest > valueThreeTest)
           {
               Console.WriteLine("O maior valor é o valor 2: " + valueTwoTest);
           } else if (valueThreeTest > valueOneTest && valueThreeTest > valueTwoTest)
           {
               Console.WriteLine("O maior valor é o valor 3:" + valueThreeTest);
           }
           else
           {
               Console.WriteLine("Todos são iguais");
           }
           
           /*
            * 3. Guilherme é chefe do setor de T.I de sua empresa e precisa que você ajude-o a
              criar um programa usando a linguagem C# que receba os chamados dos usuários
              classificando e exibindo na tela o seu nível de urgência, sendo de 0-3 "BAIXO", maior
              que 3 até 6 "MÉDIO", maior que 6 até 9 "ALTO", para os demais casos é considerado
              "GRAVE".
            */
           int valueTicket = int.Parse(Console.ReadLine());

           if (valueTicket >= 0 && valueTicket <= 3)
           {
               Console.WriteLine("O chamado é de urgência (Baixa)");
           } else if (valueTicket > 3 && valueTicket <= 6)
           {
               Console.WriteLine("O chamado é de urgência (Média)");
           } else if (valueTicket > 6 && valueTicket <= 9)
           {
               Console.WriteLine("O chamado é de urgência (Alta)");
           }
           else
           {
               Console.WriteLine("O chamado é de urgência (Grave)");
           }

        }
    }
}