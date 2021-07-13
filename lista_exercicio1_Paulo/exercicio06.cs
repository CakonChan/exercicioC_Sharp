using System;

namespace exercicio
{
    class lista_exercicio6_Paulo
    {
        public static void executar(){
            Console.WriteLine("Exercicio 06");

            double salario;

            Console.WriteLine("Salario Mensal Atual: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de Percentual De Reajuste: ");
            double reajuste = double.Parse(Console.ReadLine());
            
            double novo = salario + (salario * (reajuste/100));

            Console.WriteLine("Novo Salario: "+novo);

        }
    }
}