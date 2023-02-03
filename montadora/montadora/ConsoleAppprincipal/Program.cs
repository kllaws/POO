using models;

namespace ConsoleAppprincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu(16, "carro de passeio", "firestone", false, 150); 
           
          
            pneu1.Girar(5);

            pneu1.Estourado = true;

            pneu1.Exibir();


        }
    }
}