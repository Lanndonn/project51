namespace project51;

public class Customer
{
    private static int autoIncrement;

    public int Id{get;}
    public string username{get;set;}
    public string password{get;set;}
    public string firstName{get;set;}
    public string lastName{get;set;}

    public Customer()
    {
        autoIncrement++;
        Id = autoIncrement;
        
    }
}
