using System;

namespace exercicio
{
    class lista_exercicio4
    {
        public static void executar(){
            Console.WriteLine("Exercicio 04");

            int idade;

            Console.WriteLine("Escreve a Idade: ");
            idade = int.Parse(Console.ReadLine());

            int anosAtual = 2021;

            int dias = idade * 365;
            
            int mesNascimento = dias / 30;

            int anosNascimento = anosAtual - idade;
                        
            Console.WriteLine(dias+" Dias e Idade: "+idade);
            Console.WriteLine("Anos: "+anosNascimento+" Meses: "+ mesNascimento);
        }
    }
}