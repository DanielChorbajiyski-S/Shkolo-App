namespace ShkoloApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ShkoloLabel = new Label();
            IndexListView = new ListView();
            NameColumn = new ColumnHeader();
            MathematicsColumn = new ColumnHeader();
            InformaticsColumn = new ColumnHeader();
            SportColumn = new ColumnHeader();
            NewStudentButton = new Button();
            SuspendLayout();
            // 
            // ShkoloLabel
            // 
            ShkoloLabel.Anchor = AnchorStyles.Top;
            ShkoloLabel.AutoSize = true;
            ShkoloLabel.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            ShkoloLabel.ForeColor = SystemColors.ControlText;
            ShkoloLabel.Location = new Point(320, 30);
            ShkoloLabel.Name = "ShkoloLabel";
            ShkoloLabel.Size = new Size(201, 68);
            ShkoloLabel.TabIndex = 0;
            ShkoloLabel.Text = "Shkolo";
            // 
            // IndexListView
            // 
            IndexListView.BackColor = Color.LightGray;
            IndexListView.Columns.AddRange(new ColumnHeader[] { NameColumn, MathematicsColumn, InformaticsColumn, SportColumn });
            IndexListView.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IndexListView.Location = new Point(70, 160);
            IndexListView.Name = "IndexListView";
            IndexListView.Size = new Size(700, 320);
            IndexListView.TabIndex = 1;
            IndexListView.UseCompatibleStateImageBehavior = false;
            IndexListView.View = View.Details;
            IndexListView.SelectedIndexChanged += IndexListView_SelectedIndexChanged;
            // 
            // NameColumn
            // 
            NameColumn.Text = "Name";
            NameColumn.Width = 160;
            // 
            // MathematicsColumn
            // 
            MathematicsColumn.Text = "Maths";
            MathematicsColumn.Width = 180;
            // 
            // InformaticsColumn
            // 
            InformaticsColumn.Text = "Informatics";
            InformaticsColumn.Width = 180;
            // 
            // SportColumn
            // 
            SportColumn.Text = "Sport";
            SportColumn.Width = 175;
            // 
            // NewStudentButton
            // 
            NewStudentButton.BackColor = Color.LightGreen;
            NewStudentButton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            NewStudentButton.ForeColor = SystemColors.ControlText;
            NewStudentButton.Location = new Point(584, 34);
            NewStudentButton.Name = "NewStudentButton";
            NewStudentButton.Size = new Size(186, 64);
            NewStudentButton.TabIndex = 2;
            NewStudentButton.Text = "Add student";
            NewStudentButton.UseVisualStyleBackColor = false;
            NewStudentButton.Click += NewStudentButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(832, 503);
            Controls.Add(NewStudentButton);
            Controls.Add(IndexListView);
            Controls.Add(ShkoloLabel);
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            Text = "IndexForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ShkoloLabel;
        private ListView IndexListView;
        private ColumnHeader NameColumn;
        private ColumnHeader MathematicsColumn;
        private ColumnHeader InformaticsColumn;
        private ColumnHeader SportColumn;
        private Button NewStudentButton;
    }
}
