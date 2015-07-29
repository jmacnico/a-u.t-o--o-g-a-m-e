using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Business.Configs
{
    public class CustomConfig : ConfigurationSection
    {
        private static CustomConfig _SchoolConfig = (CustomConfig)ConfigurationManager.GetSection("customConfig");
        public static CustomConfig Settings { get { return _SchoolConfig; } }

        [ConfigurationProperty("buttons")]
        public ButtonElementCollection Buttons { get { return (ButtonElementCollection)base["buttons"]; } }
    }
}
