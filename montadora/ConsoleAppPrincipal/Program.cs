using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu(16,150,"Carro de passeio");
            Pneu pneu2 = new Pneu(16,70,"peneu de estepe",true);


            Carro fusca = new Models.Carro("volkswagen", "Itamar franco", 1994, 120, "");

           
            fusca.Abastecer(80);
            fusca.ligar(true);
            fusca.acelerar(15);

        }
    }
}