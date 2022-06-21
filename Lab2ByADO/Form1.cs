using Lab2ByADO.Logics;
using Lab2ByEntityFramwork.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab2ByADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Course(List<Course> courses)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Course Code";
            dataGridView1.Columns[1].Name = "Course Description";
            dataGridView1.Columns[2].Name = "Subject Name";
            dataGridView1.Columns[3].Name = "Instructor Name";
            dataGridView1.Columns[4].Name = "Term Name";
            dataGridView1.Columns[5].Name = "Campus Name";
            foreach (Course course in courses)
            {
                dataGridView1.Rows.Add(course.CourseCode, course.CourseDescription, course.Subject.SubjectName, course.Instructor.InstructorFirstName, course.Term.TermName, course.Campus.CampusName);
            }
        }

        private void Load_Search_Subject()
        {
            List<Subject> listSubject = new List<Subject>();
            listSubject.Add(new Subject
            {
                SubjectId = 0,
                SubjectName = "All Subject"
            });
            listSubject.AddRange(CourseManager.GetAllSubject());
            searchSubject.DataSource = listSubject;
            searchSubject.ValueMember = "SubjectId";
            searchSubject.DisplayMember = "SubjectName";
        }

        private void Load_Search_Instructor()
        {
            List<Instructor> listInstructor = new List<Instructor>();
            listInstructor.Add(new Instructor
            {
                InstructorId = 0,
                InstructorFirstName = "All Instructor"
            });
            listInstructor.AddRange(CourseManager.GetAllInstructor());
            searchInstructor.DataSource = listInstructor;
            searchInstructor.ValueMember = "InstructorId";
            searchInstructor.DisplayMember = "InstructorFirstName";
        }

        private void Load_Subject()
        {
            subject.DataSource = CourseManager.GetAllSubject();
            subject.ValueMember = "SubjectId";
            subject.DisplayMember = "SubjectName";
        }

        private void Load_Instructor()
        {
            instructor.DataSource = CourseManager.GetAllInstructor();
            instructor.ValueMember = "InstructorId";
            instructor.DisplayMember = "InstructorFirstName";
        }

        private void Load_Term()
        {
            term.DataSource = CourseManager.GetAllTerm();
            term.ValueMember = "TermId";
            term.DisplayMember = "TermName";
        }

        private void Load_Campus()
        {
            campus.DataSource = CourseManager.GetAllCampus();
            campus.ValueMember = "CampusId";
            campus.DisplayMember = "CampusName";
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Load_Course(CourseManager.GetAllCourse());
            Load_Search_Subject();
            Load_Search_Instructor();
            Load_Subject();
            Load_Instructor();
            Load_Term();
            Load_Campus();
        }

        private bool isValid()
        {
            if (String.IsNullOrWhiteSpace(code.Text) || String.IsNullOrWhiteSpace(description.Text))
            {
                return false;
            }
            return true;
        }

        private bool Dupbicate_Code()
        {
            foreach (var course in CourseManager.GetAllCourse())
            {
                if (course.CourseCode.Equals(code.Text))
                {
                    return true;
                }
            }
            return false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (isValid() && !Dupbicate_Code())
            {
                CourseManager.AddCourse(
                    code.Text,
                    description.Text,
                    (int)subject.SelectedValue,
                    (int)instructor.SelectedValue,
                    (int)term.SelectedValue,
                    (int)campus.SelectedValue);
                MessageBox.Show("Add Course Successfully");
                dataGridView1.Rows.Clear();
                Load_Course(CourseManager.GetAllCourse());
            }
            else
            {
                MessageBox.Show("Can't Add Course");
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (isValid() && !Dupbicate_Code())
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string CourseCode = row.Cells[0].Value.ToString();
                    CourseManager.EditCourse(
                      CourseCode,
                      code.Text,
                      description.Text,
                      (int)subject.SelectedValue,
                      (int)instructor.SelectedValue,
                      (int)term.SelectedValue,
                      (int)campus.SelectedValue);
                }
                MessageBox.Show("Edit Course Successfully");
                dataGridView1.Rows.Clear();
                Load_Course(CourseManager.GetAllCourse());
            }
            else
            {
                MessageBox.Show("Can't Edit Course");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string courdeCode = row.Cells[0].Value.ToString();
                Course course = CourseManager.GetCourseByCode(courdeCode);
                code.Text = course.CourseCode;
                description.Text = course.CourseDescription;
                subject.SelectedValue = course.SubjectId;
                term.SelectedValue = course.TermId;
                instructor.SelectedValue = course.InstructorId;
                campus.SelectedValue = course.CampusId;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string CourseCode = row.Cells[0].Value.ToString();
                    CourseManager.DeleteCourseByCode(CourseCode);
                }
                MessageBox.Show("Delete Course Successfully");
                dataGridView1.Rows.Clear();
                Load_Course(CourseManager.GetAllCourse());
            }
            else
            {
                MessageBox.Show("Can't Delete Course");
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            subject.SelectedValue = 20;
            term.SelectedValue = 1;
            instructor.SelectedValue = 1;
            campus.SelectedValue = 1;
            code.Text = "";
            description.Text = "";
            searchSubject.SelectedValue = 0;
            searchInstructor.SelectedValue = 0;
            Load_Course(CourseManager.GetAllCourse());
        }

        private void search_SelectedIndexChanged(object sender, EventArgs e)
        {
            int subjectValue = 0;
            Int32.TryParse(searchSubject.SelectedValue.ToString(), out subjectValue);
            int instructorValue = 0;
            Int32.TryParse(searchInstructor.SelectedValue.ToString(), out instructorValue);
            if (subjectValue == 0 && instructorValue == 0)
            {
                dataGridView1.Rows.Clear();
                Load_Course(CourseManager.GetAllCourse());
            }
            else if (instructorValue == 0)
            {
                dataGridView1.Rows.Clear();
                Load_Course(CourseManager.GetCourseBySubject(subjectValue));
            }
            else if (subjectValue == 0)
            {
                dataGridView1.Rows.Clear();
                Load_Course(CourseManager.GetCourseByInstructor(instructorValue));
            }
            else
            {
                dataGridView1.Rows.Clear();
                Load_Course(CourseManager.GetCourseBySubjectAndInstructor(subjectValue, instructorValue));
            }
        }
    }
}
