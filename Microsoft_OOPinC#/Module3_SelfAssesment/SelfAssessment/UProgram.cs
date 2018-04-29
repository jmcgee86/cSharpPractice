using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAssessment
{
    public class UProgram
    {
        public string programName{get; set;}
        public Degree[] degrees = new Degree[5];

        public UProgram(string _programName)
        {
            this.programName = _programName;
        }

    }
}