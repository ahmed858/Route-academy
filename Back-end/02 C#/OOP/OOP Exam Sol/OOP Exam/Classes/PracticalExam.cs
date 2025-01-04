using OOP_Exam.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam.Classes
{
    internal class PracticalExam : BaseExam
    {
        public MCQ_Question[] ExamQuestions {  get; set; }
        public override void StartExam()
        {
            throw new NotImplementedException();
        }
    }
}
