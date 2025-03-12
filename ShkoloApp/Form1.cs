namespace ShkoloApp
{
    public partial class Form1 : Form
    {

        private readonly List<Student> students = new()
        {
            new Student
            (
                "Mark Hil",
                12,
                new List<double> {6, 2, 3.54},
                new List<double> {3.78, 5.8, 4.34},
                new List<double> {5.70, 6, 5}

            ),
            new Student
            (
                "John Tven",
                10,
                new List<double> {5.43, 2, 3.54},
                new List<double> {3, 5.34, 4.43},
                new List<double> {5.23, 6, 5.54}

                )
        };
        public Form1()
        {
            InitializeComponent();
        }


        private void NewStudentButton_Click(object sender, EventArgs e)
        {
            using (AddStudentForm addNewStudent = new())
            {
                if (addNewStudent.ShowDialog() == DialogResult.OK)
                {
                    AddNewStudent(addNewStudent.Name, addNewStudent.Grade);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllStudents();
        }

        private void LoadAllStudents()
        {
            this.IndexListView.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem studentRow = new(student.Name);
                studentRow.SubItems.Add(string.Join(", ", student.MathematicsMarks));
                studentRow.SubItems.Add(string.Join(", ", student.InformaticsMarks));
                studentRow.SubItems.Add(string.Join(", ", student.SportMaks));
                this.IndexListView.Items.Add(studentRow);
            }
        }

        private void AddNewStudent(string name, int grade)
        {
            Student student = new Student(name, grade);
            students.Add(student);
            LoadAllStudents();
        }

        private void ListViewGradesMouseClick(object sender, MouseEventArgs e)
        {
            Student currSelectedStudent = GetSelectedStudent();
            using (StudentDetailsForm detailsPage = new(currSelectedStudent))
            {
                detailsPage.ShowDialog();
            }

            LoadAllStudents();
        }

        private void IndexListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student currSelectedStudent = GetSelectedStudent();
            using (StudentDetailsForm detailsPage = new(currSelectedStudent))
            {
                detailsPage.ShowDialog();
            }

            LoadAllStudents();
        }

        private Student GetSelectedStudent()
        {
            ListViewItem selectedRow = this.IndexListView.SelectedItems[0];
            string studentName = selectedRow.SubItems[0].Text;
            return students.FirstOrDefault(s => s.Name == studentName);
        }
    }
}
