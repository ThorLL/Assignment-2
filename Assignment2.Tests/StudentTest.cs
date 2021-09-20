using System;
using Xunit;
using System.IO;

namespace Assignment2.Tests
{
    public class StudentTest
    {
        [Fact]
        public void Get_Status_New_Student_Today()
        {
            var student = new Student(0,"Thor","Lind")
            {
                EndDate = new DateTime(2024,6,15),
                GraduationDate = new DateTime(2024,6,15)
            };

            var status = student.Status;

            Assert.Equal(StudentStatus.New,status);

        }
        [Fact]
        public void Get_Status_New_Student_()
        {
            var student = new Student(0,"Thor","Lind")
            {
                StartDate = new DateTime(2021,9,1),
                EndDate = new DateTime(2024,6,15),
                GraduationDate = new DateTime(2024,6,15)
            };

            var status = student.Status;

            Assert.Equal(StudentStatus.New,status);

        }
        [Fact]
        public void Get_Status_Active_Student_()
        {
            var student = new Student(0,"Thor","Lind")
            {
                StartDate = new DateTime(2020,9,1),
                EndDate = new DateTime(2024,6,15),
                GraduationDate = new DateTime(2024,6,15)
            };

            var status = student.Status;

            Assert.Equal(StudentStatus.Active,status);
        }
        [Fact]
        public void Get_Status_Dropout_Student_()
        {
            var student = new Student(0,"Thor","Lind")
            {
                StartDate = new DateTime(2021,9,1),
                EndDate = new DateTime(2021,9,14),
                GraduationDate = new DateTime(2024,6,15)
            };

            var status = student.Status;

            Assert.Equal(StudentStatus.Dropout,status);
        }
        [Fact]
        public void Get_Status_Graduated_Student_()
        {
            var student = new Student(0,"Thor","Lind");
            student.StartDate = new DateTime(2018,9,1);
            student.EndDate = new DateTime(2021,6,15);
            student.GraduationDate = new DateTime(2021,6,15);

            var status = student.Status;

            Assert.Equal(StudentStatus.Graduated,status);
        }
        [Fact]
        public void Student_ToString()
        {
            var expected = "Thor Lind (0): Graduated student.";
            
            var student = new Student(0,"Thor","Lind")
            {
                StartDate = new DateTime(2018,9,1),
                EndDate = new DateTime(2021,6,15),
                GraduationDate = new DateTime(2021,6,15)
            };

            var output = student.ToString();

            Assert.Equal(expected,output);
        }
    }
}
