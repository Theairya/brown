namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtFacultyMemberName = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtAssignmentNumber = new System.Windows.Forms.TextBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtCourseNameNumber = new System.Windows.Forms.TextBox();
            this.txtTermSemester = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtDescriptionOfViolation = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtFacultyMemberSignature = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.chkReprimand = new System.Windows.Forms.CheckBox();
            this.chkGradeReduction = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(631, 649);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 655);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 655);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(508, 655);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStudentName.Location = new System.Drawing.Point(12, 181);
            this.txtStudentName.Multiline = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(239, 24);
            this.txtStudentName.TabIndex = 4;
            // 
            // txtFacultyMemberName
            // 
            this.txtFacultyMemberName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFacultyMemberName.Location = new System.Drawing.Point(12, 221);
            this.txtFacultyMemberName.Multiline = true;
            this.txtFacultyMemberName.Name = "txtFacultyMemberName";
            this.txtFacultyMemberName.Size = new System.Drawing.Size(239, 24);
            this.txtFacultyMemberName.TabIndex = 6;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStudentEmail.Location = new System.Drawing.Point(395, 181);
            this.txtStudentEmail.Multiline = true;
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(200, 24);
            this.txtStudentEmail.TabIndex = 7;
            // 
            // txtAssignmentNumber
            // 
            this.txtAssignmentNumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAssignmentNumber.Location = new System.Drawing.Point(0, 260);
            this.txtAssignmentNumber.Multiline = true;
            this.txtAssignmentNumber.Name = "txtAssignmentNumber";
            this.txtAssignmentNumber.Size = new System.Drawing.Size(166, 24);
            this.txtAssignmentNumber.TabIndex = 8;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStudentNumber.Location = new System.Drawing.Point(257, 181);
            this.txtStudentNumber.Multiline = true;
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(132, 24);
            this.txtStudentNumber.TabIndex = 9;
            // 
            // txtCourseNameNumber
            // 
            this.txtCourseNameNumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCourseNameNumber.Location = new System.Drawing.Point(395, 221);
            this.txtCourseNameNumber.Multiline = true;
            this.txtCourseNameNumber.Name = "txtCourseNameNumber";
            this.txtCourseNameNumber.Size = new System.Drawing.Size(200, 24);
            this.txtCourseNameNumber.TabIndex = 11;
            // 
            // txtTermSemester
            // 
            this.txtTermSemester.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTermSemester.Location = new System.Drawing.Point(441, 260);
            this.txtTermSemester.Multiline = true;
            this.txtTermSemester.Name = "txtTermSemester";
            this.txtTermSemester.Size = new System.Drawing.Size(154, 24);
            this.txtTermSemester.TabIndex = 12;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDepartment.Location = new System.Drawing.Point(172, 260);
            this.txtDepartment.Multiline = true;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(263, 24);
            this.txtDepartment.TabIndex = 13;
            // 
            // txtDescriptionOfViolation
            // 
            this.txtDescriptionOfViolation.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDescriptionOfViolation.Location = new System.Drawing.Point(0, 314);
            this.txtDescriptionOfViolation.Multiline = true;
            this.txtDescriptionOfViolation.Name = "txtDescriptionOfViolation";
            this.txtDescriptionOfViolation.Size = new System.Drawing.Size(595, 51);
            this.txtDescriptionOfViolation.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(237, 599);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 24);
            this.textBox2.TabIndex = 15;
            // 
            // txtFacultyMemberSignature
            // 
            this.txtFacultyMemberSignature.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFacultyMemberSignature.Location = new System.Drawing.Point(0, 599);
            this.txtFacultyMemberSignature.Multiline = true;
            this.txtFacultyMemberSignature.Name = "txtFacultyMemberSignature";
            this.txtFacultyMemberSignature.Size = new System.Drawing.Size(166, 24);
            this.txtFacultyMemberSignature.TabIndex = 16;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(273, 221);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(467, 603);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // chkReprimand
            // 
            this.chkReprimand.AutoSize = true;
            this.chkReprimand.Location = new System.Drawing.Point(556, 502);
            this.chkReprimand.Name = "chkReprimand";
            this.chkReprimand.Size = new System.Drawing.Size(15, 14);
            this.chkReprimand.TabIndex = 19;
            this.chkReprimand.UseVisualStyleBackColor = true;
            // 
            // chkGradeReduction
            // 
            this.chkGradeReduction.AutoSize = true;
            this.chkGradeReduction.Location = new System.Drawing.Point(556, 536);
            this.chkGradeReduction.Name = "chkGradeReduction";
            this.chkGradeReduction.Size = new System.Drawing.Size(15, 14);
            this.chkGradeReduction.TabIndex = 20;
            this.chkGradeReduction.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 794);
            this.Controls.Add(this.chkGradeReduction);
            this.Controls.Add(this.chkReprimand);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtFacultyMemberSignature);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtDescriptionOfViolation);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtTermSemester);
            this.Controls.Add(this.txtCourseNameNumber);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.txtAssignmentNumber);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.txtFacultyMemberName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtFacultyMemberName;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtAssignmentNumber;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtCourseNameNumber;
        private System.Windows.Forms.TextBox txtTermSemester;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtDescriptionOfViolation;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtFacultyMemberSignature;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox chkReprimand;
        private System.Windows.Forms.CheckBox chkGradeReduction;
    }
}