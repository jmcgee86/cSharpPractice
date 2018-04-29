using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAssessment
{
    internal class Student : Person
    {
        public static int studentCount = 0;

        public Student(string _fname, string _lname, string _sex, int _age)
        {
            this.firstName = _fname;
            this.lastName = _lname;
            this.sex = _sex;
            this.age = _age;

            studentCount++;
        }

        public Student(string _fname, string _lname, string _sex)
        {
            this.firstName = _fname;
            this.lastName = _lname;
            this.sex = _sex;

            studentCount++;
        }

        public Student(string _fname, string _lname, int _age)
        {
            this.firstName = _fname;
            this.lastName = _lname;
            this.age = _age;

            studentCount++;
        }

        public Student(string _fname, string _lname)
        {
            this.firstName = _fname;
            this.lastName = _lname;

            studentCount++;
        }

        public Student()
        {
            studentCount++;
        }

        public String takeTest()
        {
            return this.firstName + " is taking a test";
        }
            
    }
}