using System;

namespace exercicio
{
    class lista_exercicio2_Paulo
    {
        public static void executar()
        {
            Console.WriteLine("Exercicio 02");
            
            int valor = 0;

            try
            {
                Console.WriteLine("Valor: " + valor);
                valor = int.Parse(Console.ReadLine());
                /* 
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    valor = numero;
                }else{
                    Console.WriteLine("Inválido!");
                }
                */
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Incorreto! Somente Inteiro!");
                throw;
            }
            catch (System.Exception)
            {
                Console.WriteLine("System Error");
                throw;
            }

            Console.WriteLine(valor);
        }
    }
}