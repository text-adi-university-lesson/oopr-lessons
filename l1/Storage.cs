using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1
{
    
    static class Storage
    {
        
        public static List<Student> GetFromFile()
        {
            List<Student> students = new List<Student>();

            if (!IsExistFile())
            {
                CreateFile();
            }

            using (StreamReader reader = new StreamReader(Constant.filename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    students.Add(new Student(line));
                }
            }

            return students;
        }
        public static bool SetToFile(List<Student> students)
        {
            if (!IsExistFile())
            {
                CreateFile();
            }
            using (StreamWriter writer = new StreamWriter(Constant.filename))
            {
                foreach (var student in students)
                {
                    writer.WriteLine(student.ToString());
                }
            }
            return true;
        }
        public static bool IsExistFile()
        {
            return File.Exists(Constant.filename);
        }
        public static void CreateFile()
        {
            using (FileStream fs = File.Create(Constant.filename)) { };
        }
    }
}
