namespace PRG2781
{
    partial class Summary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        //test
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTotalStudents = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            lblAverageAge = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.Location = new Point(20, 66);
            lblTotalStudents.Margin = new Padding(7);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(89, 33);
            lblTotalStudents.StateCommon.ShortText.Color1 = Color.White;
            lblTotalStudents.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalStudents.TabIndex = 0;
            lblTotalStudents.Values.Text = "Label1";
            // 
            // lblAverageAge
            // 
            lblAverageAge.Location = new Point(20, 159);
            lblAverageAge.Margin = new Padding(7);
            lblAverageAge.Name = "lblAverageAge";
            lblAverageAge.Size = new Size(89, 33);
            lblAverageAge.StateCommon.ShortText.Color1 = Color.White;
            lblAverageAge.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAverageAge.TabIndex = 1;
            lblAverageAge.Values.Text = "Label2";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.IndianRed;
            groupBox1.Controls.Add(lblAverageAge);
            groupBox1.Controls.Add(lblTotalStudents);
            groupBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(354, 223);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Summary";
            // 
            // Summary
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(401, 277);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(7);
            Name = "Summary";
            Text = "Summary";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTotalStudents;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAverageAge;
        private GroupBox groupBox1;
    }
}