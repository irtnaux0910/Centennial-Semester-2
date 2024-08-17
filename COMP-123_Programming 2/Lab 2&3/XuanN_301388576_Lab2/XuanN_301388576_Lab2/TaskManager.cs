using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanN_301388576_Lab2
{
    public static class TaskManager
    {
        private static List<Task> tasks;
        public static List<Task> Tasks
        {
            get
            {
                return tasks;
            }
        }

        static TaskManager()
        {
            tasks = new List<Task>();
        }

        public static Task CreateTask(string description)
        {
            Task task = new Task(description);
            tasks.Add(task);
            return task;
        }

        public static string AllTasksToString()
        {
            if (tasks.Count == 0)
            {
                return "No tasks";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("All Tasks:");
            int counter = 1;
            foreach (Task task in tasks)
            {
                sb.AppendLine($"{counter++}. {task.Description}");
            }
            return sb.ToString();
        }
    }
}
