using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAssessment
{
    public class Course
    {

        // public Student[] students = new Student[Student.studentCount + 1];
        internal Student[] students = new Student[5];

        //public Teacher[] teachers = new Teacher[Teacher.teacherCount + 1];
        internal Teacher[] teachers = new Teacher[5];

        public string course {get; set;}

        public Course(string _course){
            this.course = _course;
        }
    }
}