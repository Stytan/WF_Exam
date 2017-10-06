using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Exam
{
    public class TestContext : DbContext 
    {
        public TestContext() : base("TestConnString")
        {
            Database.SetInitializer<TestContext>(new DropCreateDatabaseIfModelChanges<TestContext>());
        }
        public DbSet<User> Users { set; get; }
        public DbSet<Test> Tests { set; get; }
        public DbSet<Question> Questions { set; get; }
        public DbSet<Answer> Answers { set; get; }
        public DbSet<TestResult> TestResults { set; get; }
    }
}
