using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace PRG2781
{
    public partial class Summary : KryptonForm
    {
        private int TotalStudents;
        private int AverageAge;
        public Summary()
        {
            InitializeComponent();
            GenSummary();
            DisplaySum();
        }

        public int TotalStudents_1 { get => TotalStudents; set => TotalStudents = value; }
        public int AverageAge_1 { get => AverageAge; set => AverageAge = value; }

        private string StudentPath = "students.txt";
        private string SummaryPath = "summary.txt";


        private void GenSummary()
        {
            if (File.Exists(StudentPath))
            {
                string[] lines = File.ReadAllLines(StudentPath);
                TotalStudents_1 = lines.Length;

                if (TotalStudents_1 > 0)
                {
                    IEnumerable<double> age = lines.Select(line => double.Parse(line.Split(',')[2]));
                    AverageAge = (int)age.Average();
                }
                else
                {
                    AverageAge = 0;
                }
                SaveSummary();
                MessageBox.Show("Student Summary has been saved");
            }
            else
            {
                MessageBox.Show("Student data file could not be found");
            }

        }

        private void SaveSummary()
        {
            using (FileStream fs = new FileStream(SummaryPath, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("Student Summary");
                sw.WriteLine("=======================");
                sw.WriteLine($"Total Students: {TotalStudents_1}");
                sw.WriteLine($"Average Age: {AverageAge_1}");
                sw.WriteLine("=======================");
            }
        }
        private void DisplaySum()
        {
            lblTotalStudents.Text = $"Total Students: {TotalStudents_1}";
            lblAverageAge.Text = $"Average Age: {AverageAge_1}";
        }
        //Test
    }
}
