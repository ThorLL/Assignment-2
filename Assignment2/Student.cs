using System;

namespace Assignment2
{
    public class Student
    {
        public int Id { get; }
        private string GivenName { get; }
        private string SurName { get; }

        private StudentStatus _status;
        public StudentStatus Status
        {
            get
            {
                if (EndDate > DateTime.Now)
                {
                    if (StartDate < DateTime.Now && DateTime.Now < StartDate.AddYears(1))
                    {
                        _status = StudentStatus.New;
                    }else
                    {
                        _status = StudentStatus.Active;
                    }
                }else
                {
                    _status = EndDate != GraduationDate ? StudentStatus.Dropout : StudentStatus.Graduated;
                }
                return _status;
            }
            set => _status = value;            
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