using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class DisplayName : Attribute
    {
        public string Name { get; set; }


        public DisplayName()
        { }

        public DisplayName(string name)
        {
            Name = name;
        }
    }
}
