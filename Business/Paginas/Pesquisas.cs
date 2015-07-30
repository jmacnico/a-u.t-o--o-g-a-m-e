using Business.Elementos;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    public class Pesquisas : IPagina
    {
        public BtnsEvolucao TecnologiaLaser { get; private set; }
        public BtnsEvolucao TecnologiaIoes { get; private set; }
        public BtnsEvolucao TecnologiaEnergia { get; private set; }
        public BtnsEvolucao TecnologiaHiperespaco { get; private set; }
        public BtnsEvolucao TecnologiaPlasma { get; private set; }
        public BtnsEvolucao TecnologiaEspionagem { get; private set; }
        public BtnsEvolucao TecnologiaComputadores { get; private set; }
        public BtnsEvolucao Astrofisica { get; private set; }
        public BtnsEvolucao RedeIntergalaticaPesquisas { get; private set; }
        public BtnsEvolucao TecnologiaGravitacao { get; private set; }
        public BtnsEvolucao TecnologiaArmas { get; private set; }
        public BtnsEvolucao TecnologiaEscudo { get; private set; }
        public BtnsEvolucao TecnologiaBlindagem { get; private set; }
        public BtnsEvolucao MotorCombustao { get; private set; }
        public BtnsEvolucao MotorImpulsao { get; private set; }
        public BtnsEvolucao MotorPropulsorHiperespaco { get; private set; }
        public Pesquisas()
            : base("MenuPesquisa")
        {

            TecnologiaLaser = new BtnsEvolucao("TecnologiaLaser");
            TecnologiaIoes = new BtnsEvolucao("TecnologiaIoes");
            TecnologiaEnergia = new BtnsEvolucao("TecnologiaEnergia");
            TecnologiaHiperespaco = new BtnsEvolucao("TecnologiaHiperespaco");
            TecnologiaPlasma = new BtnsEvolucao("TecnologiaPlasma");
            TecnologiaEspionagem = new BtnsEvolucao("TecnologiaEspionagem");
            TecnologiaComputadores = new BtnsEvolucao("TecnologiaComputadores");
            Astrofisica = new BtnsEvolucao("Astrofisica");
            RedeIntergalaticaPesquisas = new BtnsEvolucao("RedeIntergalaticaPesquisas");
            TecnologiaGravitacao = new BtnsEvolucao("TecnologiaGravitacao");
            TecnologiaArmas = new BtnsEvolucao("TecnologiaArmas");
            TecnologiaEscudo = new BtnsEvolucao("TecnologiaEscudo");
            TecnologiaBlindagem = new BtnsEvolucao("TecnologiaBlindagem");
            MotorCombustao = new BtnsEvolucao("MotorCombustao");
            MotorImpulsao = new BtnsEvolucao("MotorImpulsao");
            MotorPropulsorHiperespaco = new BtnsEvolucao("MotorPropulsorHiperespaco");
          
        }


        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }

    }
}
