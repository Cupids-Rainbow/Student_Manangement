using Krypton.Toolkit;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PRG2781
{
    public partial class UpdateStudent : KryptonForm
    {
        public string UpdatedRecord { get; private set; } = string.Empty;
        private string studentID;

        public UpdateStudent(string id)
        {
            studentID = id;
            InitializeComponent();
            LoadStudent();
        }

        private void LoadStudent()
        {
            var lines = File.ReadAllLines("students.txt");
            var record = lines.FirstOrDefault(line => line.StartsWith(studentID + ","));
            if (record != null)
            {
                var data = record.Split(',');
                txtID.Text = data[0];
                txtName.Text = data[1];
                txtAge.Text = data[2];
                txtCourse.Text = data[3];
            }
            else
            {
                KryptonMessageBox.Show("Student record not found.");
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || !int.TryParse(txtAge.Text, out int age) || string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                KryptonMessageBox.Show("All fields are required and age must be a number.");
                return;
            }

            UpdatedRecord = $"{txtID.Text},{txtName.Text},{age},{txtCourse.Text}";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //test
    }
}
