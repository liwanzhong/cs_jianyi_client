using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int CallbackFun(string AType, string AContent)
        {

            richTextBox1.Text = richTextBox1.Text + "回调状态:----->" + AType + "---->" + AContent + "\r\n";
            MessageBox.Show("回调状态:----->" + AType + "---->" + AContent ,"提示");

            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "(注册回调函数)调用状态:----->" + It_interface.reg_callback_stdcall(CallbackFun) + "\r\n";
        }





       

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "(串口初始化)调用状态:----->" + It_interface.com_init() + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "(打开串口)调用状态:----->" + It_interface.com_open() + "\r\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "(关闭串口)调用状态:----->" + It_interface.com_close() + "\r\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "(查询接触情况)调用状态:----->" + It_interface.com_checkstatus() + "\r\n";
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "(移动杆进)调用状态:----->" + It_interface.com_movein() + "\r\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "(移动杆出)调用状态:----->" + It_interface.com_moveout() + "\r\n";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "(原测试使用的回调函数)调用状态:----->" + It_interface.test_callback_stdcall(1) + "\r\n";

        }
    }
}
