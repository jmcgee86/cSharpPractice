using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAssessment
{
    public class Degree
    {

        public Course[] courses = new Course[5];

        public string degree {get; set;}
        public string course {get; set;}

        public Degree(string _degree){
            this.degree = _degree;
        }
    }
}