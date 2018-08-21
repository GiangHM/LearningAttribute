using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    [DebugInfo(BUGNO = 1, DEVELOPER = "For class", LASTREVIEW = "19/05/2018", MESSAGE = "For class")]
    class Rectangle
    {
        [DebugInfo(BUGNO = 2,DEVELOPER ="For properties",LASTREVIEW ="19/05/2018",MESSAGE = "For properties")]
        public float WIDTH { get; set; }

        [DebugInfo(BUGNO = 3, DEVELOPER = "For properties", LASTREVIEW = "19/06/2018", MESSAGE = "For properties")]
        public float LENGTH { get; set; }

        [DebugInfo(BUGNO = 4, DEVELOPER = "For Method", LASTREVIEW = "19/06/2018", MESSAGE = "For Method")]
        public float GetArea()
        {
            return WIDTH * LENGTH;
        }
        [DebugInfo(BUGNO = 5, DEVELOPER = "For Method", LASTREVIEW = "19/06/2018", MESSAGE = "For Method")]
        public void Display()
        {
            Console.WriteLine("Length: {0}", WIDTH);
            Console.WriteLine("Width: {0}", LENGTH);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}
