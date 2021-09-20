using System;
using Xunit;
using System.IO;

namespace Assignment2.Tests{
    public class ImmutableStudentTest {
        
        [Fact]
        public void PrintInformation_createStudentRecord_ToString()
        {
        //Given
        DateTime startDate = new DateTime(2021, 9, 1);
        DateTime endDate = new DateTime(2024, 6, 30);
        DateTime graduationDate = new DateTime(2024, 6, 30);

        var student = new ImmutableStudent(1,"Anton", "Folkmann", startDate, endDate, graduationDate);
        
        //When
        var expected = "Anton Folkmann (1): New student.";
        var actually = student.ToString();
        
        //Then
        Assert.Equal(expected,actually);
        }
        
        [Fact]
        public void CompareTwo_ImmutableStudents_with_EqualsMethod_returnTrue()
        {
        //Given
        DateTime startDate = new DateTime(2021, 9, 1);
        DateTime endDate = new DateTime(2024, 6, 30);
        DateTime graduationDate = new DateTime(2024, 6, 30);

        var student1 = new ImmutableStudent(1,"Anton", "Folkmann", startDate, endDate, graduationDate);
        
        //When
        var student2 = student1 with {};
        
        //Then
        Assert.True(student1.Equals(student2));
        }

        [Fact]
        public void CompareTwo_ImmutableStudents_with_EqualsOperator_returnTrue()
        {
        //Given
        DateTime startDate = new DateTime(2021, 9, 1);
        DateTime endDate = new DateTime(2024, 6, 30);
        DateTime graduationDate = new DateTime(2024, 6, 30);

        var student1 = new ImmutableStudent(1,"Anton", "Folkmann", startDate, endDate, graduationDate);
        
        //When
        var student2 = student1 with {};
        
        //Then
        Assert.True(student1 == student2);
        }
    }

}