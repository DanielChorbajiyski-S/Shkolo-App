namespace ShkoloApp
{
    partial class StudentDetailsForm
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
            StudentDetailsLabel = new Label();
            StudentNameLabel = new Label();
            StudentGradeLabel = new Label();
            AverageLabel = new Label();
            ExcusedLabel = new Label();
            UnexcusedLabel = new Label();
            TotalLabel = new Label();
            StudentName = new Label();
            StudentGrade = new Label();
            Average = new Label();
            ExcusedNumber = new Label();
            UnexcusedNumber = new Label();
            TotalNumber = new Label();
            listView1 = new ListView();
            SubjectColumn = new ColumnHeader();
            MarkColumn = new ColumnHeader();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            button2 = new Button();
            listBoxType = new ListBox();
            numericUpDown1 = new NumericUpDown();
            labelTooManyAbsences = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // StudentDetailsLabel
            // 
            StudentDetailsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudentDetailsLabel.AutoSize = true;
            StudentDetailsLabel.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            StudentDetailsLabel.Location = new Point(237, 25);
            StudentDetailsLabel.Name = "StudentDetailsLabel";
            StudentDetailsLabel.Size = new Size(323, 53);
            StudentDetailsLabel.TabIndex = 0;
            StudentDetailsLabel.Text = "Student details";
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            StudentNameLabel.Location = new Point(48, 136);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.Size = new Size(188, 32);
            StudentNameLabel.TabIndex = 1;
            StudentNameLabel.Text = "Student name:";
            // 
            // StudentGradeLabel
            // 
            StudentGradeLabel.AutoSize = true;
            StudentGradeLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            StudentGradeLabel.Location = new Point(48, 179);
            StudentGradeLabel.Name = "StudentGradeLabel";
            StudentGradeLabel.Size = new Size(192, 32);
            StudentGradeLabel.TabIndex = 2;
            StudentGradeLabel.Text = "Student grade:";
            // 
            // AverageLabel
            // 
            AverageLabel.AutoSize = true;
            AverageLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            AverageLabel.Location = new Point(48, 223);
            AverageLabel.Name = "AverageLabel";
            AverageLabel.Size = new Size(119, 32);
            AverageLabel.TabIndex = 3;
            AverageLabel.Text = "Average:";
            // 
            // ExcusedLabel
            // 
            ExcusedLabel.AutoSize = true;
            ExcusedLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ExcusedLabel.Location = new Point(48, 394);
            ExcusedLabel.Name = "ExcusedLabel";
            ExcusedLabel.Size = new Size(123, 32);
            ExcusedLabel.TabIndex = 4;
            ExcusedLabel.Text = "Excused:";
            // 
            // UnexcusedLabel
            // 
            UnexcusedLabel.AutoSize = true;
            UnexcusedLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            UnexcusedLabel.Location = new Point(48, 437);
            UnexcusedLabel.Name = "UnexcusedLabel";
            UnexcusedLabel.Size = new Size(152, 32);
            UnexcusedLabel.TabIndex = 5;
            UnexcusedLabel.Text = "Unexcused:";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLabel.Location = new Point(48, 484);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(83, 32);
            TotalLabel.TabIndex = 6;
            TotalLabel.Text = "Total:";
            // 
            // StudentName
            // 
            StudentName.AutoSize = true;
            StudentName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            StudentName.Location = new Point(237, 141);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(152, 25);
            StudentName.TabIndex = 7;
            StudentName.Text = "Student name";
            // 
            // StudentGrade
            // 
            StudentGrade.AutoSize = true;
            StudentGrade.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            StudentGrade.Location = new Point(237, 184);
            StudentGrade.Name = "StudentGrade";
            StudentGrade.Size = new Size(155, 25);
            StudentGrade.TabIndex = 8;
            StudentGrade.Text = "Student grade";
            // 
            // Average
            // 
            Average.AutoSize = true;
            Average.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Average.Location = new Point(173, 228);
            Average.Name = "Average";
            Average.Size = new Size(93, 25);
            Average.TabIndex = 9;
            Average.Text = "Average";
            // 
            // ExcusedNumber
            // 
            ExcusedNumber.AutoSize = true;
            ExcusedNumber.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ExcusedNumber.Location = new Point(177, 394);
            ExcusedNumber.Name = "ExcusedNumber";
            ExcusedNumber.Size = new Size(28, 32);
            ExcusedNumber.TabIndex = 10;
            ExcusedNumber.Text = "0";
            // 
            // UnexcusedNumber
            // 
            UnexcusedNumber.AutoSize = true;
            UnexcusedNumber.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            UnexcusedNumber.Location = new Point(206, 437);
            UnexcusedNumber.Name = "UnexcusedNumber";
            UnexcusedNumber.Size = new Size(28, 32);
            UnexcusedNumber.TabIndex = 11;
            UnexcusedNumber.Text = "0";
            // 
            // TotalNumber
            // 
            TotalNumber.AutoSize = true;
            TotalNumber.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            TotalNumber.Location = new Point(137, 484);
            TotalNumber.Name = "TotalNumber";
            TotalNumber.Size = new Size(28, 32);
            TotalNumber.TabIndex = 12;
            TotalNumber.Text = "0";
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightGray;
            listView1.Columns.AddRange(new ColumnHeader[] { SubjectColumn, MarkColumn });
            listView1.Location = new Point(434, 141);
            listView1.Name = "listView1";
            listView1.Size = new Size(360, 154);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // SubjectColumn
            // 
            SubjectColumn.Text = "Subject";
            SubjectColumn.Width = 150;
            // 
            // MarkColumn
            // 
            MarkColumn.Text = "Mark";
            MarkColumn.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(309, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 136);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add new mark";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(358, 45);
            button1.Name = "button1";
            button1.Size = new Size(104, 46);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(6, 97);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 4;
            label3.Text = "Please add valid data!";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Mathematics", "Sport", "Informatics" });
            listBox1.Location = new Point(171, 67);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(140, 24);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(209, 45);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 1;
            label2.Text = "Subject";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 44);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 0;
            label1.Text = "Mark";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(listBoxType);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Location = new Point(309, 466);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 125);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Absences";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(15, 93);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 7;
            label4.Text = "Please add valid data!";
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(358, 41);
            button2.Name = "button2";
            button2.Size = new Size(104, 46);
            button2.TabIndex = 6;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listBoxType
            // 
            listBoxType.FormattingEnabled = true;
            listBoxType.ItemHeight = 20;
            listBoxType.Items.AddRange(new object[] { "Unexcused", "Excused" });
            listBoxType.Location = new Point(171, 63);
            listBoxType.Name = "listBoxType";
            listBoxType.Size = new Size(150, 24);
            listBoxType.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(38, 63);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(76, 27);
            numericUpDown1.TabIndex = 0;
            // 
            // labelTooManyAbsences
            // 
            labelTooManyAbsences.AutoSize = true;
            labelTooManyAbsences.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTooManyAbsences.ForeColor = SystemColors.ControlLightLight;
            labelTooManyAbsences.Location = new Point(269, 93);
            labelTooManyAbsences.Name = "labelTooManyAbsences";
            labelTooManyAbsences.Size = new Size(329, 28);
            labelTooManyAbsences.TabIndex = 16;
            labelTooManyAbsences.Text = "This student has too many absences!";
            // 
            // StudentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(832, 603);
            Controls.Add(labelTooManyAbsences);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Controls.Add(TotalNumber);
            Controls.Add(UnexcusedNumber);
            Controls.Add(ExcusedNumber);
            Controls.Add(Average);
            Controls.Add(StudentGrade);
            Controls.Add(StudentName);
            Controls.Add(TotalLabel);
            Controls.Add(UnexcusedLabel);
            Controls.Add(ExcusedLabel);
            Controls.Add(AverageLabel);
            Controls.Add(StudentGradeLabel);
            Controls.Add(StudentNameLabel);
            Controls.Add(StudentDetailsLabel);
            Name = "StudentDetailsForm";
            Text = "StudentDetailsForm";
            Load += StudentDetailsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentDetailsLabel;
        private Label StudentNameLabel;
        private Label StudentGradeLabel;
        private Label AverageLabel;
        private Label ExcusedLabel;
        private Label UnexcusedLabel;
        private Label TotalLabel;
        private Label StudentName;
        private Label StudentGrade;
        private Label Average;
        private Label ExcusedNumber;
        private Label UnexcusedNumber;
        private Label TotalNumber;
        private ListView listView1;
        private ColumnHeader SubjectColumn;
        private ColumnHeader MarkColumn;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button button1;
        private Label label3;
        private ListBox listBox1;
        private ListBox listBoxType;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Button button2;
        private Label labelTooManyAbsences;
    }
}