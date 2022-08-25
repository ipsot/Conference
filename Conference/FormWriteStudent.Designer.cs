namespace Conference
{
    partial class FormWriteStudent
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExitToMain = new System.Windows.Forms.Button();
            this.buttonWhoWrite = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.textBoxNameStudent = new System.Windows.Forms.TextBox();
            this.textBoxNumberConference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewWhoIsWrite = new System.Windows.Forms.DataGridView();
            this.ColumnIdConference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxKnowWhoGo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewConference = new System.Windows.Forms.DataGridView();
            this.ColumnNumberConference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnThemeConference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWhoIsWrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(81, 165);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExitToMain
            // 
            this.buttonExitToMain.Location = new System.Drawing.Point(81, 254);
            this.buttonExitToMain.Name = "buttonExitToMain";
            this.buttonExitToMain.Size = new System.Drawing.Size(75, 23);
            this.buttonExitToMain.TabIndex = 1;
            this.buttonExitToMain.Text = "На главную";
            this.buttonExitToMain.UseVisualStyleBackColor = true;
            this.buttonExitToMain.Click += new System.EventHandler(this.buttonExitToMain_Click);
            // 
            // buttonWhoWrite
            // 
            this.buttonWhoWrite.Location = new System.Drawing.Point(238, 282);
            this.buttonWhoWrite.Name = "buttonWhoWrite";
            this.buttonWhoWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonWhoWrite.TabIndex = 2;
            this.buttonWhoWrite.Text = "Узнать";
            this.buttonWhoWrite.UseVisualStyleBackColor = true;
            this.buttonWhoWrite.Click += new System.EventHandler(this.buttonWhoWrite_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Location = new System.Drawing.Point(393, 256);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(111, 36);
            this.buttonDeleteStudent.TabIndex = 3;
            this.buttonDeleteStudent.Text = "Удалить студента";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // textBoxNameStudent
            // 
            this.textBoxNameStudent.Location = new System.Drawing.Point(67, 46);
            this.textBoxNameStudent.Name = "textBoxNameStudent";
            this.textBoxNameStudent.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameStudent.TabIndex = 4;
            // 
            // textBoxNumberConference
            // 
            this.textBoxNumberConference.Location = new System.Drawing.Point(67, 125);
            this.textBoxNumberConference.Name = "textBoxNumberConference";
            this.textBoxNumberConference.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberConference.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя студента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер коференции";
            // 
            // dataGridViewWhoIsWrite
            // 
            this.dataGridViewWhoIsWrite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWhoIsWrite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdConference,
            this.ColumnNameStudent});
            this.dataGridViewWhoIsWrite.Location = new System.Drawing.Point(226, 46);
            this.dataGridViewWhoIsWrite.Name = "dataGridViewWhoIsWrite";
            this.dataGridViewWhoIsWrite.Size = new System.Drawing.Size(245, 182);
            this.dataGridViewWhoIsWrite.TabIndex = 8;
            // 
            // ColumnIdConference
            // 
            this.ColumnIdConference.HeaderText = "Номер конференции";
            this.ColumnIdConference.Name = "ColumnIdConference";
            // 
            // ColumnNameStudent
            // 
            this.ColumnNameStudent.HeaderText = "Имя студента";
            this.ColumnNameStudent.Name = "ColumnNameStudent";
            // 
            // textBoxKnowWhoGo
            // 
            this.textBoxKnowWhoGo.Location = new System.Drawing.Point(238, 256);
            this.textBoxKnowWhoGo.Name = "textBoxKnowWhoGo";
            this.textBoxKnowWhoGo.Size = new System.Drawing.Size(117, 20);
            this.textBoxKnowWhoGo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Узнать кто записан на конференцию";
            // 
            // dataGridViewConference
            // 
            this.dataGridViewConference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumberConference,
            this.ColumnThemeConference});
            this.dataGridViewConference.Location = new System.Drawing.Point(559, 46);
            this.dataGridViewConference.Name = "dataGridViewConference";
            this.dataGridViewConference.Size = new System.Drawing.Size(244, 207);
            this.dataGridViewConference.TabIndex = 11;
            // 
            // ColumnNumberConference
            // 
            this.ColumnNumberConference.HeaderText = "Номер коференции";
            this.ColumnNumberConference.Name = "ColumnNumberConference";
            // 
            // ColumnThemeConference
            // 
            this.ColumnThemeConference.HeaderText = "Тема";
            this.ColumnThemeConference.Name = "ColumnThemeConference";
            // 
            // FormWriteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.dataGridViewConference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKnowWhoGo);
            this.Controls.Add(this.dataGridViewWhoIsWrite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumberConference);
            this.Controls.Add(this.textBoxNameStudent);
            this.Controls.Add(this.buttonDeleteStudent);
            this.Controls.Add(this.buttonWhoWrite);
            this.Controls.Add(this.buttonExitToMain);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormWriteStudent";
            this.Text = "FormWriteStudent";
            this.Load += new System.EventHandler(this.FormWriteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWhoIsWrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExitToMain;
        private System.Windows.Forms.Button buttonWhoWrite;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.TextBox textBoxNameStudent;
        private System.Windows.Forms.TextBox textBoxNumberConference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewWhoIsWrite;
        private System.Windows.Forms.TextBox textBoxKnowWhoGo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdConference;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameStudent;
        private System.Windows.Forms.DataGridView dataGridViewConference;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumberConference;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnThemeConference;
    }
}