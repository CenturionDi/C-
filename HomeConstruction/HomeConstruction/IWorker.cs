using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    interface IWorker
    {
        string Specialization { get; set; }
        string FullName { get; set; }
        void BuildPart(House house);
        string CheckTheStage(House house);
    }
}
