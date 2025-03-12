namespace ShkoloApp
{
    partial class AddStudentForm
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
            components = new System.ComponentModel.Container();
            AddStudentLabel = new Label();
            AddButton = new Button();
            NameLabel = new Label();
            GradeLabel = new Label();
            NameTextBox = new TextBox();
            GradeTextBox = new TextBox();
            NameValidationLabel = new Label();
            GradeValidationLabel = new Label();
            errorProviderName = new ErrorProvider(components);
            errorProviderGrade = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderGrade).BeginInit();
            SuspendLayout();
            // 
            // AddStudentLabel
            // 
            AddStudentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddStudentLabel.AutoSize = true;
            AddStudentLabel.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            AddStudentLabel.Location = new Point(185, 40);
            AddStudentLabel.Name = "AddStudentLabel";
            AddStudentLabel.Size = new Size(459, 68);
            AddStudentLabel.TabIndex = 0;
            AddStudentLabel.Text = "Add new student";
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LightGreen;
            AddButton.Cursor = Cursors.Hand;
            AddButton.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.Location = new Point(332, 390);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(173, 74);
            AddButton.TabIndex = 5;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(72, 165);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(91, 32);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name:";
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            GradeLabel.Location = new Point(477, 165);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(90, 32);
            GradeLabel.TabIndex = 4;
            GradeLabel.Text = "Grade";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.LightGray;
            NameTextBox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            NameTextBox.Location = new Point(72, 219);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(300, 39);
            NameTextBox.TabIndex = 1;
            // 
            // GradeTextBox
            // 
            GradeTextBox.BackColor = Color.LightGray;
            GradeTextBox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            GradeTextBox.Location = new Point(477, 219);
            GradeTextBox.Name = "GradeTextBox";
            GradeTextBox.Size = new Size(300, 39);
            GradeTextBox.TabIndex = 2;
            // 
            // NameValidationLabel
            // 
            NameValidationLabel.AutoSize = true;
            NameValidationLabel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            NameValidationLabel.ForeColor = Color.Red;
            NameValidationLabel.Location = new Point(72, 261);
            NameValidationLabel.Name = "NameValidationLabel";
            NameValidationLabel.Size = new Size(277, 19);
            NameValidationLabel.TabIndex = 6;
            NameValidationLabel.Text = "Name should not be an empty string!\r\n";
            // 
            // GradeValidationLabel
            // 
            GradeValidationLabel.AutoSize = true;
            GradeValidationLabel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            GradeValidationLabel.ForeColor = Color.Red;
            GradeValidationLabel.Location = new Point(477, 261);
            GradeValidationLabel.Name = "GradeValidationLabel";
            GradeValidationLabel.Size = new Size(265, 19);
            GradeValidationLabel.TabIndex = 7;
            GradeValidationLabel.Text = "Grade should be between 1 and 12!";
            // 
            // errorProviderName
            // 
            errorProviderName.ContainerControl = this;
            // 
            // errorProviderGrade
            // 
            errorProviderGrade.ContainerControl = this;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(832, 503);
            Controls.Add(GradeValidationLabel);
            Controls.Add(NameValidationLabel);
            Controls.Add(GradeTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(GradeLabel);
            Controls.Add(NameLabel);
            Controls.Add(AddButton);
            Controls.Add(AddStudentLabel);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ((System.ComponentModel.ISupportInitialize)errorProviderName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddStudentLabel;
        private Button AddButton;
        private Label NameLabel;
        private Label GradeLabel;
        private TextBox NameTextBox;
        private TextBox GradeTextBox;
        private Label NameValidationLabel;
        private Label GradeValidationLabel;
        private ErrorProvider errorProviderName;
        private ErrorProvider errorProviderGrade;
    }
}