using System;

namespace RattrapageAmauryMASSON
{
    public class Course
    {
        public int CourseId { get; private set; }
        public char Title { get; private set; }
        public int Credits { get; private set; }
        public int DepartementID { get; private set; }
       



        public Course(int IdCourse, char Title1, int Credits1, int IdDepartement)
        {
            CourseId = IdCourse;
            Title = Title1;
            Credits = Credits1;
            DepartementID = IdDepartement;
        }


    }
}
