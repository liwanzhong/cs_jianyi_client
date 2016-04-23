using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace jianyi_winform
{
    public class ConfigureAppConfig
    {


        public static string API_SERVER_URL = "API_SERVER_URL";

        public static string API_M_CODE = "API_M_CODE";

        public static string API_CLIENT_PUB_SIGN_KEY = "API_CLIENT_PUB_SIGN_KEY";

        public static string API_CUSTOM = "API_CUSTOM";


        //静态构造,不能实例化
        static ConfigureAppConfig() { } /**//// <summary>


        /// 获取AppSettings配置节中的Key值
        /// </summary>
        /// <param name="keyName">Key's name</param>
        /// <returns>Key's value</returns>
        public static string GetAppSettingsKeyValue(string keyName)
        {
            return ConfigurationManager.AppSettings.Get(keyName);
        }





        /**/
        /// <summary>
        /// 判断appSettings中是否有此项
        /// </summary>
        private static bool AppSettingsKeyExists(string strKey, Configuration config)
        {
            foreach (string str in config.AppSettings.Settings.AllKeys)
            {
                if (str == strKey)
                {
                    return true;
                }
            }
            return false;
        }



        /**/
        /// <summary>
        /// 保存appSettings中某key的value值
        /// </summary>
        /// <param name="strKey">key's name</param>
        /// <param name="newValue">value</param>
        public static void AppSettingsSave(string strKey, string newValue)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (AppSettingsKeyExists(strKey, config))
            {
                config.AppSettings.Settings[strKey].Value = newValue;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }

        }




    }
}
