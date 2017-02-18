using System;
using System.Collections.Generic;

namespace Singleton
{
    public sealed class Configuration
    {
        private static Configuration instance = new Configuration();
        private Dictionary<String, String> keyValuePair;
        private static object syncLock = new object();

        // Method to retrieve a single instance of Configuration
        public static Configuration getInstance()
        {
            if (instance == null)
                // Ensure thread safty
                lock (syncLock)
                {
                    if(instance == null)
                        instance = new Configuration();
                }
            return instance;
        }

        // Private constructor for controlled object instantiation
        private Configuration()
        {
            keyValuePair = new Dictionary<string, string>();
            // Load Configuration from anywhere
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
