using System;

namespace exercicio
{
    class lista_exercicio7
    {
        public static void executar(){
            Console.WriteLine("Exercicio 07");

            double custo;
            double  porcDistribuidor, imposto;

            Console.WriteLine("Valor de Custo do Carro Novo: ");
            custo = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do Porcetagem de Distribuidor (Padrão - 28): ");
            porcDistribuidor = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor do Imposto (Padrão - 45): ");
            imposto = int.Parse(Console.ReadLine());

            porcDistribuidor = porcDistribuidor/100;
            imposto = imposto/100;

            Console.WriteLine("Distribuidor: "+porcDistribuidor+"% e Imposto: "+imposto+"%");
            double valorDistrib = custo*porcDistribuidor;
            double valorImposto = custo*imposto;
            double totalAbsurdo = custo + valorDistrib + valorImposto;

            Console.WriteLine("Valor Distribuidor: "+valorDistrib+" Valor Imposto: "+valorImposto+"\nValor Total ao Consumidor: "+ totalAbsurdo);
        }
    }
}