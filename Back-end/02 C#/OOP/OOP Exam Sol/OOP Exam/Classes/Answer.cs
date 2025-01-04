using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam.Classes
{
    internal class Answer
    {
        #region Properties
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        #endregion
        public Answer( )
        {
            AnswerId = 0;
            AnswerText = "";
        }
        public Answer(int _id, string _AnsText)
        {
            AnswerId = _id;
            AnswerText = _AnsText;
        }

        #region Operator Overloading
        public static bool operator ==(Answer left, Answer Right)
        {
            return left.AnswerText == Right.AnswerText;
        }
        public static bool operator !=(Answer left, Answer Right)
        {
            return left.AnswerText != Right.AnswerText;

        }
        #endregion

    }
}
