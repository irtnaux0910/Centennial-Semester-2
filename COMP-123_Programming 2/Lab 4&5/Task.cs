using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanN_301388576_lib
{
    public class Task
    {
        public string Description
        {
            get { return Description; }
            set { Description = value; }
        }
        public DateTime DueDate
        {
            get { return DueDate; }
            set { DueDate = value; }
        }
        private Guid Id
        {
            get { return Id; }
            set { Id = value; }
        }
        public bool IsDone
        {
            get { return IsDone; }
            set { IsDone = value; }
        }
        public Task(string description)
        {
            this.Description = description;
            this.DueDate = DateTime.MinValue;
            this.IsDone = false;
            this.Id = new Guid();
        }         
    }
}
