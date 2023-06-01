using WestcoastEducation.BCL;
namespace WestcoastEducation;
class Program
{
    static void Main(string[] args)
    {
        var participantList = new List<Account>();

        var student = new Student()
        {
            FirstName = "Kalle",
            LastName = "Jansson",
            SocialSecurityNumer = "1995-13-02-XXXX",
            StreetAdress = "Kövle 1",
            PostalCode = "584 12",
            City = "Lönnedal",
            Phone = "0703661419",
            Email = "Kalle@gmail.com"
        };
        participantList.Add(student);

        var teacher = new Teacher()
        {
            FirstName = "Hanna",
            LastName = "Aronsson",
            SocialSecurityNumer = "1982-03-10-XXXX",
            StreetAdress = "Rådhusgatan",
            PostalCode = "541 30",
            City = "Skövde",
            Phone = "0726558917",
            Email = "Hanna@gmail.com"
        };
        participantList.Add(teacher);

        var course = new Course()
        {
            CourseName = "Accounting",
            CourseNumer = "256",
            CourseStart = DateTime.Now.AddDays(25),
            CourseEnd = DateTime.Now.AddMonths(13)
        };

        foreach (var participant in participantList)
        {
            Console.WriteLine("\nParticipant: {0} {1}\n" + "{2}\n" + "{3}\n" + "{4}\n" + "{5}\n" + "{6}\n" + "{7}",
            participant.FirstName, participant.LastName, participant.SocialSecurityNumer, participant.StreetAdress, participant.PostalCode, participant.City, participant.Phone, participant.Email);
            participant.Validate();
        }
    }
}
