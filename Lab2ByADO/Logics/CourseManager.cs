using Lab2ByADO.DataAccess;
using Lab2ByEntityFramwork.Models;
using System.Collections.Generic;

namespace Lab2ByADO.Logics
{
    internal class CourseManager
    {

        public static List<Course> GetAllCourse()
        {
            return CourseDAO.GetAllCourse();
        }

        public static List<Subject> GetAllSubject()
        {
            return CourseDAO.GetAllSubject();
        }

        public static List<Instructor> GetAllInstructor()
        {
            return CourseDAO.GetAllInstructor();
        }

        public static List<Term> GetAllTerm()
        {
            return CourseDAO.GetAllTerm();
        }

        public static List<Campus> GetAllCampus()
        {
            return CourseDAO.GetAllCampus();
        }

        internal static void AddCourse(string code, string desc, int subjectID, int instructorID, int termID, int campusID)
        {
            CourseDAO.AddCourse(code, desc, subjectID, instructorID, termID, campusID);
        }

        internal static void EditCourse(string currentCode, string code, string desc, int subjectID, int instructorID, int termID, int campusID)
        {
            CourseDAO.EditCourse(currentCode, code, desc, subjectID, instructorID, termID, campusID);
        }

        internal static Course GetCourseByCode(string courdeCode)
        {
            return CourseDAO.GetCourseByCode(courdeCode);
        }

        internal static void DeleteCourseByCode(string courseCode)
        {
            CourseDAO.DeleteCourseByCode(courseCode);
        }

        internal static List<Course> GetCourseBySubject(int subjectValue)
        {
            return CourseDAO.GetCourseBySubject(subjectValue);
        }

        internal static List<Course> GetCourseByInstructor(int instructorValue)
        {
            return CourseDAO.GetCourseByInstructor(instructorValue);
        }

        internal static List<Course> GetCourseBySubjectAndInstructor(int subjectValue, int instructorValue)
        {
            return CourseDAO.GetCourseBySubjectAndInstructor(subjectValue, instructorValue);
        }
    }
}
