
using System.Diagnostics;

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
        public Pneu PneuDianteiroDianteiro { get; set; }
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
            PneuDianteiroDianteiro = new Pneu(16, 150, "Carro passeio");
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
            PneuDianteiroDianteiro.VelocidadeAtual = 0;
            PneuDianteiroEsquerdo.VelocidadeAtual = 0;
            PneuTrazeiroDireito.VelocidadeAtual = 0;
            PneuTrazeiroEsquerdo.VelocidadeAtual = 0;






        }
        public void Acelerar()
        {

        }
      
        public void Frear()
        {

        }
        public void Abastecer()
        {

        }

    }
}
