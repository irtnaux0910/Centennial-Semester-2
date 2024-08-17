using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using XuanN_301388576_lib;

namespace XuanN_301388576_lib
{
    public static class CourseManager
    {
        private static List<Course> courses;
        public static List<Course> Courses { get { return courses; } }
        public static void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public static void Load(string path)
        {

            FileStream coursesLoad = new FileStream("..\\..\\..\\XuanN_301388576_Lab4&5\\bin\\Debug\\courses.json", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(coursesLoad);
            path = reader.ReadToEnd();
            Task loadCourses = JsonSerializer.Deserialize<Course>(path);
            Console.WriteLine(loadCourses);
            reader.Close();
            coursesLoad.Close();
        }
        public static void RemoveCourse(Course course)
        {
            courses.Remove(course);
        }
        public static void Save(string path)
        {
            FileStream coursesIn = new FileStream("courses.json", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(coursesIn);
            path = JsonSerializer.Serialize(courses);
            Task saveCourses = JsonSerializer.Deserialize<Course>(path);
            Console.WriteLine(saveCourses);
            writer.Close();
            coursesIn.Close();
        }
        public override string ToString()
        {
            foreach (Course course in courses)
            {
                Console.WriteLine(course.ToString());
            }
            return courses.ToString();
        }
    }
}
