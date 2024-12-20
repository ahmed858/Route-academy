using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_Demo
{
    internal class Employee
    {
        #region Attributes
        public int Id;
        private string Name;
        private Decimal salary;
        #endregion
        #region Constructors 
        public Employee(int _id, string _name, Decimal _salary)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;

        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nSalary{Salary}";
        }

        #endregion

        #region Encapsulation
        // seprate data defination [attributes] from it is use
        // (Getter/ setter - Property -Indexer)

        //getter 
        public string GetName()
        {
            return Name;
        }
        //setter 
        public void setName(string _name)
        {
            Name = _name.Length <= 5 ? _name : _name.Substring(0, 5);//control 

            //Name = _name ;

        }


        // Applying Property
        // 2.1 Full Property
        public Decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;// < 4000 ? value : 40000;
            }
        }
        public int age { get; set; }
        #endregion
    }

}
