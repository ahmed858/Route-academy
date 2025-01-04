using OOP_Exam.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam.Classes
{
    internal class FinalExam : BaseExam
    {
        public MCQ_Question[] MCQ_Questions {  get; set; }
        public TrueOrFalseQuestion[] TrueOrFalseQuestions {  get; set; }
        public override void StartExam()
        {
            
        }
    }
}
