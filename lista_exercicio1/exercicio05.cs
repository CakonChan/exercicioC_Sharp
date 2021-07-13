using System;

namespace exercicio
{
    class lista_exercicio5
    {
        public static void executar(){
            Console.WriteLine("Exercicio 05");

            int totalEleitores;
            int totalVotosBrancos;
            int totalNulos;
            int totalValidos;

            Console.WriteLine("Escreve Quantos Eleitores (Ex. 1000): ");
            totalEleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreve Quantos Votos Brancos (Ex. 380): ");
            totalVotosBrancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreve Quantos Nulos (Ex. 20): ");
            totalNulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreve Quantos Válidos (Ex. 600): ");
            totalValidos = int.Parse(Console.ReadLine());

            double porcBrancos = (100 * totalVotosBrancos) / totalEleitores;
            double porcNulos = (100 * totalNulos) / totalEleitores;
            double porcValidos = (100 * totalValidos) / totalEleitores;
            
    
            Console.WriteLine("Porcetagem dos Votos Brancos: "+porcBrancos+"%");
            Console.WriteLine("Porcetagem dos Nulos: "+porcNulos+"%");
            Console.WriteLine("Porcetagem dos Validos: "+porcValidos+"%");
        }
    }
}