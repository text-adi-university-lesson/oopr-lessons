using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l1
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            var students = Storage.GetFromFile();

            int[] tmpRatings = new int[5];
            tmpRatings[0] = Convert.ToInt32(numericUpDownStudent1.Value);
            tmpRatings[1] = Convert.ToInt32(numericUpDownStudent2.Value);
            tmpRatings[2] = Convert.ToInt32(numericUpDownStudent3.Value);
            tmpRatings[3] = Convert.ToInt32(numericUpDownStudent4.Value);
            tmpRatings[4] = Convert.ToInt32(numericUpDownStudent5.Value);
            
            students.Add(new Student(name: textBoxStudent.Text, ratings: tmpRatings));
            Storage.SetToFile(students);
            MessageBox.Show("Add - OK", "Info", MessageBoxButtons.OK);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var students = Storage.GetFromFile();
            string name = textBoxStudent.Text;

            students.RemoveAll(student=> student.name == name);
            //
            //Пошук по списку.
            //
            Storage.SetToFile(students);
            MessageBox.Show("Delete - OK", "Info", MessageBoxButtons.OK);

        }

        private void buttonViewToDisplay_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            var students = Storage.GetFromFile();
            
            if (students.Count == 0)
            {
                richTextBox.Text = "Нічого немає :(";
            }

            List<Student> badStudent = new List<Student>();
            int? minBal = null;
            foreach (var item in students)
            {
                int tmpMinBal = item.ratings.Sum();
                if (!minBal.HasValue || tmpMinBal < minBal)
                {
                    minBal = tmpMinBal;
                    badStudent = new List<Student>();
                    badStudent.Add(item);
                    continue;
                }
                if (tmpMinBal == minBal)
                {
                    badStudent.Add(item);
                }


            }
            foreach (var item in badStudent)
            {
                richTextBox.Text += item.ToString().Replace(Constant.sep, ',') + "\n";
            }



        }
    }
}
