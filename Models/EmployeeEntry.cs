using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_API_Assignment.Models
{
    public class EmployeeEntry
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int DeptId { get; set; }

        //public EmployeeEntry(int id,string name,int salary,int deptid)
        //{
        //    this.EmpId = id;
        //    this.Name = name;
        //    this.Salary = salary;
        //    this.DeptId = deptid;
        //}
        public EmployeeEntry(string name, int salary, int deptid)
        {
            
            this.Name = name;
            this.Salary = salary;
            this.DeptId = deptid;
            
        }
    }
}
