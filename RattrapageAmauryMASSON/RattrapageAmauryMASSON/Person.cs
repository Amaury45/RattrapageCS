using System;

namespace RattrapageAmauryMASSON
{
    public class Person
    {

        public int PersonID { get; private set; }

        public char LastName { get; private set; }
        public char FirstName { get; private set; }
        public DateTime HireDate { get; private set; }
        public DateTime EnrollmentDate { get; private set; }




        public Person(int idPerson, char LastName1, char FirstName1, DateTime HireDate1,DateTime EnrollmentDate1)
        {

            PersonID = idPerson;
            LastName = LastName1;
            FirstName = FirstName1;
            HireDate = HireDate1;
            EnrollmentDate = EnrollmentDate1;

        }


    }
}
