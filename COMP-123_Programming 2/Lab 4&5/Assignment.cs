using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanN_301388576_lib
{
    class Assignment:Evaluation
    {
        public bool IsGroupAssignment
        {
            get
            {
                return this.IsGroupAssignment;
            }
            set
            {
                this.IsGroupAssignment = value;
            }
        }
       public Assignment(Course course, byte weight, DateTime dueDate = default, bool isGroupAssignment = false) : base(course, EvaluationType.Assignment, weight)
        {
            course = this.Course;
            this.Weight = weight;
            this.DueDate = dueDate;
            this.IsGroupAssignment = isGroupAssignment;
        }
        public Task AddTask(string description)
        {
            Task task = new Task(description);
           this.Tasks.Add(task);
           return task;
        }
        public override string ToString()
        {
            return $"";
        }

    }
}
