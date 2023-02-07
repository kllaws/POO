
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Models
{
    internal class Carro
    {
        public int? Odometro { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int? Ano { get; set; }
        public string? Placa { get; set; }
        public int? VelocidadeMaxima { get; set; }
        public string? Categoria { get; set; }
        public string? TipoCombustivel { get; set; }
        public string? QuantidadeAcento{ get; set; }
        public string? TipoDeCambio { get; set; }
        public bool Ligado { get; set; }
        public int PercentualCombustivel { get; set; }
        public int VelocidadeAtual { get; set; }
        public Pneu PneuDianteiroEsquerdo { get; set; }
        public Pneu PneuDianteiroDireito { get; set; }
        public Pneu PneuTrazeiroEsquerdo { get; set; }
        public Pneu PneuTrazeiroDireito { get; set; }
        public Pneu PneuEstepe { get; set; }




        public Carro(string _marca, string _modelo, int _ano, int _velocidadeMaxima)
        {
            Marca = _marca;
            Modelo = _modelo;
            Ano = _ano;
            VelocidadeMaxima = _velocidadeMaxima;

            Odometro = 0;
            Ligado = false;
            PneuDianteiroEsquerdo = new Pneu(16, 150, "Carro passeio");
            PneuDianteiroDireito = new Pneu(16, 150, "Carro passeio");
            PneuTrazeiroEsquerdo = new Pneu(16, 150, "Carro passeio");
            PneuTrazeiroDireito = new Pneu(16, 150, "Carro passeio");
            PneuEstepe = new Pneu(16, 70, "Carro passeio",true);
          

        }

        public void Ligar()
        {
          if(PercentualCombustivel > 0)
                {
                    Ligado = true;
                }
             
            }
        
        public void Desligar()
        {
            Ligado = false;
            VelocidadeAtual = 0;
            PneuDianteiroEsquerdo.VelocidadeAtual = 0;
            PneuDianteiroDireito.VelocidadeAtual = 0;
            PneuTrazeiroEsquerdo.VelocidadeAtual = 0;
            PneuTrazeiroDireito.VelocidadeAtual = 0;






        }
        public void Acelerar(int _impulso)
        {
            VelocidadeAtual = VelocidadeAtual + _impulso;
            PneuDianteiroEsquerdo.Girar(_impulso);
            PneuDianteiroDireito.Girar(_impulso);
            PneuTrazeiroEsquerdo.Girar(_impulso);
            PneuTrazeiroDireito.VGirar(_impulso);


        }
      
        public void Frear( int _reduzir)
        {
            VelocidadeAtual = VelocidadeAtual - _reduzir;
            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;

        }
        

        public void Abastecer(int _quantidadeCombustivel)
        {
            if (PercentualCombustivel == 0)
                _quantidadeCombustivel = 100 - PercentualCombustivel;
            if (PercentualCombustivel + _quantidadeCombustivel > 100)
                {
                Console.WriteLine("A quantidade de combustivel ultrapassa  o limite do tanque");
                    return;

                }

                if(PercentualCombustivel < 100)
                {
                PercentualCombustivel = PercentualCombustivel + _quantidadeCombustivel;
                }

        }
        public void  Exibir()
        {
            Console.WriteLine("Odometro: " + Odometro);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("VelocidadeMaxima: " + VelocidadeMaxima);
            Console.WriteLine("Categoria: " + Categoria);
            Console.WriteLine("TipoCombustivel: " + TipoCombustivel);
            Console.WriteLine("QuantidadeAcento: " + QuantidadeAcento);
            Console.WriteLine("TipoDeCambio: " + TipoDeCambio);
            Console.WriteLine("Ligado: " + Ligado);
            Console.WriteLine("PercentualCombustivel: " + PercentualCombustivel);
            Console.WriteLine("VelocidadeAtual: " + VelocidadeAtual);





            Console.WriteLine("\nPneuDianteiroEsquerdo");
            PneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuDianteiroDireito");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("\nPneuTrazeiroEsquerdo");
            PneuTrazeiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuTrazeiroDireito");
            PneuTrazeiroDireito.Exibir();
            Console.WriteLine("\nPneuEstepe");
            PneuEstepe.Exibir();


        }

    }
}
