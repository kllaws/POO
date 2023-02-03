namespace models
{
    public class Pneu
    {
        private int _reducao;

        public int Aro { get; set; }
        public bool TWI { get; set; }
        public string Cor  { get; set; }
        public string Marca { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public bool Estepe { get; set; }
        public bool Estourado { get; set; }
        public string Tipo { get; set; }
        public int PercentualBorracha { get; set; }
        public bool Furado { get; set; }
        public Pneu( int _aro, string _tipo, string _marca,bool _estepe, int _velocidademaxima)
        {
            Aro = _aro;
            Tipo = _tipo;
            Marca = _marca;         
            Estepe = _estepe;
            VelocidadeMaxima = _velocidademaxima;
            Cor = "preto";
            Furado = false; 
            Estourado = false;  
            VelocidadeAtual = 0;
            PercentualBorracha = 100;
            TWI = false;

        }



        public void Girar( int _velocidade)
        {
            if(Estourado)
            {
                Console.WriteLine("O pneu esta estourado");
                return;
            }
            if(Furado)
            {
                Console.WriteLine("Pneu esta furado");
                return ;
            }

            VelocidadeAtual = VelocidadeAtual + _velocidade;
            PercentualBorracha -= -3;

            if (VelocidadeAtual > VelocidadeMaxima || PercentualBorracha <=30)
            {
                EstourarPeneu();
            }

        }
        public void Frear(int _reducao)
        {
            VelocidadeMaxima = VelocidadeMaxima - _reducao;
            PercentualBorracha -= 5;
            if(VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }

            if (PercentualBorracha < 0)
            {
                PercentualBorracha = 0;
            }

            if(PercentualBorracha <= 30)
            {
                EstourarPeneu();
            }

        }

        private void EstourarPeneu()
        {
            Estourado = true;
            VelocidadeAtual = 0;
        }

        public void Exibir()
        {
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Aro: " + Aro);
            Console.WriteLine("Furado: " + Furado);
            Console.WriteLine("Estourado: " + Estourado);
            Console.WriteLine("Estepe: " + Estepe);
            Console.WriteLine("velocidadeAtual: " + VelocidadeAtual);
            Console.WriteLine("VelocidadeMaxima: " + VelocidadeMaxima);
            Console.WriteLine("TWI: " + TWI);

        }
    }
}