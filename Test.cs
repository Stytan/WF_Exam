using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Exam
{
    public class Test
    {
        public Test()
        {
            Questions = new List<Question>();
        }
        public int Id { set; get; }
        public string Name { set; get; }
        public virtual ICollection<Question> Questions { set; get; }
        public override string ToString()
        {
            return Name;
        }
    }
}
