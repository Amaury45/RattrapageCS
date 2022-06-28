using System;

namespace RattrapageAmauryMASSON
{
    public class StudentGrade
    {

        public int EnrollmentID { get; private set; }

        public int CourseID { get; private set; }
        public int StudentID { get; private set; }
        public float Grade { get; private set; }
        




        public StudentGrade(int IdEnrollment, int IdCourse , int IdStudent, float Grade1)
        {
            EnrollmentID = IdEnrollment;
            CourseID = IdCourse;
            StudentID = IdStudent;
            Grade = Grade1;


        

        }

       

    }

    public double ObtenirNoteMoyenne(StudentGrade otherGrade )
    {
        return Math
    }
}
