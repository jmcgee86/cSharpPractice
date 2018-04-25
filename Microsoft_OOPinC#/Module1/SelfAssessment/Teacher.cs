using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment
{

       internal class Teacher : Person
        {
        public static int teacherCount = 0;
   
        public Teacher(string _fname, string _lname, string _sex, int _age)
        {
            this.firstName = _fname;
            this.lastName = _lname;
            this.sex = _sex;
            this.age = _age;

            teacherCount++;
        }
        public Teacher(string _fname, string _lname, string _sex)
        {
            this.firstName = _fname;
            this.lastName = _lname;
            this.sex = _sex;

            teacherCount++;
        }
        public Teacher(string _fname, string _lname, int _age)
        {
            this.firstName = _fname;
            this.lastName = _lname;
            this.age = _age;

            teacherCount++;
        }

        public Teacher(string _fname, string _lname)
        {
            this.firstName = _fname;
            this.lastName = _lname;

            teacherCount++;
        }

        public String gradeTest()
        {
            //Console.WriteLine(this.firstName + " is grading the student tests");
            return this.firstName + " is grading the tests";
        }
    }
}