namespace ExpertSystem
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
            txtTemperature = new TextBox();
            cmbAge = new ComboBox();
            btnAnalize = new Button();
            clbSymptoms = new CheckedListBox();
            symptoms = new Label();
            label1 = new Label();
            label2 = new Label();
            symptomsDuration = new GroupBox();
            rbLess1Day = new RadioButton();
            rb1to3Days = new RadioButton();
            rbMoreThan3Days = new RadioButton();
            label3 = new Label();
            malaiseDegree = new GroupBox();
            rbStrong = new RadioButton();
            rbModerate = new RadioButton();
            rbMild = new RadioButton();
            label4 = new Label();
            symptomsDuration.SuspendLayout();
            malaiseDegree.SuspendLayout();
            SuspendLayout();
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(303, 88);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(176, 27);
            txtTemperature.TabIndex = 0;
            txtTemperature.Text = "36,5";
            // 
            // cmbAge
            // 
            cmbAge.FormattingEnabled = true;
            cmbAge.Items.AddRange(new object[] { "Ребёнок", "Подросток", "Взрослый", "Пожилой" });
            cmbAge.Location = new Point(519, 88);
            cmbAge.Name = "cmbAge";
            cmbAge.Size = new Size(176, 28);
            cmbAge.TabIndex = 1;
            // 
            // btnAnalize
            // 
            btnAnalize.Location = new Point(297, 230);
            btnAnalize.Name = "btnAnalize";
            btnAnalize.Size = new Size(231, 126);
            btnAnalize.TabIndex = 3;
            btnAnalize.Text = "Диагностика";
            btnAnalize.UseVisualStyleBackColor = true;
            btnAnalize.Click += btnAnalyze_Click;
            // 
            // clbSymptoms
            // 
            clbSymptoms.FormattingEnabled = true;
            clbSymptoms.Items.AddRange(new object[] { "Кашель", "Головная боль", "Слабость", "Насморк", "Боль в горле" });
            clbSymptoms.Location = new Point(114, 46);
            clbSymptoms.Name = "clbSymptoms";
            clbSymptoms.Size = new Size(150, 114);
            clbSymptoms.TabIndex = 4;
            // 
            // symptoms
            // 
            symptoms.AutoSize = true;
            symptoms.Location = new Point(109, 163);
            symptoms.Name = "symptoms";
            symptoms.Size = new Size(155, 20);
            symptoms.TabIndex = 5;
            symptoms.Text = "Выберите симптомы";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 118);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 6;
            label1.Text = "Введите температуру";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(538, 118);
            label2.Name = "label2";
            label2.Size = new Size(142, 40);
            label2.TabIndex = 7;
            label2.Text = "Выберите свою\r\nвозрастную группу";
            // 
            // symptomsDuration
            // 
            symptomsDuration.Controls.Add(rbLess1Day);
            symptomsDuration.Controls.Add(rb1to3Days);
            symptomsDuration.Controls.Add(rbMoreThan3Days);
            symptomsDuration.Location = new Point(51, 207);
            symptomsDuration.Name = "symptomsDuration";
            symptomsDuration.Size = new Size(155, 125);
            symptomsDuration.TabIndex = 8;
            symptomsDuration.TabStop = false;
            // 
            // rbLess1Day
            // 
            rbLess1Day.AutoSize = true;
            rbLess1Day.Location = new Point(6, 34);
            rbLess1Day.Name = "rbLess1Day";
            rbLess1Day.Size = new Size(75, 24);
            rbLess1Day.TabIndex = 9;
            rbLess1Day.TabStop = true;
            rbLess1Day.Text = "1 день";
            rbLess1Day.UseVisualStyleBackColor = true;
            // 
            // rb1to3Days
            // 
            rb1to3Days.AutoSize = true;
            rb1to3Days.Location = new Point(6, 65);
            rb1to3Days.Name = "rb1to3Days";
            rb1to3Days.Size = new Size(81, 24);
            rb1to3Days.TabIndex = 10;
            rb1to3Days.TabStop = true;
            rb1to3Days.Text = "1-3 дня";
            rb1to3Days.UseVisualStyleBackColor = true;
            // 
            // rbMoreThan3Days
            // 
            rbMoreThan3Days.AutoSize = true;
            rbMoreThan3Days.Location = new Point(6, 95);
            rbMoreThan3Days.Name = "rbMoreThan3Days";
            rbMoreThan3Days.Size = new Size(122, 24);
            rbMoreThan3Days.TabIndex = 11;
            rbMoreThan3Days.TabStop = true;
            rbMoreThan3Days.Text = "Более 3 дней";
            rbMoreThan3Days.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 335);
            label3.Name = "label3";
            label3.Size = new Size(103, 60);
            label3.TabIndex = 9;
            label3.Text = "Выберите\r\nдлительность\r\nсимптомов";
            // 
            // malaiseDegree
            // 
            malaiseDegree.Controls.Add(rbStrong);
            malaiseDegree.Controls.Add(rbModerate);
            malaiseDegree.Controls.Add(rbMild);
            malaiseDegree.Location = new Point(619, 207);
            malaiseDegree.Name = "malaiseDegree";
            malaiseDegree.Size = new Size(149, 125);
            malaiseDegree.TabIndex = 10;
            malaiseDegree.TabStop = false;
            // 
            // rbStrong
            // 
            rbStrong.AutoSize = true;
            rbStrong.Location = new Point(0, 95);
            rbStrong.Name = "rbStrong";
            rbStrong.Size = new Size(89, 24);
            rbStrong.TabIndex = 2;
            rbStrong.TabStop = true;
            rbStrong.Text = "Сильная";
            rbStrong.UseVisualStyleBackColor = true;
            // 
            // rbModerate
            // 
            rbModerate.AutoSize = true;
            rbModerate.Location = new Point(0, 65);
            rbModerate.Name = "rbModerate";
            rbModerate.Size = new Size(89, 24);
            rbModerate.TabIndex = 1;
            rbModerate.TabStop = true;
            rbModerate.Text = "Средняя";
            rbModerate.UseVisualStyleBackColor = true;
            // 
            // rbMild
            // 
            rbMild.AutoSize = true;
            rbMild.Location = new Point(0, 38);
            rbMild.Name = "rbMild";
            rbMild.Size = new Size(77, 24);
            rbMild.TabIndex = 0;
            rbMild.TabStop = true;
            rbMild.Text = "Легкая";
            rbMild.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(641, 335);
            label4.Name = "label4";
            label4.Size = new Size(103, 60);
            label4.TabIndex = 11;
            label4.Text = "Выберите\r\nстепень\r\nнедомогания";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(label4);
            Controls.Add(malaiseDegree);
            Controls.Add(label3);
            Controls.Add(symptomsDuration);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(symptoms);
            Controls.Add(clbSymptoms);
            Controls.Add(btnAnalize);
            Controls.Add(cmbAge);
            Controls.Add(txtTemperature);
            Name = "Form1";
            Text = "Сипмтомы";
            symptomsDuration.ResumeLayout(false);
            symptomsDuration.PerformLayout();
            malaiseDegree.ResumeLayout(false);
            malaiseDegree.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTemperature;
        private ComboBox cmbAge;
        private Button btnAnalize;
        private CheckedListBox clbSymptoms;
        private Label symptoms;
        private Label label1;
        private Label label2;
        private GroupBox symptomsDuration;
        private RadioButton rbLess1Day;
        private RadioButton rb1to3Days;
        private RadioButton rbMoreThan3Days;
        private Label label3;
        private GroupBox malaiseDegree;
        private RadioButton rbStrong;
        private RadioButton rbModerate;
        private RadioButton rbMild;
        private Label label4;
    }
}
