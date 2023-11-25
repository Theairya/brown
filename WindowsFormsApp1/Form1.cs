using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear text boxes for student information
            txtStudentName.Text = "";
            txtStudentNumber.Text = "";
            txtStudentEmail.Text = "";

            // Clear text boxes for faculty information
            txtFacultyMemberName.Text = "";
            dateTimePicker.Value = DateTime.Now; // Reset the date picker to the current date
            txtCourseNameNumber.Text = "";

            // Clear text boxes for assignment information
            txtAssignmentNumber.Text = "";
            txtDepartment.Text = "";
            txtTermSemester.Text = "";

            // Clear text box for the description of the violation
            txtDescriptionOfViolation.Text = "";

            // Assuming there are checkboxes for each recommendation for sanction,
            // uncheck these checkboxes
            chkReprimand.Checked = false;
            chkGradeReduction.Checked = false;
            // ... uncheck other checkboxes for recommendations ...

            // Clear the signature field if applicable
            txtFacultyMemberSignature.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveToFile();
            this.Close();
        }
        private void SaveToFile()
        {
            // This will get the path of the current domain's base directory
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            // Combine the directory with your desired file name
            string filePath = Path.Combine(directory, "savedData.txt");

            using (StreamWriter file = new StreamWriter(filePath))
            {
                file.WriteLine("Student Name: " + txtStudentName.Text);
                file.WriteLine("Student Number: " + txtStudentNumber.Text);
                file.WriteLine("Student Email: " + txtStudentEmail.Text);
                file.WriteLine("Faculty Member Name: " + txtFacultyMemberName.Text);
                file.WriteLine("Date: " + dateTimePicker.Value.ToString("yyyy-MM-dd"));
                file.WriteLine("Course Name and Number: " + txtCourseNameNumber.Text);
                file.WriteLine("Assignment Number or Exam: " + txtAssignmentNumber.Text);
                file.WriteLine("Department: " + txtDepartment.Text);
                file.WriteLine("Term or Semester: " + txtTermSemester.Text);
                file.WriteLine("Description of Violation: " + txtDescriptionOfViolation.Text);
                // Assuming checkboxes for recommendations, you'd gather their checked state like this:
                file.WriteLine("Recommendation - Repreimand: " + (chkReprimand.Checked ? "Yes" : "No"));
                file.WriteLine("Recommendation - Grade Reduction: " + (chkGradeReduction.Checked ? "Yes" : "No"));
                // ... other recommendation fields ...
                file.WriteLine("Faculty Member Signature: " + txtFacultyMemberSignature.Text);
                // ... any additional fields ...

            }

            MessageBox.Show("Information saved to file.");

            // Close the form
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text boxes for student information
            txtStudentName.Text = "";
            txtStudentNumber.Text = "";
            txtStudentEmail.Text = "";

            // Clear text boxes for faculty information
            txtFacultyMemberName.Text = "";
            dateTimePicker.Value = DateTime.Now; // Reset the date picker to the current date
            txtCourseNameNumber.Text = "";

            // Clear text boxes for assignment information
            txtAssignmentNumber.Text = "";
            txtDepartment.Text = "";
            txtTermSemester.Text = "";

            // Clear text box for the description of the violation
            txtDescriptionOfViolation.Text = "";

            // Assuming there are checkboxes for each recommendation for sanction,
            // uncheck these checkboxes
            chkReprimand.Checked = false;
            chkGradeReduction.Checked = false;
            // ... uncheck other checkboxes for recommendations ...

            // Clear the signature field if applicable
            txtFacultyMemberSignature.Text = "";
            // Reset any additional date pickers if they exist
            // dateTimePickerSignatureDate.Value = DateTime.Now; // Uncomment if you have another date picker for signature

            // If there are other checkboxes or controls related to recommendations or sanctions,
            // you would uncheck or reset them here similarly.

            // If there are any other controls that need to be cleared, add them here
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }
    }
}
