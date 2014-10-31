using System;
using System.Configuration;

namespace BeamerClient
{
    class AppSett
    {
        static public String getAppSetting(String Key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(
                                    System.Reflection.Assembly.GetExecutingAssembly().Location);

            if (config.AppSettings.Settings[Key] == null)
                return null;
            return config.AppSettings.Settings[Key].Value;
        }

        static public void setAppSetting(String Key, String Value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(
                                    System.Reflection.Assembly.GetExecutingAssembly().Location);

            if (config.AppSettings.Settings[Key] != null)
                config.AppSettings.Settings.Remove(Key);

            config.AppSettings.Settings.Add(Key, Value);

            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
