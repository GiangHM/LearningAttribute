using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple = true)]
    public class DebugInfo:Attribute
    {
        /// <summary>
        /// Bug number
        /// </summary>
        public int BUGNO { get; set; }
        /// <summary>
        /// Name of developer
        /// </summary>
        public string DEVELOPER { get; set; }
        /// <summary>
        /// Last review
        /// </summary>
        public string LASTREVIEW { get; set; }
        /// <summary>
        /// Message
        /// </summary>
        public string MESSAGE { get; set; }
    }
}
