using System;

namespace Assignment2
{
    public class Student
    {
        public int Id { get; }
        private string GivenName { get; }
        private string SurName { get; }

        private StudentStatus _Status;
        public StudentStatus Status
        {
            get
            {
                if (EndDate > DateTime.Now)
                {
                    if (StartDate < DateTime.Now && DateTime.Now < StartDate.AddYears(1))
                    {
                        _Status = StudentStatus.New;
                    }else
                    {
                        _Status = StudentStatus.Active;
                    }
                }else
                {
                    if (EndDate != GraduationDate)
                    {
                        _Status = StudentStatus.Dropout;
                    }else if (EndDate == GraduationDate)
                    {
                        _Status = StudentStatus.Graduated;
                    }
                }
                return _Status;
            }
            set
            {
                _Status = value;
            }
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public Student(int Id, string GivenName, string SurName)
        {
            this.Id = Id;
            this.GivenName = GivenName;
            this.SurName = SurName;
            StartDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{GivenName} {SurName} ({Id}): {Status} student.";
        }
    }

    public enum StudentStatus
    {
        New,Active,Dropout,Graduated
    }
}