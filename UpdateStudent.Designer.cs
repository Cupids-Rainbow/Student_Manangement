using Krypton.Toolkit;
using System.Windows.Forms;

namespace PRG2781
{
    partial class UpdateStudent
    {
        private KryptonTextBox txtID;
        private KryptonTextBox txtName;
        private KryptonTextBox txtAge;
        private KryptonTextBox txtCourse;
        private KryptonButton btnUpdate;

        private void InitializeComponent()
        {
            txtID = new KryptonTextBox();
            txtName = new KryptonTextBox();
            txtAge = new KryptonTextBox();
            txtCourse = new KryptonTextBox();
            btnUpdate = new KryptonButton();

            SuspendLayout();

            // txtID
            txtID.Location = new System.Drawing.Point(100, 50);
            txtID.Size = new System.Drawing.Size(200, 23);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;

            // txtName
            txtName.Location = new System.Drawing.Point(100, 90);
            txtName.Size = new System.Drawing.Size(200, 23);
            txtName.Name = "txtName";

            // txtAge
            txtAge.Location = new System.Drawing.Point(100, 130);
            txtAge.Size = new System.Drawing.Size(200, 23);
            txtAge.Name = "txtAge";

            // txtCourse
            txtCourse.Location = new System.Drawing.Point(100, 170);
            txtCourse.Size = new System.Drawing.Size(200, 23);
            txtCourse.Name = "txtCourse";

            // btnUpdate
            btnUpdate.Location = new System.Drawing.Point(150, 220);
            btnUpdate.Size = new System.Drawing.Size(100, 30);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Text = "Update";
            btnUpdate.Click += new System.EventHandler(btnUpdate_Click);

            // UpdateStudent form settings
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(txtAge);
            Controls.Add(txtCourse);
            Controls.Add(btnUpdate);

            Text = "Update Student";
            ClientSize = new System.Drawing.Size(400, 300);

            ResumeLayout(false);
        }
        //test
    }
}
