using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestLib.dll
            Assembly a = null;
            try
            {
                a = Assembly.LoadFrom(@"D:\My_PRJ\TestLib\ReflectionTestConsole\bin\Debug\TestLib.dll");
                Console.WriteLine("Load Dll Success");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            
            Type classType = a.GetType("TestLib.FormCal");

            object obj = Activator.CreateInstance(classType);

            MethodInfo mi = classType.GetMethod("SetValue");

            mi.Invoke(obj, new object[]{ 3, 4 });
            //mi.Invoke(obj, null);


            //MethodInfo btn = classType.GetMethod("button1_Click");

            //btn.Invoke(obj, null);

        }
    }
}
