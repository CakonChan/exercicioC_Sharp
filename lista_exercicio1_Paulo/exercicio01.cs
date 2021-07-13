using System;


namespace exercicio
{
    class lista_exercicio1_Paulo
    {
        public static void executar(){
            Console.WriteLine("Exercicio 01");

            Console.WriteLine("Digite o Valor A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor B: ");
            int b = int.Parse(Console.ReadLine());

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("Valor A: "+a+" Valor B: "+b);
        
        }
    }
}