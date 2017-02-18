using System;
using System.Collections.Generic;

namespace Singleton.lib
{
    class Configuration
    {
        private static Configuration instance = new Configuration();
        private Dictionary<String, String> keyValuePair;

        public static Configuration getInstance()
        {
            if (instance == null)
                instance = new Configuration();
            return instance;
        }

        private Configuration()
        {
            keyValuePair = new Dictionary<string, string>();
            // Load Configuration
        }

        public Dictionary<String, String> getValue()
        {
            return keyValuePair;
        }

        public String getValue(String key)
        {
            if (keyValuePair.ContainsKey(key))
                return keyValuePair[key];
            else
                return null;
        }

        public void setValue(String key, String value)
        {
            if (keyValuePair.ContainsKey(key))
            {
                keyValuePair.Remove(key);
                keyValuePair.Add(key, value);
            }
            else
            {
                keyValuePair.Add(key, value);
            }

            // Write configuation file
        }
    }
}
