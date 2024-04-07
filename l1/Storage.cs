using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1
{
    struct Student
    {
        public string name;
        public int[] ratings;
    }
    static class Storage
    {
        public static List<Student> GetFromFile()
        {
            List<Student> students = new List<Student>();
            return students;
        }
        public static bool SetToFile(List<Student> students)
        {
            return true;
        }
    }
}
