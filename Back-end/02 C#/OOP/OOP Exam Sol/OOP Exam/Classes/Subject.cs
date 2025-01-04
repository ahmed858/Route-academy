using OOP_Exam.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Exam.Classes
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public BaseExam SubjectExam {  get; set; }

            

    }
}
