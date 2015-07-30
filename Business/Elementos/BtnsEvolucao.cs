using Business.Configs;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Elementos
{
    public class BtnsEvolucao
    {
        Button detail;
        Button evoluir;
        public BtnsEvolucao(string PartCommonKeyconfig)
        {
            detail = new Button(CustomConfig.Settings.Buttons[PartCommonKeyconfig + "Details"].GetIdentificador());
            evoluir = new Button(CustomConfig.Settings.Buttons[PartCommonKeyconfig + "Evoluir"].GetIdentificador());
        }

        public void Evoluir(IWebDriver pagina)
        {
            evoluir.Funcao(pagina);
        }
        public void AbrirDetalhes(IWebDriver pagina)
        {
            detail.Funcao(pagina);
        }

    }
}
