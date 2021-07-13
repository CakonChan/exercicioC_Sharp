using System;

namespace exercicio
{
    class lista_exercicio9
    {
        public static void executar(){
            Console.WriteLine("Exercicio 09");

            double notaA, notaB, notaC, media;


            Console.WriteLine("Nota: ");
            notaA = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota: ");
            notaB = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota: ");
            notaC = double.Parse(Console.ReadLine());

            media = (notaA*2 + notaB*3 + notaC*5) /10;

            Console.WriteLine("Nota: "+media);


        }
    }
}