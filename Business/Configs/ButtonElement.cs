using Business.Elementos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Business.Configs
{
    public class ButtonElement : ConfigurationElement
    {

        [ConfigurationProperty("name", IsRequired = true)]
        public string Name { get { return (string)base["name"]; } }

        [ConfigurationProperty("value", IsRequired = true)]
        public string Value {get { return (string)base["value"]; } }


        [ConfigurationProperty("searchType", IsRequired = false, DefaultValue = ElementoPesquisaEnum._id)]
        public ElementoPesquisaEnum SearchType
        {

            get
            {
                return (ElementoPesquisaEnum)base["searchType"];
            }

        }


        public Identificador GetIdentificador()
        {
            return new Identificador(Value, SearchType);
        }

    }
}
