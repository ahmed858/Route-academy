using OOP_Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam.Abstract_Classes
{
    internal abstract class BaseExam
    {
        public int Time { get; set; }
        public int NumberOfQuestion { get; set; }
        public IQuestion[] Qustions { get; set; }
        public abstract void StartExam();
    }
}
