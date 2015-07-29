using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Business.Configs
{
    [ConfigurationCollection(typeof(ButtonElement), AddItemName = "button", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class ButtonElementCollection : ConfigurationElementCollection
    {
        public ConfigurationElementCollectionType CollectionType { get { return ConfigurationElementCollectionType.BasicMap; } }

        protected override string ElementName
        {
            get
            {
                return "button";
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ButtonElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as ButtonElement).Name;
        }

        public ButtonElement this[int index]
        {
            get
            {
                return (ButtonElement)base.BaseGet(index);
            }
            set
            {
                if (base.BaseGet(index) != null)
                {
                    base.BaseRemoveAt(index);
                }
                base.BaseAdd(index, value);
            }
        }
        public ButtonElement this[string title]
        {
            get
            {
                return (ButtonElement)base.BaseGet(title);
            }
        }


    }
}
