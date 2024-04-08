using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1
{
    class Student
    {
        public string name;
        public int[] ratings;


        public Student(string name, int[] ratings) 
        { 
            this.name = name;
            this.ratings = ratings;
        }

        public Student(string line)
        {
            string[] parts = line.Split(Constant.sep);
            name = parts[0];
            ratings = new int[parts.Length - 1];
            for (int i = 1; i < parts.Length; i++)
            {
                ratings[i - 1] = int.Parse(parts[i]);
            }

        }
        public override string ToString()
        {
            char sep = Constant.sep;
            return $"{name}{sep}{ratings[0]}{sep}{ratings[1]}{sep}{ratings[2]}{sep}{ratings[3]}{sep}{ratings[4]}";
        }
    }
}
