using Krypton.Toolkit;

namespace PRG2781
{
    partial class AddStudent
    {
        private KryptonTextBox txtID;
        private KryptonTextBox txtName;
        private KryptonTextBox txtAge;
        private KryptonTextBox txtCourse;
        private KryptonButton btnSave;

        private void InitializeComponent()
        {
            this.txtID = new KryptonTextBox();
            this.txtName = new KryptonTextBox();
            this.txtAge = new KryptonTextBox();
            this.txtCourse = new KryptonTextBox();
            this.btnSave = new KryptonButton();

            this.SuspendLayout();

            
            this.txtID.Location = new System.Drawing.Point(100, 50);
            this.txtID.Size = new System.Drawing.Size(200, 23);
            this.txtID.Name = "txtID";
            this.txtID.Text = "ID";

            
            this.txtName.Location = new System.Drawing.Point(100, 90);
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.Name = "txtName";
            this.txtName.Text = "Name";

          
            this.txtAge.Location = new System.Drawing.Point(100, 130);
            this.txtAge.Size = new System.Drawing.Size(200, 23);
            this.txtAge.Name = "txtAge";
            this.txtAge.Text = "Age";

            
            this.txtCourse.Location = new System.Drawing.Point(100, 170);
            this.txtCourse.Size = new System.Drawing.Size(200, 23);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Text = "Course";

          
            this.btnSave.Location = new System.Drawing.Point(150, 220);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

           
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.btnSave);

            this.Text = "Add Student";
            this.ClientSize = new System.Drawing.Size(400, 300);

            this.ResumeLayout(false);

            //test
        }
    }
}
