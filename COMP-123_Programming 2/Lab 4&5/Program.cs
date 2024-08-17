using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XuanN_301388576_lib;
using Task = XuanN_301388576_lib.Task;
/*Xuan Tri Nguyen - 301388576*/
namespace XuanN_301388576_Lab4_5
{
    internal class Program
    {
        static Task Main(string[] args)
        {
            Course course1 = new Course();
            course1.Name = "COMP123";
            course1.AddEvaluation(EvaluationType.Assignment, 10, "E1");
            Course course2 = new Course();
            course2.Name = "COMP125";
            course2.AddEvaluation(EvaluationType.Quiz, 15, "E2");
            Console.WriteLine(course1.ToString());
            Console.WriteLine(course2.ToString());
            course1.AddEvaluation(EvaluationType.Assignment, 5, "A1");
            course1.AddEvaluation(EvaluationType.Assignment, 5, "A2");
            course1.AddEvaluation(EvaluationType.Quiz, 7, "Q1");
            course1.AddEvaluation(EvaluationType.Test, 10, "T1");
            Console.WriteLine(course1.ToString());
            course2.AddEvaluation(EvaluationType.Assignment, 5, "A1");
            course2.AddEvaluation(EvaluationType.Assignment, 5, "A2");
            course2.AddEvaluation(EvaluationType.Assignment, 5, "Q1");
            course2.AddEvaluation(EvaluationType.Test, 10, "T1");
            Console.WriteLine(course2.ToString());
            course1.Evaluations[1].DueDate = DateTime.Now.AddDays(10);
            course1.Evaluations[1].Grade = 4;
            course1.Evaluations[2].Grade = 6;
            Console.WriteLine(course1.ToString());
            XuanN_301388576_lib.Task task1 = course1.AddTask("Read chapter 1");
            task1.DueDate = DateTime.Now.AddDays(7);
            Task task2 = course1.AddTask("Read chapter 2");
            Console.WriteLine(course1);
            course1.Evaluations[2].AddTask("Start assignment");
            course1.Evaluations[2].AddTask("Write Main() method");
            Console.WriteLine(course1.Evaluations[2].TaskToString());
            course1.Evaluations[2].Tasks[0];
            MyDay myDay = MyDay.NewDay();
            myDay.AddDayTask(course1.Tasks[0]);
            myDay.AddDayTask(course1.Tasks[1]);
            List<Task> tasksOfMyDay = myDay.TodaysTasks;
            Console.WriteLine($"My day {myDay.Date} all tasks:");
            foreach (Task task in tasksOfMyDay)
            {
                Console.WriteLine($"{task.ToString(),8}");
            }
            TaskManager.Save(task1.AllTasksToString );
            TaskManager.Save(task2 );
            TaskManager.Load(task1 );
            TaskManager.Load(task2 );
            CourseManager.Save(course1);
            CourseManager.Save(course2);
            CourseManager.Load(course1);
            CourseManager.Load(course2);


        }
    }
}
