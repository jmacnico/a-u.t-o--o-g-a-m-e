using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using Business;
using System.Configuration;
using Business.Menu;
using Business.Elementos;
using Business.Paginas;
using System.Xml;
using System.IO;
using System.Globalization;
using Business.Configs;
using System.Threading;

namespace TestesUnitarios
{
    
    class Program
    {
        static void Main(string[] args)
        {
            CustomConfig a1 = (CustomConfig)ConfigurationManager.GetSection("customConfig");
            Utilizador utilizador = new Utilizador(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Universo"].ToString(), ConfigurationManager.AppSettings["Email"].ToString());
            Login login = new Login(utilizador);
            login.OpenPagina();
            bool continuar = true;
            if (!login.Entrar(login.paginaElementos))
            {
                Encoding enc = Encoding.Default;
                continuar = false;
                Console.WriteLine("User não registado, Pretende registar?");
                string a = Console.ReadLine();
                if (a.ToUpper() == "S")
                {
                    login.Registar((login.paginaElementos));
                    continuar = true;
                }
                else
                    login.paginaElementos.Close();
            }
            if(continuar)
            {
                login.global.listPlanetas[0].Selecionar(login.paginaElementos);
                login.global.menu.recursos.EntarPrincipal(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.GetPrincipal()).MinaMetal.AbrirDetalhes(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.GetPrincipal()).MinaCristal.AbrirDetalhes(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.GetPrincipal()).MinaDeuterio.AbrirDetalhes(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.GetPrincipal()).PlantaEnergia.AbrirDetalhes(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.GetPrincipal()).PlantaEnergia.AbrirDetalhes(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.GetPrincipal()).PlantaFusao.AbrirDetalhes(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.GetPrincipal()).ArmazemMetal.AbrirDetalhes(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.GetPrincipal()).ArmazemCristal.AbrirDetalhes(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.GetPrincipal()).ArmazemDeuterio.AbrirDetalhes(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.GetPrincipal()).EsconderijoMetal.AbrirDetalhes(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.GetPrincipal()).EsconderijoCristal.AbrirDetalhes(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.GetPrincipal()).EsconderijoDeuterio.AbrirDetalhes(login.paginaElementos);

                login.global.menu.recursos.EntarSettings(login.paginaElementos);
                login.global.menu.instalacoes.EntarPrincipal(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.GetPrincipal()).FabricaRobots.AbrirDetalhes(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.GetPrincipal()).Hangar.AbrirDetalhes(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.GetPrincipal()).LabratorioPesquisas.AbrirDetalhes(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.GetPrincipal()).DepositoAlianca.AbrirDetalhes(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.GetPrincipal()).SiloMisseis.AbrirDetalhes(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.GetPrincipal()).FabricaNanites.AbrirDetalhes(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.GetPrincipal()).TerraFormador.AbrirDetalhes(login.paginaElementos);

                login.global.menu.pesquisas.EntarPrincipal(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).TecnologiaEnergia.AbrirDetalhes(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).TecnologiaLaser.AbrirDetalhes(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).TecnologiaIoes.AbrirDetalhes(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).TecnologiaHiperespaco.AbrirDetalhes(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).TecnologiaPlasma.AbrirDetalhes(login.paginaElementos);

                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).TecnologiaEspionagem.AbrirDetalhes(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).TecnologiaComputadores.AbrirDetalhes(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).Astrofisica.AbrirDetalhes(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).RedeIntergalaticaPesquisas.AbrirDetalhes(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).TecnologiaGravitacao.AbrirDetalhes(login.paginaElementos);

                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).MotorCombustao.AbrirDetalhes(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).MotorImpulsao.AbrirDetalhes(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).MotorPropulsorHiperespaco.AbrirDetalhes(login.paginaElementos);

                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).TecnologiaArmas.AbrirDetalhes(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).TecnologiaEscudo.AbrirDetalhes(login.paginaElementos);
                ((Pesquisas)login.global.menu.pesquisas.GetPrincipal()).TecnologiaBlindagem.AbrirDetalhes(login.paginaElementos);

                login.global.menu.pesquisas.EntarSettings(login.paginaElementos);
                login.global.menu.hangar.EntarPrincipal(login.paginaElementos);
                login.global.menu.defesas.EntarPrincipal(login.paginaElementos);
                login.global.menu.frota.EntarPrincipal(login.paginaElementos);
                login.global.menu.frota.EntarSettings(login.paginaElementos);
                login.global.menu.galaxia.EntarPrincipal(login.paginaElementos);
                login.global.menu.vistaGeral.EntarPrincipal(login.paginaElementos);
            }
        }
    }
    public class SomeSettings : ConfigurationSection
    {
        private SomeSettings() { }

        [ConfigurationProperty("FillColor", DefaultValue = "aaa")]
        public string FillColor
        {
            get { return this["FillColor"].ToString(); }
            set { this["FillColor"] = value; }
        }

        [ConfigurationProperty("TextSize", DefaultValue = "8.5")]
        public string TextSize
        {
            get { return this["TextSize"].ToString(); }
            set { this["TextSize"] = value; }
        }

        [ConfigurationProperty("FillOpacity", DefaultValue = "40")]
        public string FillOpacity
        {
            get { return this["FillOpacity"].ToString(); }
            set { this["FillOpacity"] = value; }
        }
    }
}
