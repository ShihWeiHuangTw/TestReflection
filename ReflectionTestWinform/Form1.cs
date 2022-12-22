using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionTestWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TestLib.dll
            Assembly a = null;
            try
            {
                //a = Assembly.LoadFrom(@"D:\My_PRJ\TestLib\ReflectionTestConsole\bin\Debug\TestLib.dll");
                a = Assembly.LoadFrom(@"TestLib.dll");
                Console.WriteLine("Load Dll Success");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Type classType = a.GetType("TestLib.FormCal");

            object obj = Activator.CreateInstance(classType);

            Form form = obj as Form;

            form.Show();

            MethodInfo mi = classType.GetMethod("SetValue");

            mi.Invoke(obj, new object[] { 3, 4 });


            MethodInfo btn = classType.GetMethod("button1_Click");

            btn.Invoke(obj, new object[] { null, null });
        }
    }
}
