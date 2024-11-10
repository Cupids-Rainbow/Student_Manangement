using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace PRG2781
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvStudents = new KryptonDataGridView();
            btnAddStudent = new KryptonButton();
            btnViewAll = new KryptonButton();
            btnUpdateStudent = new KryptonButton();
            btnDeleteStudent = new KryptonButton();
            kryptonButton1 = new KryptonButton();
            kryptonButton2 = new KryptonButton();
            kryptonButton3 = new KryptonButton();
            btnSummary = new KryptonButton();
            kryptonButton5 = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 12);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.PaletteMode = PaletteMode.ProfessionalSystem;
            dgvStudents.Size = new Size(776, 236);
            dgvStudents.StateCommon.Background.Color1 = Color.Salmon;
            dgvStudents.StateCommon.Background.Color2 = Color.WhiteSmoke;
            dgvStudents.StateCommon.Background.ColorAngle = 45F;
            dgvStudents.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            dgvStudents.StateCommon.DataCell.Back.Color1 = Color.DarkCyan;
            dgvStudents.StateCommon.DataCell.Back.Color2 = SystemColors.AppWorkspace;
            dgvStudents.StateCommon.DataCell.Content.Color1 = Color.White;
            dgvStudents.TabIndex = 0;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(37, 284);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.PaletteMode = PaletteMode.ProfessionalSystem;
            btnAddStudent.Size = new Size(158, 55);
            btnAddStudent.StateCommon.Back.Color1 = Color.DimGray;
            btnAddStudent.StateCommon.Back.Color2 = Color.IndianRed;
            btnAddStudent.StateCommon.Back.ColorAngle = 45F;
            btnAddStudent.StateCommon.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnAddStudent.StateCommon.Border.Color1 = Color.DimGray;
            btnAddStudent.StateCommon.Border.Color2 = Color.SteelBlue;
            btnAddStudent.StateCommon.Border.ColorAngle = 45F;
            btnAddStudent.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnAddStudent.StateCommon.Border.Rounding = 45;
            btnAddStudent.StateCommon.Border.Width = 0;
            btnAddStudent.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            btnAddStudent.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnAddStudent.StateCommon.Content.ShortText.Font = new Font("Bauhaus 93", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.StatePressed.Back.Color1 = Color.Navy;
            btnAddStudent.StatePressed.Back.Color2 = Color.White;
            btnAddStudent.StateTracking.Back.Color1 = Color.Black;
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Values.Text = "Add Student";
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnViewAll
            // 
            btnViewAll.Location = new Point(229, 284);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(153, 55);
            btnViewAll.TabIndex = 2;
            btnViewAll.Values.Text = "";
            btnViewAll.Click += btnViewAll_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Location = new Point(421, 284);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(156, 55);
            btnUpdateStudent.TabIndex = 3;
            btnUpdateStudent.Values.Text = "Update Student";
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(604, 284);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(153, 55);
            btnDeleteStudent.TabIndex = 4;
            btnDeleteStudent.Values.Text = "Delete Student";
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(224, 284);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.PaletteMode = PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(158, 55);
            kryptonButton1.StateCommon.Back.Color1 = Color.DimGray;
            kryptonButton1.StateCommon.Back.Color2 = Color.IndianRed;
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Color1 = Color.DimGray;
            kryptonButton1.StateCommon.Border.Color2 = Color.SteelBlue;
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 45;
            kryptonButton1.StateCommon.Border.Width = 0;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.Black;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Bauhaus 93", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.Navy;
            kryptonButton1.StatePressed.Back.Color2 = Color.White;
            kryptonButton1.StateTracking.Back.Color1 = Color.Black;
            kryptonButton1.TabIndex = 5;
            kryptonButton1.Values.Text = "View All";
            kryptonButton1.Click += btnViewAll_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(421, 284);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.PaletteMode = PaletteMode.ProfessionalSystem;
            kryptonButton2.Size = new Size(158, 55);
            kryptonButton2.StateCommon.Back.Color1 = Color.DimGray;
            kryptonButton2.StateCommon.Back.Color2 = Color.IndianRed;
            kryptonButton2.StateCommon.Back.ColorAngle = 45F;
            kryptonButton2.StateCommon.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton2.StateCommon.Border.Color1 = Color.DimGray;
            kryptonButton2.StateCommon.Border.Color2 = Color.SteelBlue;
            kryptonButton2.StateCommon.Border.ColorAngle = 45F;
            kryptonButton2.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.Rounding = 45;
            kryptonButton2.StateCommon.Border.Width = 0;
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            kryptonButton2.StateCommon.Content.ShortText.Color2 = Color.Black;
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Bauhaus 93", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton2.StatePressed.Back.Color1 = Color.Navy;
            kryptonButton2.StatePressed.Back.Color2 = Color.White;
            kryptonButton2.StateTracking.Back.Color1 = Color.Black;
            kryptonButton2.TabIndex = 6;
            kryptonButton2.Values.Text = "Update Student";
            kryptonButton2.Click += btnUpdateStudent_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(604, 284);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.PaletteMode = PaletteMode.ProfessionalSystem;
            kryptonButton3.Size = new Size(158, 55);
            kryptonButton3.StateCommon.Back.Color1 = Color.DimGray;
            kryptonButton3.StateCommon.Back.Color2 = Color.IndianRed;
            kryptonButton3.StateCommon.Back.ColorAngle = 45F;
            kryptonButton3.StateCommon.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton3.StateCommon.Border.Color1 = Color.DimGray;
            kryptonButton3.StateCommon.Border.Color2 = Color.SteelBlue;
            kryptonButton3.StateCommon.Border.ColorAngle = 45F;
            kryptonButton3.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton3.StateCommon.Border.Rounding = 45;
            kryptonButton3.StateCommon.Border.Width = 0;
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            kryptonButton3.StateCommon.Content.ShortText.Color2 = Color.Black;
            kryptonButton3.StateCommon.Content.ShortText.Font = new Font("Bauhaus 93", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton3.StateDisabled.Back.Color1 = Color.FromArgb(255, 255, 128);
            kryptonButton3.StatePressed.Back.Color1 = Color.Navy;
            kryptonButton3.StatePressed.Back.Color2 = Color.White;
            kryptonButton3.StateTracking.Back.Color1 = Color.Black;
            kryptonButton3.TabIndex = 7;
            kryptonButton3.Values.Text = "Delete Student";
            kryptonButton3.Click += btnDeleteStudent_Click;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(327, 363);
            btnSummary.Name = "btnSummary";
            btnSummary.PaletteMode = PaletteMode.ProfessionalSystem;
            btnSummary.Size = new Size(158, 55);
            btnSummary.StateCommon.Back.Color1 = Color.DimGray;
            btnSummary.StateCommon.Back.Color2 = Color.IndianRed;
            btnSummary.StateCommon.Back.ColorAngle = 45F;
            btnSummary.StateCommon.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnSummary.StateCommon.Border.Color1 = Color.DimGray;
            btnSummary.StateCommon.Border.Color2 = Color.SteelBlue;
            btnSummary.StateCommon.Border.ColorAngle = 45F;
            btnSummary.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnSummary.StateCommon.Border.Rounding = 45;
            btnSummary.StateCommon.Border.Width = 0;
            btnSummary.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            btnSummary.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnSummary.StateCommon.Content.ShortText.Font = new Font("Bauhaus 93", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSummary.StatePressed.Back.Color1 = Color.Navy;
            btnSummary.StatePressed.Back.Color2 = Color.White;
            btnSummary.StateTracking.Back.Color1 = Color.Black;
            btnSummary.TabIndex = 19;
            btnSummary.Values.Text = "Summary";
            btnSummary.Click += btnSummary_Click;
            // 
            // kryptonButton5
            // 
            kryptonButton5.Location = new Point(327, 363);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.Size = new Size(156, 55);
            kryptonButton5.TabIndex = 18;
            kryptonButton5.Values.Text = "Update Student";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSummary);
            Controls.Add(kryptonButton5);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnUpdateStudent);
            Controls.Add(btnViewAll);
            Controls.Add(btnAddStudent);
            Controls.Add(dgvStudents);
            Name = "Form1";
            PaletteMode = PaletteMode.ProfessionalSystem;
            Text = "Student Management";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        private KryptonDataGridView dgvStudents;
        private KryptonButton btnAddStudent;
        private KryptonButton btnViewAll;
        private KryptonButton btnUpdateStudent;
        private KryptonButton btnDeleteStudent;
        private KryptonButton kryptonButton1;
        private KryptonButton kryptonButton2;
        private KryptonButton kryptonButton3;
        private KryptonButton btnSummary;
        private KryptonButton kryptonButton5;
    }
    //test
}
