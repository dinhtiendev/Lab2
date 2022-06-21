using Lab2ByEntityFramwork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Lab2ByADO.DataAccess
{
    internal class CourseDAO
    {

        private static List<Course> ConvertToListCourse(DataTable dt)
        {
            List<Course> list = new List<Course>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Course
                {
                    CourseId = Convert.ToInt32(dr[0]),
                    CourseCode = Convert.ToString(dr[1]),
                    CourseDescription = Convert.ToString(dr[2]),
                    Subject = new Subject
                    {
                        SubjectId = Convert.ToInt32(dr[3]),
                        SubjectName = Convert.ToString(dr[4]),
                    }
                    ,
                    Instructor = new Instructor
                    {
                        InstructorId = Convert.ToInt32(dr[5]),
                        InstructorFirstName = Convert.ToString(dr[6]),
                    },
                    Term = new Term
                    {
                        TermId = Convert.ToInt32(dr[7]),
                        TermName = Convert.ToString(dr[8]),
                    },
                    Campus = new Campus
                    {
                        CampusId = Convert.ToInt32(dr[9]),
                        CampusName = Convert.ToString(dr[10]),
                    }

                });
            }
            return list;
        }

        internal static void DeleteCourseByCode(string courseCode)
        {
            string sql = "delete COURSES where CourseCode = @courseCode";
            SqlParameter parameter = new SqlParameter("@courseCode", DbType.String);
            parameter.Value = courseCode;
            DAO.ExecuteSql(sql, parameter);
        }

        internal static List<Course> GetCourseByInstructor(int instructorValue)
        {
            string sql = "select c.CourseId, c.CourseCode, c.CourseDescription, " +
                "s.SubjectId, s.SubjectName, i.InstructorId, i.InstructorFirstName, " +
                "t.TermId, t.TermName, cp.CampusId, cp.CampusName from COURSES c " +
                "left join SUBJECTS s on c.SubjectId = s.SubjectId " +
                "left join INSTRUCTORS i on c.InstructorId = i.InstructorId " +
                "left join TERMS t on c.TermId = t.TermId " +
                "left join CAMPUSES cp on c.CampusID = cp.CampusId " +
                "where c.InstructorId = @instructorID";
            SqlParameter parameter = new SqlParameter("@instructorID", DbType.Int32);
            parameter.Value = instructorValue;
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            return ConvertToListCourse(dt);
        }

        internal static List<Course> GetCourseBySubjectAndInstructor(int subjectValue, int instructorValue)
        {
            string sql = "select c.CourseId, c.CourseCode, c.CourseDescription, " +
                "s.SubjectId, s.SubjectName, i.InstructorId, i.InstructorFirstName, " +
                "t.TermId, t.TermName, cp.CampusId, cp.CampusName from COURSES c " +
                "left join SUBJECTS s on c.SubjectId = s.SubjectId " +
                "left join INSTRUCTORS i on c.InstructorId = i.InstructorId " +
                "left join TERMS t on c.TermId = t.TermId " +
                "left join CAMPUSES cp on c.CampusID = cp.CampusId " +
                "where c.SubjectId = @subjectID AND c.InstructorId = @instructorID";
            SqlParameter parameter1 = new SqlParameter("@subjectID", DbType.Int32);
            parameter1.Value = subjectValue;
            SqlParameter parameter2 = new SqlParameter("@instructorID", DbType.Int32);
            parameter2.Value = instructorValue;
            DataTable dt = DAO.GetDataBySql(sql, parameter1, parameter2);
            return ConvertToListCourse(dt);
        }

        internal static List<Course> GetCourseBySubject(int subjectValue)
        {
            string sql = "select c.CourseId, c.CourseCode, c.CourseDescription, " +
                "s.SubjectId, s.SubjectName, i.InstructorId, i.InstructorFirstName, " +
                "t.TermId, t.TermName, cp.CampusId, cp.CampusName from COURSES c " +
                "left join SUBJECTS s on c.SubjectId = s.SubjectId " +
                "left join INSTRUCTORS i on c.InstructorId = i.InstructorId " +
                "left join TERMS t on c.TermId = t.TermId " +
                "left join CAMPUSES cp on c.CampusID = cp.CampusId " +
                "where c.SubjectId = @subjectID";
            SqlParameter parameter = new SqlParameter("@subjectID", DbType.Int32);
            parameter.Value = subjectValue;
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            return ConvertToListCourse(dt);
        }

        internal static Course GetCourseByCode(string courdeCode)
        {
            string sql = "select CourseCode, CourseDescription, SubjectId, InstructorId, " +
                "TermId, CampusID from COURSES where CourseCode = @courseCode";
            SqlParameter parameter = new SqlParameter("@courseCode", DbType.String);
            parameter.Value = courdeCode;
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            foreach (DataRow dr in dt.Rows)
            {
                return new Course
                {
                    CourseCode = Convert.ToString(dr[0]),
                    CourseDescription = Convert.ToString(dr[1]),
                    SubjectId = Convert.ToInt32(dr[2]),
                    InstructorId = Convert.ToInt32(dr[3]),
                    TermId = Convert.ToInt32(dr[4]),
                    CampusId = Convert.ToInt32(dr[5]),
                };
            }
            return null;
        }

        internal static void EditCourse(string currentCode, string code, string desc, int subjectID, int instructorID, int termID, int campusID)
        {
            string sql = "update COURSES set CourseCode = @code, CourseDescription = @desc, " +
                "SubjectId = @subjectID, InstructorId = @instructorID, TermId = @termID, " +
                "CampusID = @campusID where CourseCode = @currentCode";
            SqlParameter parameter0 = new SqlParameter("@currentCode", DbType.String);
            parameter0.Value = currentCode;
            SqlParameter parameter1 = new SqlParameter("@code", DbType.String);
            parameter1.Value = code;
            SqlParameter parameter2 = new SqlParameter("@desc", DbType.String);
            parameter2.Value = desc;
            SqlParameter parameter3 = new SqlParameter("@subjectID", DbType.Int32);
            parameter3.Value = subjectID;
            SqlParameter parameter4 = new SqlParameter("@instructorID", DbType.Int32);
            parameter4.Value = instructorID;
            SqlParameter parameter5 = new SqlParameter("@termID", DbType.Int32);
            parameter5.Value = termID;
            SqlParameter parameter6 = new SqlParameter("@campusID", DbType.Int32);
            parameter6.Value = campusID;
            DAO.ExecuteSql(sql, parameter0, parameter1, parameter2, parameter3, parameter4, parameter5, parameter6);
        }

        internal static void AddCourse(string code, string desc, int subjectID, int instructorID, int termID, int campusID)
        {
            string sql = "insert into COURSES values (@code, @desc, @subjectID, @instructorID, @termID, @campusID)";
            SqlParameter parameter1 = new SqlParameter("@code", DbType.String);
            parameter1.Value = code;
            SqlParameter parameter2 = new SqlParameter("@desc", DbType.String);
            parameter2.Value = desc;
            SqlParameter parameter3 = new SqlParameter("@subjectID", DbType.Int32);
            parameter3.Value = subjectID;
            SqlParameter parameter4 = new SqlParameter("@instructorID", DbType.Int32);
            parameter4.Value = instructorID;
            SqlParameter parameter5 = new SqlParameter("@termID", DbType.Int32);
            parameter5.Value = termID;
            SqlParameter parameter6 = new SqlParameter("@campusID", DbType.Int32);
            parameter6.Value = campusID;
            DAO.ExecuteSql(sql, parameter1, parameter2, parameter3, parameter4, parameter5, parameter6);
        }

        internal static List<Course> GetAllCourse()
        {
            string sql = "select c.CourseId, c.CourseCode, c.CourseDescription, " +
                "s.SubjectId, s.SubjectName, i.InstructorId, i.InstructorFirstName, " +
                "t.TermId, t.TermName, cp.CampusId, cp.CampusName from COURSES c " +
                "left join SUBJECTS s on c.SubjectId = s.SubjectId " +
                "left join INSTRUCTORS i on c.InstructorId = i.InstructorId " +
                "left join TERMS t on c.TermId = t.TermId " +
                "left join CAMPUSES cp on c.CampusID = cp.CampusId";
            DataTable dt = DAO.GetDataBySql(sql);
            return ConvertToListCourse(dt);
        }

        internal static List<Subject> GetAllSubject()
        {
            string sql = "select SubjectId, SubjectName from SUBJECTS";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Subject> list = new List<Subject>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Subject
                {
                    SubjectId = Convert.ToInt32(dr[0]),
                    SubjectName = Convert.ToString(dr[1]),
                });
            }
            return list;
        }

        internal static List<Instructor> GetAllInstructor()
        {
            string sql = "select InstructorId, InstructorFirstName from INSTRUCTORS";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Instructor> list = new List<Instructor>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Instructor
                {
                    InstructorId = Convert.ToInt32(dr[0]),
                    InstructorFirstName = Convert.ToString(dr[1]),
                });
            }
            return list;
        }

        internal static List<Term> GetAllTerm()
        {
            string sql = "select TermId, TermName from TERMS";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Term> list = new List<Term>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Term
                {
                    TermId = Convert.ToInt32(dr[0]),
                    TermName = Convert.ToString(dr[1]),
                });
            }
            return list;
        }

        internal static List<Campus> GetAllCampus()
        {
            string sql = "select CampusId, CampusName from CAMPUSES";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Campus> list = new List<Campus>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Campus
                {
                    CampusId = Convert.ToInt32(dr[0]),
                    CampusName = Convert.ToString(dr[1]),
                });
            }
            return list;
        }
    }
}
