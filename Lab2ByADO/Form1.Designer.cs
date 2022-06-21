namespace Lab2ByADO
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
            this.searchInstructor = new System.Windows.Forms.ComboBox();
            this.searchSubject = new System.Windows.Forms.ComboBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.campus = new System.Windows.Forms.ComboBox();
            this.instructor = new System.Windows.Forms.ComboBox();
            this.term = new System.Windows.Forms.ComboBox();
            this.subject = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchInstructor
            // 
            this.searchInstructor.FormattingEnabled = true;
            this.searchInstructor.Location = new System.Drawing.Point(412, 21);
            this.searchInstructor.Name = "searchInstructor";
            this.searchInstructor.Size = new System.Drawing.Size(179, 28);
            this.searchInstructor.TabIndex = 37;
            this.searchInstructor.Text = "Instructor";
            this.searchInstructor.SelectionChangeCommitted += new System.EventHandler(this.search_SelectedIndexChanged);
            // 
            // searchSubject
            // 
            this.searchSubject.FormattingEnabled = true;
            this.searchSubject.Location = new System.Drawing.Point(102, 21);
            this.searchSubject.Name = "searchSubject";
            this.searchSubject.Size = new System.Drawing.Size(178, 28);
            this.searchSubject.TabIndex = 36;
            this.searchSubject.Text = "Subject";
            this.searchSubject.SelectionChangeCommitted += new System.EventHandler(this.search_SelectedIndexChanged);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(801, 426);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(94, 29);
            this.Refresh.TabIndex = 35;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(916, 371);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 29);
            this.Delete.TabIndex = 34;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(801, 371);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 29);
            this.Edit.TabIndex = 33;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(684, 371);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 29);
            this.Add.TabIndex = 32;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // campus
            // 
            this.campus.FormattingEnabled = true;
            this.campus.Location = new System.Drawing.Point(772, 312);
            this.campus.Name = "campus";
            this.campus.Size = new System.Drawing.Size(180, 28);
            this.campus.TabIndex = 31;
            // 
            // instructor
            // 
            this.instructor.FormattingEnabled = true;
            this.instructor.Location = new System.Drawing.Point(772, 268);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(180, 28);
            this.instructor.TabIndex = 30;
            // 
            // term
            // 
            this.term.FormattingEnabled = true;
            this.term.Location = new System.Drawing.Point(772, 224);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(180, 28);
            this.term.TabIndex = 29;
            // 
            // subject
            // 
            this.subject.FormattingEnabled = true;
            this.subject.Location = new System.Drawing.Point(772, 185);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(180, 28);
            this.subject.TabIndex = 28;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(772, 143);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(180, 27);
            this.description.TabIndex = 27;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(772, 99);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(180, 27);
            this.code.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(663, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Campus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(662, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Instructor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Term";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Desciption";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(604, 415);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 532);
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

        private System.Windows.Forms.ComboBox searchInstructor;
        private System.Windows.Forms.ComboBox searchSubject;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox campus;
        private System.Windows.Forms.ComboBox instructor;
        private System.Windows.Forms.ComboBox term;
        private System.Windows.Forms.ComboBox subject;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
