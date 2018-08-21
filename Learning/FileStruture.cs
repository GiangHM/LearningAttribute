using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    
    class FileStruture
    {
        [AttributeFileStruture(STARTPOS = 0,ENDPOS = 2, ISCHARACTER = false,ISNUMBERIC = true)]
        public float WIDTH { get; set; }

        [AttributeFileStruture(STARTPOS = 3, ENDPOS = 5, ISCHARACTER = false,ISNUMBERIC = true)]
        public float LENGTH { get; set; }

        [AttributeFileStruture(STARTPOS = 6, ENDPOS = 8, ISCHARACTER = false, ISNUMBERIC = true)]
        public float AREA { get; set; }
        
        public void Display()
        {
            Console.WriteLine("Length: {0}", WIDTH);
            Console.WriteLine("Width: {0}", LENGTH);
            Console.WriteLine("Area: {0}", AREA);
        }
    }
}
