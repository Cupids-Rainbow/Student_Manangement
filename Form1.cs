using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace PRG2781
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridViewColumns();
        }

        private void InitializeDataGridViewColumns()
        {
            dgvStudents.Columns.Add("ID", "ID");
            dgvStudents.Columns.Add("Name", "Name");
            dgvStudents.Columns.Add("Age", "Age");
            dgvStudents.Columns.Add("Course", "Course");
        }

        private void LoadStudents()
        {
            dgvStudents.Rows.Clear();
            if (File.Exists("students.txt"))
            {
                var lines = File.ReadAllLines("students.txt");
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    if (data.Length == 4)
                    {
                        dgvStudents.Rows.Add(data[0], data[1], data[2], data[3]);
                    }
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (AddStudent addForm = new AddStudent())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    File.AppendAllText("students.txt", addForm.StudentRecord + Environment.NewLine);
                    MessageBox.Show("Student added successfully.");
                    LoadStudents();
                }
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var row = dgvStudents.SelectedRows[0];
                string studentID = row.Cells[0].Value?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(studentID))
                {
                    using (UpdateStudent updateForm = new UpdateStudent(studentID))
                    {
                        if (updateForm.ShowDialog() == DialogResult.OK)
                        {
                            UpdateStudentRecord(updateForm.UpdatedRecord);
                            MessageBox.Show("Student updated successfully.");
                            LoadStudents();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var row = dgvStudents.SelectedRows[0];
                string studentID = row.Cells[0].Value?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(studentID))
                {
                    DeleteStudentRecord(studentID);
                    MessageBox.Show("Student deleted successfully.");
                    LoadStudents();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void UpdateStudentRecord(string updatedRecord)
        {
            var records = File.ReadAllLines("students.txt").ToList();
            var parts = updatedRecord.Split(',');
            var studentID = parts[0];
            for (int i = 0; i < records.Count; i++)
            {
                if (records[i].StartsWith(studentID + ","))
                {
                    records[i] = updatedRecord;
                    File.WriteAllLines("students.txt", records);
                    return;
                }
            }
        }

        private void DeleteStudentRecord(string studentID)
        {
            var records = File.ReadAllLines("students.txt").Where(line => !line.StartsWith(studentID + ",")).ToList();
            File.WriteAllLines("students.txt", records);
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            Summary sum = new Summary();

            sum.Show();
        }
  
    }
}
