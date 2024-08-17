using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanN_301388576_Lab2
{
    public class Course
    {
        private string code;
        private List<Evaluation> evaluations = new List<Evaluation>();
        private uint id;
        private string name;
        private byte semester;
        private List<Task> tasks = new List<Task>();

        public string Code { get;set; }
        public List<Evaluation> Evaluations { get; }
        
        public ushort Grade
        {
            get
            {
                ushort gradeResult = (ushort)this.Evaluations.Sum(e => e.Weight * e.Grade);
                return gradeResult;
            }
        }
        public uint Id { get; }
        
        public string Name  { get;set; }
        public byte Semester { get; set; }
        
        public List<Task> Tasks
        {
            get
            {
                if (tasks == null)
                {
                    tasks = new List<Task>();
                }
                return this.tasks;
            }
        }
        public void AddEvaluation(EvaluationType evaluationType, byte weight, string name)
        {
            Evaluation evaluation = new Evaluation(new Course(), evaluationType, weight);
            evaluation.Name = name;
            if (this.evaluations == null)
            {
                this.evaluations = new List<Evaluation>();
            }
            this.evaluations.Add(evaluation);
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
            string result = $"({this.name}) all tasks:";
            foreach (string task in tasks)
            {
                result += "\n\t" + task;
            }
            return result;
        }
        public override string ToString()
        {
            string evaluations = string.Empty;
            if (this.Evaluations != null && this.Evaluations.Count > 0)
            {
                foreach (Evaluation evaluation in this.Evaluations)
                {
                    evaluations += string.Format(evaluation.ToString());
                }
            }
            return string.Format("{0}\nEvaluations:\n{1}Total Grade: {2}", this.Name, evaluations, this.Grade);
        }
    }
}
