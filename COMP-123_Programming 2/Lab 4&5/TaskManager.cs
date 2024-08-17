using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace XuanN_301388576_lib
{
    public static class TaskManager
    {
        private static  List<Task> tasks;
        public static List<Task> Tasks { get { return tasks; } }
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
            foreach (Task task in tasks)
            {
                Console.WriteLine(task.ToString() + ",");
            }
            return tasks.ToString();
        }
        public static void Save(string path)
        {
            FileStream tasksIn = new FileStream("tasks.json", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(tasksIn);
            path = JsonSerializer.Serialize(tasks);
            Task saveTasks = JsonSerializer.Deserialize<Task>(path);
            Console.WriteLine(saveTasks);
            writer.Close();
            tasksIn.Close();
        }
        public static void Load(string path)
        {
            FileStream tasksLoad = new FileStream("..\\..\\..\\XuanN_301388576_Lab4&5\\bin\\Debug\\tasks.json", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(tasksLoad);
            path = reader.ReadToEnd();
            Task loadTasks = JsonSerializer.Deserialize<Task>(path);
            Console.WriteLine(loadTasks);
            reader.Close();
            tasksLoad.Close();
        }
    }
}
