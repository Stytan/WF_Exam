﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Exam
{
    public class User
    {
        public User() { }
        public int Id { set; get; }
        public string Login { set; get; }
        public string Password { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public override string ToString()
        {
            return FirstName + LastName;
        }
    }
}
