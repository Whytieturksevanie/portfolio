using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordtrainer
{
    class Translates
    {
        public string Dutch { get; set; }
        public string German { get; set; }

        public override string ToString()
        {
            return German + " = " + Dutch;
        }
    }
}
