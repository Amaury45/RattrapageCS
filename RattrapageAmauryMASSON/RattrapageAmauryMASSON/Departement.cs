using System;

namespace RattrapageAmauryMASSON
{
    public class Departement
    {
    
        public int DepartementID { get; private set; }

        public char Name { get; private set;}
        public float Budget { get; private set; }
        public DateTime StartDate { get; private set; }
        public int Administrator { get; private set; }
    



        public Departement(int idDepartement, char Name1, float Budget1, DateTime StartDate1, int Administrator1 )
        {

            DepartementID = idDepartement;
            Name = Name1;
            Budget = Budget1;
            StartDate = StartDate1;
            Administrator = Administrator1;

        }


    }
}
