namespace Lab2ByEntityFramwork
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.ComboBox();
            this.term = new System.Windows.Forms.ComboBox();
            this.instructor = new System.Windows.Forms.ComboBox();
            this.campus = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.searchSubject = new System.Windows.Forms.ComboBox();
            this.searchInstructor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(604, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desciption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Term";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Instructor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Campus";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(744, 111);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(180, 27);
            this.code.TabIndex = 7;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(744, 155);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(180, 27);
            this.description.TabIndex = 8;
            // 
            // subject
            // 
            this.subject.FormattingEnabled = true;
            this.subject.Location = new System.Drawing.Point(744, 197);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(180, 28);
            this.subject.TabIndex = 9;
            // 
            // term
            // 
            this.term.FormattingEnabled = true;
            this.term.Location = new System.Drawing.Point(744, 236);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(180, 28);
            this.term.TabIndex = 10;
            // 
            // instructor
            // 
            this.instructor.FormattingEnabled = true;
            this.instructor.Location = new System.Drawing.Point(744, 280);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(180, 28);
            this.instructor.TabIndex = 11;
            // 
            // campus
            // 
            this.campus.FormattingEnabled = true;
            this.campus.Location = new System.Drawing.Point(744, 324);
            this.campus.Name = "campus";
            this.campus.Size = new System.Drawing.Size(180, 28);
            this.campus.TabIndex = 12;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(656, 383);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 29);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(773, 383);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 29);
            this.Edit.TabIndex = 14;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(888, 383);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 29);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(773, 438);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(94, 29);
            this.Refresh.TabIndex = 16;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // searchSubject
            // 
            this.searchSubject.FormattingEnabled = true;
            this.searchSubject.Location = new System.Drawing.Point(74, 33);
            this.searchSubject.Name = "searchSubject";
            this.searchSubject.Size = new System.Drawing.Size(178, 28);
            this.searchSubject.TabIndex = 17;
            this.searchSubject.Text = "Subject";
            this.searchSubject.SelectedIndexChanged += new System.EventHandler(this.Search_SelectedIndexChanged);
            // 
            // searchInstructor
            // 
            this.searchInstructor.FormattingEnabled = true;
            this.searchInstructor.Location = new System.Drawing.Point(384, 33);
            this.searchInstructor.Name = "searchInstructor";
            this.searchInstructor.Size = new System.Drawing.Size(179, 28);
            this.searchInstructor.TabIndex = 18;
            this.searchInstructor.Text = "Instructor";
            this.searchInstructor.SelectedIndexChanged += new System.EventHandler(this.Search_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 528);
            this.Controls.Add(this.searchInstructor);
            this.Controls.Add(this.searchSubject);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.campus);
            this.Controls.Add(this.instructor);
            this.Controls.Add(this.term);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.description);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ComboBox subject;
        private System.Windows.Forms.ComboBox term;
        private System.Windows.Forms.ComboBox instructor;
        private System.Windows.Forms.ComboBox campus;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ComboBox searchSubject;
        private System.Windows.Forms.ComboBox searchInstructor;
    }
}
