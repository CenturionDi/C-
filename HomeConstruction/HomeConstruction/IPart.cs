using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    public interface IPart
    {
         int Length { get; set; }
         int Height { get; set; }
         int Width { get; set; }
    }
}
