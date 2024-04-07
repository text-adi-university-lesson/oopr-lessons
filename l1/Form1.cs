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

        private void GetStudents()
        {
            
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
            
            Student student = new Student();

            student.name = textBoxStudent.Text;


            student.ratings = tmpRatings;

            students.Add(student);


        }
    }
}
