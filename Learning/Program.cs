using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle
            {
                WIDTH = 10,
                LENGTH = 20
            };
            r.Display();

            Type t = typeof(Rectangle);
            object[] attributes = t.GetCustomAttributes(true);
            foreach (object obj in attributes)
            {
               // DebugInfo info = obj as DebugInfo;
                if (obj is DebugInfo)
                {
                    DebugInfo info = (DebugInfo)obj;
                    Console.WriteLine("Bug No: {0}",info.BUGNO);
                    Console.WriteLine("Developer: {0}", info.DEVELOPER);
                    Console.WriteLine("Last view: {0}", info.LASTREVIEW);
                    Console.WriteLine("Message: {0}", info.MESSAGE);
                }
            }

            System.Reflection.PropertyInfo[] propertyInfos = t.GetProperties();
            foreach(PropertyInfo obj in propertyInfos)
            {
                DebugInfo item = obj.GetCustomAttributes(false).First() as DebugInfo;
                if (item != null)
                {
                    Console.WriteLine("Bug No: {0}", item.BUGNO);
                    Console.WriteLine("Developer: {0}", item.DEVELOPER);
                    Console.WriteLine("Last view: {0}", item.LASTREVIEW);
                    Console.WriteLine("Message: {0}", item.MESSAGE);
                }
            }

            System.Reflection.MethodInfo[] methodInfos = t.GetMethods();
            foreach (MethodInfo obj in methodInfos)
            {
                DebugInfo item = obj.GetCustomAttributes(false).First() as DebugInfo;
                if (item != null)
                {
                    Console.WriteLine("Bug No: {0}", item.BUGNO);
                    Console.WriteLine("Developer: {0}", item.DEVELOPER);
                    Console.WriteLine("Last view: {0}", item.LASTREVIEW);
                    Console.WriteLine("Message: {0}", item.MESSAGE);
                }
            }
            Console.ReadKey();
        }
    }
}
