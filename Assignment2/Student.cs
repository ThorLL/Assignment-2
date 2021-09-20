using System;

namespace Assignment2
{
    public class Student
    {
        public int Id { get; }
        private string GivenName { get; }
        private string SurName { get; }

        public StudentStatus Status {
            get
            {
                if (EndDate <= DateTime.Now)
                    return EndDate != GraduationDate ? StudentStatus.Dropout : StudentStatus.Graduated;
                if (StartDate < DateTime.Now && DateTime.Now < StartDate.AddYears(1))
                {
                    return StudentStatus.New;
                }
                return StudentStatus.Active;
            } 
            init{}
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public Student(int id, string givenName, string surName)
        {
            Id = id;
            GivenName = givenName;
            SurName = surName;
            StartDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{GivenName} {SurName} ({Id}): {Status} student.";
        }
    }

    
}