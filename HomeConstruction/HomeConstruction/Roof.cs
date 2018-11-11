using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    public class Roof : IPart
    {
        public string Material { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Roof(string material, int length, int height, int width)
        {
            Material = material;
            Length = length;
            Height = height;
            Width = width;
        }
    }
}
