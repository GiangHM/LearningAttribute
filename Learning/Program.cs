using System;
using System.Linq;
using System.Reflection;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStruture r = new FileStruture
            {
                WIDTH = 10,
                LENGTH = 20,
                AREA = 200
            };
            r.Display();

            Type t = typeof(FileStruture);
            PropertyInfo[] propertyInfos = t.GetProperties();
            foreach (PropertyInfo obj in propertyInfos)
            {
                AttributeFileStruture item = obj.GetCustomAttributes(false).First() as AttributeFileStruture;
                if (item != null)
                {
                    Console.WriteLine("Start position is: {0}", item.STARTPOS);
                    Console.WriteLine("End position is: {0}", item.ENDPOS);
                    Console.WriteLine("Is it character: {0}", item.ISCHARACTER);
                    Console.WriteLine("Is it numberic: {0}", item.ISNUMBERIC);
                }
            }


            //object[] attributes = t.GetCustomAttributes(true);
            //foreach (object obj in attributes)
            //{
            //   // DebugInfo info = obj as DebugInfo;
            //    if (obj is AttributeFileStruture)
            //    {
            //        AttributeFileStruture info = (AttributeFileStruture)obj;
            //        Console.WriteLine("Bug No: {0}",info.BUGNO);
            //        Console.WriteLine("Developer: {0}", info.DEVELOPER);
            //        Console.WriteLine("Last view: {0}", info.LASTREVIEW);
            //        Console.WriteLine("Message: {0}", info.MESSAGE);
            //    }
            //}


            //System.Reflection.MethodInfo[] methodInfos = t.GetMethods();
            //foreach (MethodInfo obj in methodInfos)
            //{
            //    AttributeFileStruture item = obj.GetCustomAttributes(false).First() as AttributeFileStruture;
            //    if (item != null)
            //    {
            //        Console.WriteLine("Bug No: {0}", item.BUGNO);
            //        Console.WriteLine("Developer: {0}", item.DEVELOPER);
            //        Console.WriteLine("Last view: {0}", item.LASTREVIEW);
            //        Console.WriteLine("Message: {0}", item.MESSAGE);
            //    }
            //}
            Console.ReadKey();
        }
    }
}
