using System;

namespace exercicio
{
    class lista_exercicio3_Paulo
    {
        public static void executar(){
            Console.WriteLine("Exercicio 03");
            
            double valorBase;
            Console.WriteLine("Escreve Valor Base: ");
            valorBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreve valor altura");
            double altura = double.Parse(Console.ReadLine());

            double rentaguloArea = valorBase * altura;

            Console.WriteLine("Área de rentagulo: "+rentaguloArea);

        
        }
    }
}