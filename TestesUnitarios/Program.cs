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
                login.global.menu.EntrarRecursos(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.principal).DetailMinaMetal(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.principal).DetailMinaCristal(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.principal).DetailMinaDeuterio(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.principal).DetailPlantaEnergia(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.principal).DetailPlantaEnergia(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.principal).DetailPlantaFusao(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.principal).DetailArmazemMetal(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.principal).DetailarmazemCristal(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.principal).DetailArmazemDeuterio(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.principal).DetailEsconderijoMetal(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.principal).DetailEsconderijoCristal(login.paginaElementos);
                ((Recursos)login.global.menu.recursos.principal).DetailEsconderijoDeuterio(login.paginaElementos);

                login.global.menu.EntrarRecursos(login.paginaElementos,true);
                login.global.menu.EntrarInstalacoes(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.principal).DetailFabricaRobots(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.principal).DetailHangar(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.principal).DetailLabratorioPesquisas(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.principal).DetailDepositoAlianca(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.principal).DetailSiloMisseis(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.principal).DetailFabricaNanites(login.paginaElementos);
                ((Instalacoes)login.global.menu.instalacoes.principal).DetailTerraFormador(login.paginaElementos);

                login.global.menu.EntrarPesquisas(login.paginaElementos);
                login.global.menu.EntrarPesquisas(login.paginaElementos,true);
                login.global.menu.EntrarHangar(login.paginaElementos);
                login.global.menu.EntrarDefesas(login.paginaElementos);
                login.global.menu.EntrarGalaxia(login.paginaElementos);
                login.global.menu.EntrarFrota(login.paginaElementos);
                login.global.menu.EntrarFrota(login.paginaElementos,true);
                login.global.menu.EntrarVistaGeral(login.paginaElementos);
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
