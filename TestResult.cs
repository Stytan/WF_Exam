using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Exam
{
    public class TestResult
    {
        public TestResult() { }
        public int Id { set; get; }
        public int? UserId { set; get; }
        public virtual User User { set; get; }
        public virtual ICollection<Answer> Answers { set; get; }
    }
}
