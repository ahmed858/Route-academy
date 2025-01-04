using OOP_Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam.Classes
{
    internal class TrueOrFalseQuestion : IQuestion
    {
        public string Header { get => "TrueOrFalseQuestion"; }
        public string Body { get => Body; set => Body = value; }
        public int Mark { get => Mark; set => Mark = value; }
        public int RightAnswerId { get => RightAnswerId; set => RightAnswerId = value; }

        public TrueOrFalseQuestion()
        {
            
            Body = string.Empty;
            Mark = 0;
            RightAnswerId = -1;
        }
        public TrueOrFalseQuestion( string _body, int _mark, int _rightAnswerId)
        {
            Body = _body;
            Mark = _mark;
            RightAnswerId = _rightAnswerId;
            
        }

        public bool checkAnswer(int userAnswerId)
        {
            return userAnswerId == RightAnswerId;
        }

      }
}
