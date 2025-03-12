using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShkoloApp
{
    public partial class StudentDetailsForm : Form
    {
        private readonly Student student;

        public StudentDetailsForm(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void StudentDetailsForm_Load(object sender, EventArgs e)
        {
            FillStudentInfoLabels();
            UpdateListViewWithMarks();
            CheckForWarnings();
        }

        private void FillStudentInfoLabels()
        {
            this.StudentName.Text = this.student.Name;
            this.StudentGrade.Text = this.student.Grade.ToString();
            this.Average.Text = this.student.AverageMark.ToString("f2");
            this.ExcusedNumber.Text = this.student.ExcusedAbsences.ToString();
            this.UnexcusedNumber.Text = this.student.UnexcusedAbsences.ToString();
            this.TotalNumber.Text = this.student.TotalAbsences.ToString();
        }

        private void UpdateListViewWithMarks()
        {
            this.listView1.Items.Clear();

            AddMarksToListView("Mathematics", this.student.MathematicsMarks);
            AddMarksToListView("Informatics", this.student.InformaticsMarks);
            AddMarksToListView("Sport", this.student.SportMaks);
        }

        private void AddMarksToListView(string subject, List<double> marks)
        {
            ListViewItem newColumn = new ListViewItem(subject);
            newColumn.SubItems.Add(string.Join(", ", marks));
            this.listView1.Items.Add(newColumn);
        }

        private void CheckForWarnings()
        {
            if (this.student.UnexcusedAbsences > 10)
            {
                ChangeColor();
            }
        }

        private void ChangeColor()
        {
            this.BackColor = Color.FromArgb(288, 131, 151);
            this.ForeColor = Color.White;
            this.labelTooManyAbsences.Visible = true;

            this.button2.BackColor = Color.FromArgb(237, 30, 54);
            this.button1.BackColor = Color.FromArgb(237, 30, 54);

            this.listView1.BackColor = Color.FromArgb(228, 205, 211);
            this.listBox1.BackColor = Color.FromArgb(228, 205, 211);
            this.listBoxType.BackColor = Color.FromArgb(228, 205, 211);
            this.textBox1.BackColor = Color.FromArgb(228, 205, 211);
            this.numericUpDown1.BackColor = Color.FromArgb(228, 205, 211);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewMark();
                FillStudentInfoLabels();
                UpdateListViewWithMarks();
                ClearInputs();
            }
            catch (Exception)
            {
                ShowErrorMessage(this.label3);
            }
        }

        private void AddNewMark()
        {
            GetNewMarkInfo(out double mark, out string subject);

            Dictionary<string, List<double>> subjectMarks = new()
            {
                {"Mathematics", this.student.MathematicsMarks },
                {"Informatics", this.student.InformaticsMarks },
                {"Sport", this.student.SportMaks }
            };
            if (subjectMarks.ContainsKey(subject))
            {
                subjectMarks[subject].Add(mark);
            }
        }

        private void GetNewMarkInfo(out double mark, out string subject)
        {
            mark = double.Parse(this.textBox1.Text);
            subject = this.listBox1.Text;
            if (string.IsNullOrEmpty(subject) || mark < 2 || mark > 6)
            {
                throw new Exception();
            }
        }

        private void ClearInputs()
        {
            this.textBox1.Clear();
            this.listBox1.ClearSelected();
            this.listBoxType.ClearSelected();
            this.numericUpDown1.Value = 0;
        }

        private void ShowErrorMessage(Label label)
        {
            label.Visible = true;
            Task.Delay(3000).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    label.Visible = false;
                }));
            });
        }

        private void button2_Click(object sender, EventArgs e)//Absence button
        {
            try
            {
                AddAbsence();
                FillStudentInfoLabels();
                ClearInputs();
                CheckForWarnings();
            }
            catch (Exception )
            {
                ShowErrorMessage(this.label4);
            }
        }

        private void AddAbsence()
        {
            GetNewAbsenceInfo(out string selectedAbsenceType, out int numberOfAbsence);

            Dictionary<string, Action<int>> absenceActions = new()
            {
                {"Excused", absences => this.student.ExcusedAbsences =+ absences},
                {"Unexcused", absences => this.student.UnexcusedAbsences += absences }
            };

            if (!absenceActions.ContainsKey(selectedAbsenceType) || numberOfAbsence < 0)
            {
                throw new Exception();
            }
            absenceActions[selectedAbsenceType](numberOfAbsence);

        }

        private void GetNewAbsenceInfo(out string selectedAbsencesType, out int numberOfAbsences)
        {
            selectedAbsencesType = this.listBoxType.Text;
            numberOfAbsences = int.Parse(this.numericUpDown1.Value.ToString());
        }

    }
}