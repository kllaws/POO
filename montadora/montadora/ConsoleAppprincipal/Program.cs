using models;

namespace ConsoleAppprincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu();
            pneu1.Cor = "preto";
            pneu1.Tipo = "carro de passeio";
            pneu1.Marca = "Firestone";
            pneu1.Aro = 16;
            pneu1.Furado = false;
            pneu1.Estourado = false;
            pneu1.Estepe = false;
            pneu1.VelocidadeAtual = 0;
            pneu1.VelocidadeMaxima = 150;
            pneu1.PercentualBorracha = 100;
            pneu1.TWI = false;
            pneu1.Girar(5);

            pneu1.Estourado = true;

            Console.WriteLine("Cor: "+pneu1.Cor);
            Console.WriteLine("Tipo: "+pneu1.Tipo);
            Console.WriteLine("Marca: "+ pneu1.Marca);
            Console.WriteLine("Aro: " + pneu1.Aro);
            Console.WriteLine("Furado: "+pneu1.Furado);
            Console.WriteLine("Estourado: "+pneu1 .Estourado);
            Console.WriteLine("Estepe: "+pneu1.Estepe);
            Console.WriteLine("velocidadeAtual: "+pneu1.VelocidadeAtual);
            Console.WriteLine("VelocidadeMaxima: "+pneu1.VelocidadeMaxima); 
            Console.WriteLine("TWI: "+pneu1.TWI);   



        }
    }
}