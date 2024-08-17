using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XuanN_301388576_Lab2;

namespace XuanN_301388576_Lab2
{
    public class Evaluation
   {
       private Course course;
       private DateTime dueDate;
       private byte grade;
       private Guid id;
       private string name;
       private List<Task> tasks;
       private string textFile;
       private EvaluationType type;
       private byte weight;

       public Course Course{ get;}
       public DateTime DueDate{ get; set; }
       public byte Grade{ get; set; }
       public Guid Id { get;set; }
       public string Name{ get; set; }
       public List<Task> Tasks
       {
           get
           {
               if(this.tasks == null)
               {
                   this.tasks = new List<Task>();
               }
               return this.tasks;
           }
       }
       public string TextFile{ get; set; }
       public EvaluationType Type{ get; set; }
       public byte Weight { get;set; }
       
       public Evaluation(Course course, EvaluationType type, byte weight)
       {
           this.course = course;
           this.Type = type;
           this.Weight = weight;
       }       
       public Task AddTask(string description)
       {
           Task task = new Task(description);
           this.Tasks.Add(task);
           return task;
       }      
       public string AllTasksToString()
       {
           List<string> tasks = this.Tasks.Select(t => $"{t.ToString()}").ToList();
           string result = $"All tasks for Evolution:{this.name}";
           foreach (string task in tasks)
           {
               result += " " + task;
           }
           return result;
       }
       public override string ToString()
       {
           string evaluationType = string.Empty;
           switch (this.Type)
           {
               case EvaluationType.Assignment:
                   evaluationType = "Assignment";
                   break;
               case EvaluationType.Test:
                   evaluationType = "Test";
                   break;
               case EvaluationType.Quiz:
                   evaluationType = "Quiz";
                   break;
               case EvaluationType.Discussion:
                   evaluationType = "Discussion";
                   break;
               case EvaluationType.Project:
                   evaluationType = "Project";
                   break;
               default:
                   evaluationType = "No information";
                   break;
           }
            return $"Evaluation: {Name}, Type: {type}), Due: {dueDate.ToString("yyyy-MM-dd")}, Weight: {weight}%";
        }
   }

}
