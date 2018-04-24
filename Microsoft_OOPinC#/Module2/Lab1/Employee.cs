using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Employee
    {
        // 3 private member variables: employeeName, employeeBaseSalary, and employeeId
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        
        //public properties
        public string Name
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }
    }

}