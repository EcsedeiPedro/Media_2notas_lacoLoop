using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media2notasrepete
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, media;
            char resp;

            //mostra ao usuário a utilidade do programa
            Console.WriteLine("Este programa faz o calculo da media de um aluno de acordo com as notas inseridas pelo usuário");

            //implementa o laço de repetição do no programa (
            do
            {
                //solicita ao usuário a primeira nota
                Console.Write(" \n Insira a primeira nota: ");

                //faça enquanto o usuário insira uma nota2 float maior que 0 ou menor que 10
                //caso fuja do parâmetro, exibe mensagem de erro
                while (!float.TryParse(Console.ReadLine(), out nota1) || nota1 < 0 || nota1 > 10)
                {
                    Console.Write("\n Insira um valor válido: ");
                }

                //solicita ao usuário a segunda nota
                Console.Write("\n Insira a segunda nota: ");

                //faça enquanto o usuário insira uma nota1 float maior que 0 ou menor que 10
                //caso fuja do parâmetro, exibe mensagem de erro
                while (!float.TryParse(Console.ReadLine(), out nota2) || nota2 < 0 || nota1 > 10)
                {
                    Console.Write("\n Insira um valor válido: ");
                }

                //realiza o cálculo da média
                media = (nota1 + nota2) / 2;



                //mostra ao usuário o resultado
                Console.WriteLine("\n Sua média é de " + media);

                //se média for maior que 5, aluno aprovado
                if (media >= 5)
                {
                    Console.Write("\n Aluno aprovado \n");
                }
                //senão, reprovado
                else
                {
                    Console.WriteLine("\n Aluno reprovado \n");
                }
                
                //pergunta ao usuário se o mesmo deseja continuar com o programa
                Console.Write("\n Deseja continuar com o programa? \n (s/n): ");
                //faça enquanto o usuário insira apenas um caracter (s/n)
                //caso digite algo fora do parâmetro definido, exibe mensagem de erro
                while (!char.TryParse(Console.ReadLine().ToLower(), out resp) || (resp != 's' && resp != 'n'))
                {
                    Console.Write("Resposta inválida! Digite s ou n: ");
                }

                //encerra ou continua o loop de acordo com a resposta do usuário
                } while (resp == 's');


        }
    }
}
