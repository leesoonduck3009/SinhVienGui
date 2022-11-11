using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace GUI
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Avg { get; set; }
        public string Class { get; set; }
        public Student(int id, string name, float avg, string @class)
        {
            Id = id;
            Name = name;
            Avg = avg;
            Class = @class;
        }
        public override string ToString()
        {
            return Id.ToString() + "/" + Name + "/" + Class + "/" + Avg.ToString() + "\n";
        }
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            string[] ListStudent = File.ReadAllLines("data.txt");
            for (int i = 0; i < ListStudent.Length; i++)
            {
                string[] listDataStudent = ListStudent[i].Split('/');
                Student a = new Student(int.Parse(listDataStudent[0]), listDataStudent[1], float.Parse(listDataStudent[3]), listDataStudent[2]);
                students.Add(a);
            }
            return students;
        }
        public Student()
        { }
        public static bool operator == (Student a, Student b)
        {
            if (a.Id == b.Id && a.Name == b.Name && a.Class == b.Class && a.Avg == b.Avg)
                return true;
            return false;
        }
        public static bool operator !=(Student a, Student b)
        {
            if (a.Id != b.Id || a.Name != b.Name || a.Class != b.Class || a.Avg != b.Avg)
                return true;
            return false;
        }
    }
}
