using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemistry
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Composition { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
