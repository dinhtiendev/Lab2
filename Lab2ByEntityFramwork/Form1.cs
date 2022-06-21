using Lab2ByEntityFramwork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab2ByEntityFramwork
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Course();
            Load_Search_Subject();
            Load_Search_Instructor();
            Load_Input_Subject();
            Load_Input_Instructor();
            Load_Input_Term();
            Load_Input_Campus();
        }

        private void Load_Course()
        {
            using (var context = new APContext())
            {
                dataGridView1.DataSource = context.Courses
                    .Select(x => new
                    {
                        x.CourseCode,
                        x.CourseDescription,
                        x.Subject.SubjectName,
                        x.Instructor.InstructorFirstName,
                        x.Term.TermName,
                        x.Campus.CampusName
                    })
                    .ToList();
            }
        }
        // Search course by subject and instructor
        private void Load_Search_Subject()
        {
            using (var context = new APContext())
            {
                var list = new List<Subject>();
                list.Add(new Subject
                {
                    SubjectId = 0,
                    SubjectName = "All subject"
                });
                list.AddRange(context.Subjects);
                searchSubject.DataSource = list;
                searchSubject.ValueMember = "SubjectId";
                searchSubject.DisplayMember = "SubjectName";
            }
        }

        private void Load_Search_Instructor()
        {
            using (var context = new APContext())
            {
                var list = new List<Instructor>();
                list.Add(new Instructor
                {
                    InstructorId = 0,
                    InstructorFirstName = "All instructor"
                });
                list.AddRange(context.Instructors);
                searchInstructor.DataSource = list;
                searchInstructor.ValueMember = "InstructorId";
                searchInstructor.DisplayMember = "InstructorFirstName";
            }
        }

        private void Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subjectValue = Convert.ToString(searchSubject.SelectedValue);
            string instructorValue = Convert.ToString(searchInstructor.SelectedValue);
            if (subjectValue.Equals("0") && instructorValue.Equals("0"))
            {
                Load_Course();
            }
            else if (subjectValue.Equals("0"))
            {
                using (var context = new APContext())
                {
                    dataGridView1.DataSource = context.Courses
                        .Where(x => x.InstructorId.ToString().Equals(instructorValue))
                        .Select(x => new
                        {
                            x.CourseCode,
                            x.CourseDescription,
                            x.Subject.SubjectName,
                            x.Instructor.InstructorFirstName,
                            x.Term.TermName,
                            x.Campus.CampusName
                        })
                        .ToList();
                }
            }
            else if (instructorValue.Equals("0"))
            {
                using (var context = new APContext())
                {
                    dataGridView1.DataSource = context.Courses
                        .Where(x => x.SubjectId.ToString().Equals(subjectValue))
                        .Select(x => new
                        {
                            x.CourseCode,
                            x.CourseDescription,
                            x.Subject.SubjectName,
                            x.Instructor.InstructorFirstName,
                            x.Term.TermName,
                            x.Campus.CampusName
                        })
                        .ToList();
                }
            }
            else
            {
                using (var context = new APContext())
                {
                    dataGridView1.DataSource = context.Courses
                        .Where(x => x.SubjectId.ToString().Equals(subjectValue) && x.InstructorId.ToString().Equals(instructorValue))
                        .Select(x => new
                        {
                            x.CourseCode,
                            x.CourseDescription,
                            x.Subject.SubjectName,
                            x.Instructor.InstructorFirstName,
                            x.Term.TermName,
                            x.Campus.CampusName
                        })
                        .ToList();
                }
            }
        }
        //Add - Edit - Delete
        private void Load_Input_Subject()
        {
            using (var context = new APContext())
            {
                subject.DataSource = context.Subjects
                    .Select(x => new { x.SubjectId, x.SubjectName })
                    .ToList();
                subject.ValueMember = "SubjectId";
                subject.DisplayMember = "SubjectName";
            }
        }

        private void Load_Input_Instructor()
        {
            using (var context = new APContext())
            {
                instructor.DataSource = context.Instructors
                    .Select(x => new { x.InstructorId, x.InstructorFirstName })
                    .ToList();
                instructor.ValueMember = "InstructorId";
                instructor.DisplayMember = "InstructorFirstName";
            }
        }

        private void Load_Input_Term()
        {
            using (var context = new APContext())
            {
                term.DataSource = context.Terms
                    .Select(x => new { x.TermId, x.TermName })
                    .ToList();
                term.ValueMember = "TermId";
                term.DisplayMember = "TermName";
            }
        }

        private void Load_Input_Campus()
        {
            using (var context = new APContext())
            {
                campus.DataSource = context.Campuses
                    .Select(x => new { x.CampusId, x.CampusName })
                    .ToList();
                campus.ValueMember = "CampusId";
                campus.DisplayMember = "CampusName";
            }
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
            using (var context = new APContext())
            {
                foreach (var course in context.Courses.ToList())
                {
                    if (course.CourseCode.Equals(code.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (isValid() && !Dupbicate_Code())
            {
                using (var context = new APContext())
                {
                    context.Courses.Add(new Course
                    {
                        CourseCode = code.Text,
                        CourseDescription = description.Text,
                        SubjectId = (int)subject.SelectedValue,
                        TermId = (int)term.SelectedValue,
                        InstructorId = (int)instructor.SelectedValue,
                        CampusId = (int)campus.SelectedValue
                    });
                    context.SaveChanges();
                }
                MessageBox.Show("Add Course Successfully");
                Load_Course();
            }
            else
            {
                MessageBox.Show("Can't Add Course");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new APContext())
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string CourseCode = row.Cells[0].Value.ToString();
                    Course course = context.Courses.FirstOrDefault(x => x.CourseCode.Equals(CourseCode));
                    code.Text = course.CourseCode;
                    description.Text = course.CourseDescription;
                    subject.SelectedValue = course.SubjectId;
                    term.SelectedValue = course.TermId;
                    instructor.SelectedValue = course.InstructorId;
                    campus.SelectedValue = course.CampusId;
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (var context = new APContext())
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        string CourseCode = row.Cells[0].Value.ToString();
                        Course course = context.Courses.FirstOrDefault(x => x.CourseCode.Equals(CourseCode));

                        course.CourseCode = code.Text;
                        course.CourseDescription = description.Text;
                        course.SubjectId = (int)subject.SelectedValue;
                        course.InstructorId = (int)instructor.SelectedValue;
                        course.TermId = (int)term.SelectedValue;
                        course.CampusId = (int)campus.SelectedValue;

                    }
                    context.SaveChanges();
                }
                MessageBox.Show("Edit Course Successfully");
                Load_Course();
            }
            else
            {
                MessageBox.Show("Can't Edit Course");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (var context = new APContext())
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        string CourseCode = row.Cells[0].Value.ToString();
                        Course course = context.Courses.FirstOrDefault(x => x.CourseCode.Equals(CourseCode));
                        context.Courses.Remove(course);
                    }
                    context.SaveChanges();
                }
                MessageBox.Show("Delete Course Successfully");
                Load_Course();
            }
            else
            {
                MessageBox.Show("Can't Delete Course");
            }
        }
        //Refresh
        private void Refresh_Click(object sender, EventArgs e)
        {
            using (var context = new APContext())
            {
                subject.SelectedValue = context.Subjects.First().SubjectId;
                term.SelectedValue = context.Terms.First().TermId;
                instructor.SelectedValue = context.Instructors.First().InstructorId;
                campus.SelectedValue = context.Campuses.First().CampusId;
            }
            code.Text = "";
            description.Text = "";
            searchSubject.SelectedValue = 0;
            searchInstructor.SelectedValue = 0;
            Load_Course();
        }
    }
}
