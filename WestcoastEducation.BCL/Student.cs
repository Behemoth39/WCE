namespace WestcoastEducation.BCL;
public class Student : Account
{
    public List<ClassroomCourse> MyClassroomCourse { get; set; } = new List<ClassroomCourse>();
    public List<DistanceCourse> MyDistanceCourse { get; set; } = new List<DistanceCourse>();
}