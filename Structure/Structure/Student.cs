using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public struct Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupName { get; set; }
        public double AvgValue { get; set; }
        public int Profit { get; set; }
        public Sex Sex { get; set; }
        public EduType EduType { get; set; }
    }
    public enum Sex
    {
        male,
        female
    }
    public enum EduType
    {
        stationar,
        halfstationar,
        home
    }
    
}
