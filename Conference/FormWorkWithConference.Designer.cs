namespace Conference
{
    partial class FormWorkWithConference
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewConference = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxThemeName = new System.Windows.Forms.TextBox();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.textBoxSupervisor = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTheme = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelSupervisor = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonWriteStudent = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConference
            // 
            this.dataGridViewConference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnTheme,
            this.ColumnSubject,
            this.ColumnTime,
            this.ColumnRoom,
            this.ColumnSupervisor,
            this.ColumnName});
            this.dataGridViewConference.Location = new System.Drawing.Point(170, 14);
            this.dataGridViewConference.Name = "dataGridViewConference";
            this.dataGridViewConference.Size = new System.Drawing.Size(746, 266);
            this.dataGridViewConference.TabIndex = 0;
            this.dataGridViewConference.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference_CellClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Номер";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnTheme
            // 
            this.ColumnTheme.HeaderText = "Тема";
            this.ColumnTheme.Name = "ColumnTheme";
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.HeaderText = "Предмет";
            this.ColumnSubject.Name = "ColumnSubject";
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Время";
            this.ColumnTime.Name = "ColumnTime";
            // 
            // ColumnRoom
            // 
            this.ColumnRoom.HeaderText = "Аудитория";
            this.ColumnRoom.Name = "ColumnRoom";
            // 
            // ColumnSupervisor
            // 
            this.ColumnSupervisor.HeaderText = "Руководитель";
            this.ColumnSupervisor.Name = "ColumnSupervisor";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя выступающего";
            this.ColumnName.Name = "ColumnName";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(26, 319);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(170, 286);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(26, 366);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(26, 293);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentName.TabIndex = 4;
            // 
            // textBoxThemeName
            // 
            this.textBoxThemeName.Location = new System.Drawing.Point(26, 30);
            this.textBoxThemeName.Name = "textBoxThemeName";
            this.textBoxThemeName.Size = new System.Drawing.Size(100, 20);
            this.textBoxThemeName.TabIndex = 5;
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Location = new System.Drawing.Point(26, 81);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubjectName.TabIndex = 6;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(26, 190);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoomNumber.TabIndex = 8;
            // 
            // textBoxSupervisor
            // 
            this.textBoxSupervisor.Location = new System.Drawing.Point(26, 244);
            this.textBoxSupervisor.Name = "textBoxSupervisor";
            this.textBoxSupervisor.Size = new System.Drawing.Size(100, 20);
            this.textBoxSupervisor.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 277);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(108, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Имя выступающего";
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Location = new System.Drawing.Point(23, 14);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(34, 13);
            this.labelTheme.TabIndex = 11;
            this.labelTheme.Text = "Тема";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(23, 65);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(52, 13);
            this.labelSubject.TabIndex = 12;
            this.labelSubject.Text = "Предмет";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(23, 120);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(40, 13);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "Время";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(23, 174);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(60, 13);
            this.labelRoom.TabIndex = 14;
            this.labelRoom.Text = "Аудитория";
            // 
            // labelSupervisor
            // 
            this.labelSupervisor.AutoSize = true;
            this.labelSupervisor.Location = new System.Drawing.Point(23, 228);
            this.labelSupervisor.Name = "labelSupervisor";
            this.labelSupervisor.Size = new System.Drawing.Size(78, 13);
            this.labelSupervisor.TabIndex = 15;
            this.labelSupervisor.Text = "Руководитель";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(26, 136);
            this.maskedTextBox1.Mask = "00-00-0000 90:00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // buttonWriteStudent
            // 
            this.buttonWriteStudent.Location = new System.Drawing.Point(757, 308);
            this.buttonWriteStudent.Name = "buttonWriteStudent";
            this.buttonWriteStudent.Size = new System.Drawing.Size(159, 52);
            this.buttonWriteStudent.TabIndex = 17;
            this.buttonWriteStudent.Text = "Работа со студентами";
            this.buttonWriteStudent.UseVisualStyleBackColor = true;
            this.buttonWriteStudent.Click += new System.EventHandler(this.buttonWriteStudent_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(26, 418);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(84, 45);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "Очистить поля";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormWorkWithConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 478);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonWriteStudent);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labelSupervisor);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxSupervisor);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.textBoxSubjectName);
            this.Controls.Add(this.textBoxThemeName);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewConference);
            this.Name = "FormWorkWithConference";
            this.Text = "Студенческие конференции";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConference;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxThemeName;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.TextBox textBoxSupervisor;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelSupervisor;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonWriteStudent;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
    }
}

