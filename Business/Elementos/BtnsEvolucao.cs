using Business.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Elementos
{
    public class BtnsEvolucao
    {
        public Button detail { get; private set; }
        public Button evoluir { get; private set; }
        public BtnsEvolucao(string PartCommonKeyconfig)
        {
            detail = new Button(CustomConfig.Settings.Buttons[PartCommonKeyconfig + "Details"].GetIdentificador());
            evoluir = new Button(CustomConfig.Settings.Buttons[PartCommonKeyconfig + "Evoluir"].GetIdentificador());
        }

    }
}
