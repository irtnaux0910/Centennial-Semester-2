using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanN_301388576_lib
{
    public class MyDay
    {
        private static MyDay currentDay;
        private DateTime date;
        private List<Task> todaysTasks;
        public List<Task> TodaysTasks { get { return todaysTasks; } }
        public DateTime Date
        {
            get
            {
                return this.date;
            }
        }
        private MyDay()
        {
            this.date = DateTime.Now;
            this.todaysTasks = new List<Task>();
        }
        public static MyDay NewDay()
        {
            if (currentDay.date != DateTime.Now.Date)
            {
                currentDay = new MyDay();
            }
            return currentDay;
        }
        public void AddDayTask(Task task)
        {
            currentDay.TodaysTasks.Add(task);
        }
        public override string ToString()
        {
            return $"{todaysTasks}:{currentDay}";
        }
    }
}
