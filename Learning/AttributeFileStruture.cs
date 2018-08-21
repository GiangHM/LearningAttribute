using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple = true)]
    public class AttributeFileStruture:Attribute
    {
        /// <summary>
        /// Start position
        /// </summary>
        public int STARTPOS { get; set; }
        /// <summary>
        /// End position
        /// </summary>
        public int ENDPOS { get; set; }
        /// <summary>
        /// Is it character
        /// </summary>
        public bool ISCHARACTER { get; set; }
        /// <summary>
        /// Is it numberic
        /// </summary>
        public bool ISNUMBERIC { get; set; }
    }
}
