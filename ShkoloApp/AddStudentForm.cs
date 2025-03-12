using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShkoloApp
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        public string Name { get; set; }
        public int Grade { get; set; }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }
            this.Name = this.NameTextBox.Text.Trim();
            this.Grade = int.Parse(this.GradeTextBox.Text.Trim());  

            DialogResult = DialogResult.OK;
        }

        private bool CheckIfInputsAreValid()
            => CheckIfNameIsNotEmptyString() && CheckIfGradeIsValid();

        private bool CheckIfNameIsNotEmptyString()
            => !string.IsNullOrWhiteSpace(this.NameTextBox.Text);

        private bool CheckIfGradeIsValid()
        {
            if (string.IsNullOrWhiteSpace(this.GradeTextBox.Text))
            {
                return false;
            }
            else if (double.TryParse(this.GradeTextBox.Text, out double gradeValue))
            {
                return gradeValue >= 1 && gradeValue <= 12;
            }
            return true;
        }

        private void ValidateStudentsName(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.NameTextBox.Text))
            {
                e.Cancel = true;
                this.NameTextBox.Focus();
                this.errorProviderName.SetError(this.NameTextBox, "Name should not be empty string!");
                this.NameValidationLabel.Visible = true;
            }
            else
            {
                e.Cancel=false;
                this.errorProviderName.SetError(this.NameTextBox, string.Empty);
                this.NameValidationLabel.Visible = false;
            }
        }

        private void ValidatingGrade(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.GradeTextBox.Text))
            {
                e.Cancel = true;
                this.GradeTextBox.Focus();
                this.errorProviderName.SetError(this.GradeTextBox, "Grade should not be empty string!");
                this.GradeValidationLabel.Visible = true;
            }
            else if(double.Parse(this.GradeTextBox.Text) < 1 || double.Parse(this.GradeTextBox.Text) > 12)
            {
                e.Cancel=true;
                this.GradeTextBox.Focus();
                this.errorProviderName.SetError(this.GradeTextBox, "Grade should be between 1 and 12");
                this.GradeValidationLabel.Visible = true;
            }
            else
            {
                e.Cancel=false;
                this.errorProviderName.SetError(this.GradeTextBox, string.Empty);
                this.GradeValidationLabel.Visible=false;
            }
        }
    }
}
