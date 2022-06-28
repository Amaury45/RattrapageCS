using System;

namespace RattrapageAmauryMASSON
{
    public class CourseInstructor
    {
        public int CourseId { get; private set; }
        public int PersonId { get; private set; }



        public CourseInstructor(int IdCourse, int IdPerson)
        {
            CourseId = IdCourse;
            PersonId = IdPerson;
        }


    }
}
