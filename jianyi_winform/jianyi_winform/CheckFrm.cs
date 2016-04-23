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
    public partial class CheckFrm : Form
    {
        public CheckFrm()
        {
            InitializeComponent();

            Console.WriteLine("--------------------------------------------------------");

            //todo 调用硬件接口
            Console.WriteLine(It_interface.reg_callback_stdcall(CallbackFun));

            Console.WriteLine(It_interface.test_callback_stdcall(1));


            //Console.WriteLine(It_interface.com_init());

            //Console.WriteLine(It_interface.com_open());

            //Console.WriteLine(It_interface.com_checkstatus());

            
        }


        public int CallbackFun(string AType, string AContent)
        {

            Console.WriteLine("ssssssssss");
            Console.WriteLine(AType);
            Console.WriteLine(AContent);
            return 0;
        }
    }



   
}
