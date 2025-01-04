
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam.Classes
{
    internal class MCQ_Question : Question
    {
        


        #region Constructors
        public MCQ_Question(Answer[] _AnswerList, string _body, int _mark, int _rightAnswerId)
        {
            Body = _body;
            Mark = _mark;
            RightAnswerId = _rightAnswerId;
            AnswerList = _AnswerList;
        }
        #endregion


        #region Methods


        #endregion
    }
}