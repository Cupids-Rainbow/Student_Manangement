using Krypton.Toolkit;
using System.Windows.Forms;

namespace PRG2781
{
    public partial class AddStudent : KryptonForm
    {
        public string StudentRecord { get; private set; } = string.Empty;

        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) ||
                !int.TryParse(txtAge.Text, out int age) || string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                KryptonMessageBox.Show("All fields are required and age must be a number.");
                return;
            }

            StudentRecord = $"{txtID.Text},{txtName.Text},{age},{txtCourse.Text}";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
