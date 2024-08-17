using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanN_301388576_lib
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
        public Course Course
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public string EvaluationText { get { return textFile; } }
        public byte Grade
        {
            get { return grade; }
            set { grade = value; }            
        }
        public Guid Id { get { return id; }    }
        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }
        public List<Task> Tasks { get { return tasks; } }
        public string TextFile 
        {
            get { return textFile; }
            set { textFile = value; }
        }
        public EvaluationType Type 
        {
            get { return type; }
        }
        public byte Weight
        { 
            get { return weight; } 
            set { weight = value; }
        }
        public Evaluation(Course course, EvaluationType type, byte weight)
        {
            this.course = course;
            this.type = type;            
            this.weight = weight;
            this.tasks = new List<Task>();
        }        

        public Task AddTask(string description)
        {
            Task task = new Task(description);
            this.Tasks.Add(task);
            return task;
        }
        public string TaskToString()
        {
            foreach (Task task in tasks)
            {
                Console.WriteLine(task.ToString() + ", ");
            }
            return tasks.ToString();
        }
        public override string ToString()
        {
            return $"{name}:{type}:{weight}";
        }
        TaskManager.Save(task);
    }
}
