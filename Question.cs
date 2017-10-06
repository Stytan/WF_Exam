using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Exam
{
    public class Question
    {
        public enum QuestionType { SingleSelect, MultipleSelect, FillintheBlank }
        public Question() { }
        public int Id { set; get; }
        public string Text { set; get; }
        public QuestionType Type { set; get; }
        public int? TestId { set; get; }
        public virtual Test Test { set; get; }
        public virtual ICollection<Answer> Answers { set; get; }
        public override string ToString()
        {
            return Text;
        }
    }
}
