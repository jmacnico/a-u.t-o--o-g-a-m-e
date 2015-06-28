using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace Business.Elementos
{
    public class BtnMenu : Button
    {
        public string textName;

        public BtnMenu(string id, ElementoPesquisaEnum pesquisa,string TextName) : base (id,pesquisa)
        {
            textName = TextName;       
        }
        public override IWebElement GetElemento(IWebDriver pagina)
        {
            try
            {
                //XmlDataDocument xmldoc = new XmlDataDocument();
                //XmlNodeList xmlnode;
                //FileStream fs = new FileStream(@"FilesXML\Menu.xml", FileMode.Open, FileAccess.Read);
                //xmldoc.Load(fs);
                //xmlnode = xmldoc.GetElementsByTagName("Menu");
                //var x = xmlnode[0].ChildNodes[0].Attributes[0].Value;
                //var a = pagina.FindElement(By.Id(xmlnode[0].ChildNodes[0].Attributes[0].Value));
                //XmlNodeList node = xmldoc.GetElementsByTagName("Buttons");
                //XmlNode node2 = null;
                //foreach(XmlNode node1 in node)
                //{
                //    if(node1.Attributes["Name"].Value == "Recursos")
                //    {
                //        node2 = node1;
                //        break;
                //    }
                //}
                //foreach(XmlNode node1 in node2.ChildNodes)
                //{

                //}



                switch (tipoPesquisa)
                {
                    case ElementoPesquisaEnum._id:
                        IWebElement menu = pagina.FindElement(By.Id("menuTable"));
                        var lstli = menu.FindElements(By.TagName("li"));
                        var li = lstli.FirstOrDefault(x => x.Text == id);
                        return li.FindElements(By.TagName("a")).FirstOrDefault(x => x.Text == textName);

                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private IWebElement GetElementoById(IWebElement elemento, string id)
        {
            return null;
        }
    }
}
