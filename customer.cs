using System.Dynamic;

namespace project51;

public class customer
{
    private static int autoIncrement;

    public int Id {get;}
    public string Username {get;set;}
    public string Password {get;set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}

    public Customer()
    {
        autoIncrement++;
        Id = autoIncrement;
    }
}
