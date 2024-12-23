using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session02_Assignment
{
 
    public enum SecurityLevelEnum
    {
        guest, Developer, secretary , DBA
    }
    internal class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public SecurityLevelEnum securityLevel { get; set; }
        public Decimal salary { get; set; }
        public HireDate hireDate { get; set; }
        public string Gender { get; set; }

        public Employee(int iD, string name, SecurityLevelEnum securityLevel, decimal salary, HireDate hireDate, string gender)
        {
            if (iD <= 0)
                throw new ArgumentOutOfRangeException(nameof(iD), " ID must be greater than Zero");
            if (name.Length == 0)
                throw new ArgumentException(nameof(name), " name Can not be empty");
            if (salary < 3000)
                throw new ArgumentOutOfRangeException(nameof(salary), " Salary must be greater than 3000");
            if (gender != "F" && gender != "M")
                throw new ArgumentOutOfRangeException(nameof(gender), " gender must be F Or M");



            this.ID = iD;
            ID = iD;
            Name = name;
            this.securityLevel = securityLevel;
            this.salary = salary;
            this.hireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1}, HireDate:{2},Salary:{3}, securityLevel:{4},Gender:{5}", ID, Name, this.hireDate, salary, securityLevel, Gender);
        }
    }

}
