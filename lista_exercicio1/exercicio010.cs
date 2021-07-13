using System;

namespace exercicio
{
    class lista_exercicio10
    {
        public static void executar(){

            double c, f;
            Console.WriteLine("Digite Valor Graus Fahrenheit: ");
            f = double.Parse(Console.ReadLine());
            c = ((f - 32) * 5) /9;

            Console.WriteLine("Graus Celsius: "+c);
        }   
    }
}