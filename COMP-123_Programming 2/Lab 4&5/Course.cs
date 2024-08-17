using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanN_301388576_lib
{
    public class Course
    {
        private string code;
        private List<Evaluation> evaluations;
        private uint id;
        private string name;
        private byte semester;
        private List<Task> tasks;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public List<Evaluation> Evaluations
        {
            get { return evaluations; }
        }
        public ushort Grade
        {
            get
            {
                ushort result = 0;
                foreach (Evaluation evaluation in evaluations)
                {
                    result += (ushort)(evaluation.Weight * evaluation.Grade);
                }
                return result;
            }
        }
        public uint Id
        {
            get { return id; }
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public byte Semester 
        { 
            get { return semester; }
            set { semester = value;  }
        }
        public List<Task> Tasks 
        {
            get { return tasks; }
        }
        public void AddEvaluation(EvaluationType type, byte weight, string name, DateTime dueDate = default)
        {
            Evaluation evaluation;
            switch (type)
            {
                case EvaluationType.Assignment:
                    evaluation = new Assignment(this, weight, dueDate);
                    break;
                case EvaluationType.Quiz:
                    evaluation = new Quiz(this, weight, 1);
                    break;
                default:
                    evaluation = new Evaluation(this, type, weight);
                    break;
            }
            evaluation.Name = name;
            evaluations.Add(evaluation);
        }
        public Task AddTask(string description)
        {
            Task task = new Task(description);
            this.Tasks.Add(task);
            return task;
        }       

        public static string TasksToString(List<Task> tasks)
        {
            foreach (Task task in tasks)
            {
                Console.WriteLine(task.ToString()+ ",");
            }
            return tasks.ToString();
           
        }
        public override string ToString()
        {
            return $"{name}:{semester}:{id}:{code}";
        }
    }
}
