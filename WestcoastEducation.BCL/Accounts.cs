namespace WestcoastEducation.BCL;

public class Account
{
    public Guid AccountId { get; } = Guid.NewGuid();
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string SocialSecurityNumer { get; set; } = "";
    public string StreetAdress { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string City { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";

    public Account Find(string firstName, string lastName)
    {
        return new Account();
    }
    public List<Account> ListAll()
    {
        return new List<Account>();
    }

    public virtual bool Validate()
    {
        Console.WriteLine("Account Valid");
        var validAccount = true;
        return validAccount;
    }
    public bool Save()
    {
        return true;
    }
}