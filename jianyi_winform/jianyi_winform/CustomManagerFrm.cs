using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;  


namespace jianyi_winform
{
    public partial class CustomManagerFrm : Form
    {

        public CustomManagerFrm()
        {
            InitializeComponent();
            
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            CheckFrm checkFrm = new CheckFrm();
            checkFrm.FormBorderStyle = FormBorderStyle.None;
            checkFrm.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            checkFrm.WindowState = FormWindowState.Maximized;
            checkFrm.Show();

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //todo 判断有没有选中行
            if (this.dgv_tables.SelectedRows.Count==0)
            {
                MessageBox.Show("请选中一位会员再做检测!","检测提醒");
                return;
            }
            //todo 获取选中行的用户id
            string[] str = new string[this.dgv_tables.Rows.Count];
            for (int i=0; i < this.dgv_tables.Rows.Count; i++)
            {
                if (this.dgv_tables.Rows[i].Selected == true)
                {
                    str[i] = this.dgv_tables.Rows[i].Cells[0].Value.ToString();
                    
                }
            }

            CheckFrm checkFrm = new CheckFrm();
            checkFrm.Show();
        }


        private void dView_employee_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgv_tables.RowHeadersWidth = 60;
            for (int i = 0; i < dgv_tables.Rows.Count; i++)
            {
                int j = i + 1;
                dgv_tables.Rows[i].HeaderCell.Value = j.ToString();
            }
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e == null || e.Value == null || !(sender is DataGridView))
            {
                return;
            }
            DataGridView dgv = (DataGridView)sender;
            object originalValue = e.Value;

            if (dgv.Columns[e.ColumnIndex].DataPropertyName == "sex")//格式化性别
            {
                e.Value = originalValue.Equals("1")? "男" : "女";
            }
            if (dgv.Columns[e.ColumnIndex].DataPropertyName == "body_height")//格式化性别
            {
                e.Value = originalValue+"cm";
            }
            if (dgv.Columns[e.ColumnIndex].DataPropertyName == "weight")//格式化性别
            {
                e.Value = originalValue + "kg";
            }
            if (dgv.Columns[e.ColumnIndex].DataPropertyName == "last_check_time")//格式化性别
            {
                if (e.Value != null)
                {
                    e.Value = this.GetTime(e.Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            if (dgv.Columns[e.ColumnIndex].DataPropertyName == "insert_time")//格式化性别
            {
                if (e.Value != null)
                {
                    e.Value = this.GetTime(e.Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                }
            }

            e.FormattingApplied = true;

        }


        /// <summary>
        /// 时间戳转为C#格式时间
        /// </summary>
        /// <param name="timeStamp">Unix时间戳格式</param>
        /// <returns>C#格式时间</returns>
        private  DateTime GetTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp+"0000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    

            StringBuilder requestUriBuilder = new StringBuilder();
            requestUriBuilder.Append(ConfigureAppConfig.GetAppSettingsKeyValue(ConfigureAppConfig.API_SERVER_URL));
            requestUriBuilder.Append(ConfigureAppConfig.GetAppSettingsKeyValue(ConfigureAppConfig.API_CUSTOM));
            //todo 设置参数，请求服务器
            Dictionary<String, String> dicList = new Dictionary<string, string>();
            dicList.Add("customName", tb_name.Text);
            dicList.Add("phone", tb_mobile.Text);
            dicList.Add("meathcode", ConfigureAppConfig.GetAppSettingsKeyValue(ConfigureAppConfig.API_M_CODE));//读取配置文件，获取机器码
            dicList.Add("userid", "3");
            String jsonString = HttpWebRequestUtils.PostHttp(requestUriBuilder.ToString(), HttpWebRequestUtils.buildQueryStr(dicList), null);
            //List<Customer> customerList = JSON.parse<List<Customer>>(jsonString);
            //JArray ja = (JArray)JsonConvert.DeserializeObject(jsonString);
            List<Customer> _list = JsonConvert.DeserializeObject<List<Customer>>(jsonString);


            this.dgv_tables.DataSource = _list;
           

        }





    }
}
