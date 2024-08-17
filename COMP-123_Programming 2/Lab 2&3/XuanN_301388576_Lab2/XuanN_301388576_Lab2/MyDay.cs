using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanN_301388576_Lab2
{
    public class MyDay
    {
        private static MyDay currentDay;
        private DateTime date;
        private List<Task> todaysTasks;       

        private MyDay()
        {
            this.date = DateTime.Now;
            this.todaysTasks = new List<Task>();
        }

        public List<Task> TodaysTasks
        {
            get
            {
                return this.todaysTasks;
            }
        }

        public void AddDayTask(Task task)
        {
            currentDay.TodaysTasks.Add(task);
        }
        public static MyDay NewDay()
        {
            if (currentDay == null)
            {
                currentDay = new MyDay();
            }
            else if (currentDay.date.Date != DateTime.Now.Date)
            {
                currentDay = new MyDay();
            }
            return currentDay;
        }
        public override string ToString()
        {
            if (currentDay == null)
            {
                return string.Format($"Current day: {0}", this.date);
            }
            return string.Format($"Current day: {0}", currentDay.date);
        }
    }

}
