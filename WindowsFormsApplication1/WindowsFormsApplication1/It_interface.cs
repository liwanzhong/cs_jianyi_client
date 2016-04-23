using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;



namespace WindowsFormsApplication1
{
    public class It_interface
    {


        [DllImport("lt_interface.dll", CharSet = CharSet.Ansi, EntryPoint = "reg_callback_stdcall", ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int reg_callback_stdcall(callback_func callback);

        public delegate int callback_func(string AType, string AContent); 

        public static callback_func callback;




        [DllImport("lt_interface.dll", CharSet = CharSet.Ansi, EntryPoint = "com_init", ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int com_init();


        [DllImport("lt_interface.dll", CharSet = CharSet.Ansi, EntryPoint = "com_open", ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int com_open();

        [DllImport("lt_interface.dll", CharSet = CharSet.Ansi, EntryPoint = "com_checkstatus", ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int com_checkstatus();



        [DllImport("lt_interface.dll", CharSet = CharSet.Ansi, EntryPoint = "com_close", ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int com_close();

        [DllImport("lt_interface.dll", CharSet = CharSet.Ansi, EntryPoint = "com_movein", ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int com_movein();

        [DllImport("lt_interface.dll", CharSet = CharSet.Ansi, EntryPoint = "com_moveout", ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int com_moveout();


        [DllImport("lt_interface.dll", CharSet = CharSet.Ansi, EntryPoint = "test_callback_stdcall", ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int test_callback_stdcall(int size);





        public int CallbackFun(string AType, string AContent)
        {

            Console.WriteLine("ssssssssss");
            return 0;
        }


        public void test()
        {
            reg_callback_stdcall(CallbackFun);
        }

       
    }
}
