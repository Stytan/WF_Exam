using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Exam
{
    public class Answer
    {
        public Answer() { }
        public int Id { set; get; }
        public string Text { set; get; }
        /*public int? QuestionId { set; get; }
        public virtual Question Question { set; get; }*/
        public bool IsCorrect { set; get; }
        public override string ToString()
        {
            return Text;
        }
    }
}
