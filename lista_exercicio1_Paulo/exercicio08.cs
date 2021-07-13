using System;

namespace exercicio
{
    class lista_exercicio8_Paulo
    {
        public static void executar(){
            Console.WriteLine("Exercicio 08");

            double salario;
            const double comissao = 0.05; // não entendi pois nao tem valor de comissao
            const double valorVendas = 0.05;
            double vendas, totalVendas=0, ValorTotalVendas=0, ValorTotalComissao=0;
            int valorVendidos;

            Console.WriteLine("Quantos Carros Vendidos Por um Funcionario: ");
            valorVendidos = int.Parse(Console.ReadLine());

            for (int i = 0; i < valorVendidos; i++)
            {
                Console.WriteLine("Digite Quanto foi venda de um carro: ");
                vendas = double.Parse(Console.ReadLine());

                ValorTotalVendas = ValorTotalVendas + vendas;
                ValorTotalComissao = ValorTotalComissao + vendas*comissao;
                totalVendas = vendas*valorVendas;

            }

            Console.WriteLine("Salario fixo: ");
            salario = double.Parse(Console.ReadLine());

            salario = salario + ValorTotalComissao + totalVendas;

            Console.WriteLine("Total Vendas: " +ValorTotalVendas);
            Console.WriteLine("Salario final: "+salario);


        }
    }
}