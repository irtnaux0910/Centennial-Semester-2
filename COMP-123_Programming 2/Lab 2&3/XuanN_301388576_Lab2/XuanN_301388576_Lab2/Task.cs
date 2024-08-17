using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanN_301388576_Lab2
{
    public struct Task
    {
        public string Description;
        public DateTime DueDate;
        private bool done;       

        public bool Done
        {
            get
            {
                return this.done;
            }
            set
            {
                this.done = value;
            }
        }
        public Task(string description)
        {
            this.Description = description;
            this.DueDate = DateTime.MaxValue;
            this.done = false;
        }
        public void SetDone()
        {
            this.Done = true;
        }

        public override string ToString()
       {
           return string.Format("{0} - {1}", Description, this.Done ? "Done" : "Not Done");
       }
    }

}
