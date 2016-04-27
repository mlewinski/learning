using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation
{
    class Testing
    {
        private string value;
        private string name;
        private int code;
        public Testing()
        {
            value = "Default";
            name = "Default";
            code = 0;
        }
        /// <summary>
        /// Testing documentation class
        /// </summary>
        /// <param name="value">Value to be passed</param>
        /// <param name="name">Name of the object</param>
        /// <param name="code">Code indetifying the object</param>
        public Testing(string value, string name, int code)
        {
            this.value = value;
            this.name = name;
            this.code = code;
        }
    }
}
