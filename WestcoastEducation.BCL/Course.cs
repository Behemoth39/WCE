namespace WestcoastEducation.BCL;
public class Course
{
    public Guid CourseId { get; set; } = Guid.NewGuid();
    public string CourseName { get; set; } = "";
    public string CourseNumer { get; set; } = "";
    public DateTime CourseStart { get; set; }
    public DateTime CourseEnd { get; set; }
    public Teacher? Teacher { get; set; }


    public bool Save()
    {
        return true;
    }
    public bool Validate()
    {
        var Validdate = true;
        if(CourseStart < DateTime.Today) Validdate= false;        
        return Validdate;               
    }

    public Course Find(string courseid)
    {
        return new Course();
    }
    public List<Course> ListAll()
    {
        return new List<Course>();
    }
}