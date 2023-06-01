using WestcoastEducation.BCL;
namespace WestcoastEducation.Tests;

//Flytta StartDate validering till Klassen istället
public class CourseTest
{
    [Fact]
    public void CheckIfCourseHasName_WhenNotEmpty()
    {
        // Arrange
        var course = new Course();
        // Act 
        course.CourseName = "Halle";
        // Assert
        Assert.NotEmpty(course.CourseName);
    }

    [Fact]
    public void CheckIfCourseStartDateIsOneMonthForward_IfStartDateIsOneMonthForward()
    {
        // Arrange
        var course = new Course();
        course.CourseStart = DateTime.Today.AddMonths(1);
        // Act 
        
        // Assert
        Assert.Equal(course.CourseStart, DateTime.Today.AddMonths(1));
    }

        [Fact]
    public void CheckIfCourseStartDateNotBackInTime_IfStartDateIsNotBeforeToday()
    {
        // Arrange
        var course = new Course();
        course.CourseStart = new DateTime(2022,05,09);
        //course.CourseStart = DateTime.Today;        
        // Act 
        
        // Assert
        Assert.True(course.Validate());
    }
}