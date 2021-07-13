using System;

namespace exercicio
{
    class exercicio01
    {
        public static void executar()
        {
            Carro fusca = new Carro();
            Console.WriteLine("Carro!\n");
            fusca.LigarMotor();
            fusca.acelerar();
            fusca.Conduzir();
            fusca.freiar();
            fusca.DesligarMotor();

            Aviao voo = new Aviao();
            Console.WriteLine("Avião!\n");
            voo.LigarMotor();
            voo.decolar();
            voo.Conduzir();
            voo.aterrisar();
            voo.DesligarMotor();
            


        }

        
    class Aviao : Veiculo
    {        
        public void decolar(){ Console.WriteLine("Decolando!");}

        public void aterrisar(){ Console.WriteLine("Aterrisando!");}

        public override void Conduzir(){
            Console.WriteLine("Marcha Ativada!");
        }
        

    }

    class Carro : Veiculo
    {
        public void acelerar(){ Console.WriteLine("Acelerando!");}

        public void freiar(){ Console.WriteLine("Freiando!");}

        public override void Conduzir(){
            Console.WriteLine("Marcha Ultra!");
        }
        
    }

    class Veiculo
    {
        
        public void LigarMotor() //metodo para ligar Motor
        {
            Console.WriteLine("Ligando Motor...");
        }

        public void DesligarMotor() //metodo para desligar Motor
        {
            Console.WriteLine("Desligando Motor...");
        }

        
        public virtual void Conduzir() //metodo virtual para classes pai e filho(s)
        {
            Console.WriteLine("Dirigindo...");
        }
        
    }


    }


}