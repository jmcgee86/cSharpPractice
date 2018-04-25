using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment
{

    abstract class Person
    {
        private string _firstName;
        private string _lastName;
        private string _sex;
        private int _age;
        public string firstName
        {
            get
            {
                return _firstName;
            } 
            set
            {
                _firstName = value;
            }
        }
        public string lastName
        {
            get
            {
                return _lastName;
            } 
            set
            {
                _lastName = value;
            }
        }

        public string sex 
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }

        public int age 
        {
            get
            {
                return _age;
            } 
            set
            {
                _age = value;
            }
        }



    }
}