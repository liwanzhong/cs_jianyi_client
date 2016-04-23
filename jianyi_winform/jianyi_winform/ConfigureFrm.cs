using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace jianyi_winform
{
    public partial class ConfigureFrm : Form
    {
        public ConfigureFrm()
        {
            InitializeComponent();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //todo 记录配置信息到配置文件中
            ConfigureAppConfig.AppSettingsSave(ConfigureAppConfig.API_SERVER_URL, bt_server_url.Text);
            ConfigureAppConfig.AppSettingsSave(ConfigureAppConfig.API_M_CODE, tb_m_code.Text);
            ConfigureAppConfig.AppSettingsSave(ConfigureAppConfig.API_CLIENT_PUB_SIGN_KEY, rtb_sign_pub_key.Text);
            if (MessageBox.Show("重新启动程序以应用新配置", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Restart();

                       

        }

        private void ConfigureFrm_Load(object sender, EventArgs e)
        {
            bt_server_url.Text = ConfigureAppConfig.GetAppSettingsKeyValue(ConfigureAppConfig.API_SERVER_URL);
            tb_m_code.Text = ConfigureAppConfig.GetAppSettingsKeyValue(ConfigureAppConfig.API_M_CODE);
            rtb_sign_pub_key.Text = ConfigureAppConfig.GetAppSettingsKeyValue(ConfigureAppConfig.API_CLIENT_PUB_SIGN_KEY);
        }
    }
}
