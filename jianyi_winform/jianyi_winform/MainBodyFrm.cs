using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jianyi_winform
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomManagerFrm customManageFrm = new CustomManagerFrm();
            Control_Add(customManageFrm);
        }



   

        private void toolBar_main_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.Name.Equals("toolBarButton1"))
            {
                //todo 实例化会员管理窗口
                CustomManagerFrm customManageFrm = new CustomManagerFrm();
                Control_Add(customManageFrm);
            }
            else if (e.Button.Name.Equals("toolBarButton2"))
            {
             
                //实例化配置管理窗口  
                ConfigureFrm configureFrm = new ConfigureFrm();
                Control_Add(configureFrm);
            }
            else if (e.Button.Name.Equals("toolBarButton3"))
            {
               
                ////todo 实例化常见问题窗口
                //NormalQuestionFrm normalQuestion = new NormalQuestionFrm();
                //Control_Add(normalQuestion);

                MessageBox.Show("功能开发中！","tips");
            }
        }


        /**
         * 
         * 展现子窗体到panel中
         * */
        private void Control_Add(Form form)
        {
            if (panel_body.Controls.Find(form.Name, true).Length>0)
            {
                return;
            }
            panel_body.Controls.Clear(); //移除所有控件
            form.TopLevel = false;  //设置为非顶级窗体
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置窗体为非边框样式
            form.Dock = System.Windows.Forms.DockStyle.Fill;//设置样式是否填充整个panel
            panel_body.Controls.Add(form);//添加窗体
            form.Show();//窗体运行
        }
    }
}
