using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Exam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            /*using (var db = new TestModel1Container())
            {
                TreeNode root = treeViewTestExplorer.Nodes.Add("root", "Tests");
                List<Test> Tests = db.TestSet.ToList();
                foreach(var test in db.TestSet.ToList())
                {
                    TreeNode testNode = root.Nodes.Add("test", test.Name);
                    int questionN = 1;
                    foreach(var question in test.Question)
                    {
                        testNode.Nodes.Add("question", "Question " + questionN++);
                    }
                }
            }*/
            User user = new User() { Login = "Ivanov", Password = "pass", FirstName = "Sergey", LastName = "Ivanov" };
            User user2 = new User() { Login = "Petrov", Password = "pass", FirstName = "Kiril", LastName = "Petrov" };
            Test test = new Test() { Name = "C++" };
            Question[] questions = new Question[]
            {
                new Question()
                {
                    Text ="Выберите верные утверждения",
                    Type =Question.QuestionType.MultipleSelect,
                    Answers = new Answer[]
                    {
                        new Answer() {Text="Стек и очередь работают по одному и тому же принципу", IsCorrect=false },
                        new Answer() {Text="В любой ситуации предпочтительней использовать список", IsCorrect=false },
                        new Answer() {Text="В любой ситуации предпочтительней использовать очередь", IsCorrect=false },
                        new Answer() {Text="Выбор очереди или списка зависит от конкретной решаемой задачи", IsCorrect=true }
                    }
                },
                new Question()
                {
                    Text ="Выберите верные утверждения",
                    Type =Question.QuestionType.MultipleSelect,
                    Answers = new Answer[]
                    {
                        new Answer() {Text="Стек работает по принципу LIFO", IsCorrect=true },
                        new Answer() {Text="Стек работает по принципу FIFO", IsCorrect=false },
                        new Answer() {Text="Стек работает по принципу SIFO", IsCorrect=false },
                        new Answer() {Text="Стек работает по принципу KIFO", IsCorrect=false }
                    }
                },
                new Question()
                {
                    Text ="Существует только один тип очереди. (напишите да или нет)",
                    Type =Question.QuestionType.FillintheBlank,
                    Answers = new Answer[]
                    {
                        new Answer() {Text="нет", IsCorrect=true }
                    }
                },
                new Question()
                {
                    Text ="Выберите верные утверждения",
                    Type =Question.QuestionType.MultipleSelect,
                    Answers = new Answer[]
                    {
                        new Answer() {Text="Шаблоны не несут никакой дополнительной ценности", IsCorrect=false },
                        new Answer() {Text="Принципы работы препроцессора и шаблонов одинаковый", IsCorrect=true },
                        new Answer() {Text="Шаблонная функция работает быстрее, чем её обычный аналог", IsCorrect=false },
                        new Answer() {Text="Шаблонная функция должна иметь в качестве параметра хотя бы одну переменную псевдо-типа", IsCorrect=false }
                    }
                },
                new Question()
                {
                    Text =@"Отработает ли следующий код?

#include <iostream>
using namespace std;
class A
    {
        public:
    int x;
        class B
        {
            public:
        int y;
        };
    };
    void main()
    {
        A a;
        a.B::y = 5;
        cout << a.B::y << '\n';",
                    Type =Question.QuestionType.FillintheBlank,
                    Answers = new Answer[]
                    {
                        new Answer() { Text="нет", IsCorrect=true }
                    }
                },
                new Question()
                {
                    Text ="Какие ключевые слова используются при обработке исключительных ситуаций",
                    Type =Question.QuestionType.MultipleSelect,
                    Answers = new Answer[]
                    {
                        new Answer() { Text="help", IsCorrect=false },
                        new Answer() { Text="call", IsCorrect=false },
                        new Answer() { Text="police", IsCorrect=false },
                        new Answer() { Text="911", IsCorrect=false },
                        new Answer() { Text="try", IsCorrect=true },
                        new Answer() { Text="catch", IsCorrect=true },
                        new Answer() { Text="throw", IsCorrect=true }
                    }
                },
                new Question()
                {
                    Text ="Выберите неверное утверждение о механизме обработки исключительных ситуаций",
                    Type =Question.QuestionType.SingleSelect,
                    Answers = new Answer[]
                    {
                        new Answer { Text="Одному блоку try соответствует один и более блоков catch", IsCorrect=false },
                        new Answer { Text="Блоки try могут быть вложенными друг в друга", IsCorrect=false },
                        new Answer { Text="Блок catch(…) может быть расположен в любом месте последовательности блоков catch", IsCorrect=true },
                        new Answer { Text="Ключевое слово throw используется для генерации исключения", IsCorrect=false }
                    }
                },
                new Question()
                {
                    Text ="Какие из ниже перечисленных принципов можно назвать основными в ООП",
                    Type =Question.QuestionType.MultipleSelect,
                    Answers = new Answer[]
                    {
                        new Answer() {Text="Алгоритмизация", IsCorrect=false },
                        new Answer() {Text="Наследование", IsCorrect=true },
                        new Answer() {Text="Инкапсуляция", IsCorrect=true },
                        new Answer() {Text="Полиморфизм", IsCorrect=true },
                        new Answer() {Text="Металлизация", IsCorrect=false }
                    }
                },
                new Question()
                {
                    Text ="Члены класса, объявленные в секции private",
                    Type =Question.QuestionType.SingleSelect,
                    Answers = new Answer[]
                    {
                        new Answer() {Text="Могут быть только свойствами, но не методами", IsCorrect=false },
                        new Answer() {Text="Доступны только в методах данного класса", IsCorrect=true },
                        new Answer() {Text="Это константы", IsCorrect=false }
                    }
                },
                new Question()
                {
                    Text ="Члены класса, объявленные в секции public",
                    Type =Question.QuestionType.SingleSelect,
                    Answers = new Answer[]
                    {
                        new Answer() {Text="Доступны только в методах данного класса", IsCorrect=false },
                        new Answer() {Text="Доступны только извне", IsCorrect=false },
                        new Answer() {Text="Доступны только глобальным функциям", IsCorrect=false },
                        new Answer() {Text="Доступны всем", IsCorrect=true }
                    }
                }
                };

            /*Answer[] answers = new Answer[]
            {
                new Answer() {Text="" }
            }*/


            using (TestContext db = new TestContext())
            {
                db.Users.Add(user);
                db.Users.Add(user2);
                //db.Tests.Add(test);
                test.Questions = questions;
                db.Tests.Add(test);
                db.SaveChanges();
            }
        }

    }
}
