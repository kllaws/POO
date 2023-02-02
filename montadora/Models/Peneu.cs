﻿using Models;

namespace Models
{
    public class Pneu
    {
        public string? Cor { get; set; }
        public int Aro { get; set; }
        public string? Tipo { get; set; }
        public bool TWI { get; set; }
        public int PercentualBorracha { get; set; }
        public bool Estourado { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public bool Estepe { get; set; }

        public Pneu(int _Aro, int _VelocidadeMaxima, string _tipo, bool _estepe)
        {
            Aro = _Aro;
            Tipo = _tipo;
            VelocidadeMaxima = _VelocidadeMaxima;
            Estepe = _estepe;
            VelocidadeAtual = 0;
            Estourado = false;
            TWI = false;
            Cor = "preto";
            PercentualBorracha = 100;
        }


        public void Girar(int _velocidade)
        {
            VelocidadeAtual = VelocidadeAtual + _velocidade;
            PercentualBorracha = PercentualBorracha - 3;

            if (VelocidadeAtual > VelocidadeMaxima || PercentualBorracha <= 30)
            {
                EstourarPneu();
            }
        }

        public void EstourarPneu()
        {
            Estourado = true;
            VelocidadeAtual = 0;
        }

        public void frear(int _reducao)
        {
            VelocidadeAtual = VelocidadeAtual - _reducao;
            PercentualBorracha = PercentualBorracha - 5;

            if (PercentualBorracha <= 30)
            {
                EstourarPneu();
            }

            if(VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }

        }
        public void Exibir()
        {
            Console.WriteLine("Aro: " + Aro);
            Console.WriteLine("PercentualBorracha: " + PercentualBorracha);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("VelocidadeMaxima: " + VelocidadeMaxima);
            Console.WriteLine("Estepe: " + Estepe);
            Console.WriteLine("Estourado: " + Estourado);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("TWI: " + TWI);
            Console.WriteLine("VelocidadeAtual: " + VelocidadeAtual);

        }

    }
}

        