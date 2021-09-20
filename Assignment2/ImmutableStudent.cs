using System;

namespace Assignment2
{
    public record ImmutableStudent
    {
        public int Id { get; init;}
        public string GivenName { get; init;}
        public string SurName { get; init;}
        public DateTime StartDate { get; init;}
        public DateTime EndDate { get; init;}
        public DateTime GraduationDate { get; init;}
        public StudentStatus Status {
            get
            {if (EndDate > DateTime.Now)
                {
                    if (StartDate < DateTime.Now && DateTime.Now < StartDate.AddYears(1))
                    {
                        return StudentStatus.New;
                    }else
                    {
                        return StudentStatus.Active;
                    }
                }else
                {
                    if (EndDate != GraduationDate)
                    {
                        return StudentStatus.Dropout;
                    }else
                    {
                        return StudentStatus.Graduated;
                    }
                }
            } 
            init{}
            }
        public ImmutableStudent(int id, string givenName, string surName, DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
            Id = id;
            GivenName = givenName;
            SurName = surName;
            StartDate = startDate;
            EndDate = endDate;
            GraduationDate = graduationDate;
        }

        public override string ToString()
        {
            return $"{GivenName} {SurName} ({Id}): {Status} student.";
        }
    }
}