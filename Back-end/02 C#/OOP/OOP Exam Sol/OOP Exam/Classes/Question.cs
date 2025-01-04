using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam.Classes
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get ; set ; }
        public int Mark { get ; set ; }
        public Answer[] AnswerList { get; set; }
        public int RightAnswerId { get ; set ; }

        public Question(string _header,string _body, int _mark, Answer[]_answersList, int _RightAnwserId) 
        {
            Header = _header;
            Body = _body;
            Mark = _mark;
            AnswerList = _answersList;
                RightAnswerId = _RightAnwserId;
        }
    }
}
