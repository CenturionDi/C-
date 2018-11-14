using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class Book
    {
        [DisplayName("Name:")]
        public string Name { get; set; }
        [DisplayName("Price")]
        public double Price { get; set; }
        [DisplayName("Author")]
        public string Author { get; set; }
        public int PublishYear { get; set; }
    }
}
