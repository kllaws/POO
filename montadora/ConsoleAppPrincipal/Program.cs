using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pneu pneu1 = new Pneu(16, 150, "Carro de passeio");
            //Pneu pneu2 = new Pneu(16, 70, "Pneu de estepe", true);

            Carro fusca = new Carro("Volkswagen", "Itamar Franco", 1994, 120, "");

            fusca.Abastecer(80);
            fusca.Ligar();
            fusca.Acelerar(15);
            fusca.Acelerar(5);
            fusca.Acelerar(22);
            fusca.Frear(8);
            fusca.Acelerar(3);
            fusca.Frear(4);
            fusca.Desligar();
            fusca.PneuDianteiroEsquerdo = fusca.PneuEstepe;
            fusca.Ligar();
            fusca.Acelerar(15);
            fusca.Acelerar(5);
            fusca.Acelerar(22);
            fusca.Frear(8);
            fusca.Acelerar(3);
            fusca.Frear(4);
            fusca.Acelerar(3);
            fusca.Acelerar(3);
            fusca.Acelerar(3);
            fusca.Abastecer(80);
            fusca.Ligar();
            fusca.Acelerar(40);
            fusca.Acelerar(29);
            fusca.Acelerar(1);
            fusca.Acelerar(1);
            fusca.Exibir();
        }
    }
    
}

