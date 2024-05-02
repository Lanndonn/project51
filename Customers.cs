namespace project51;

public class Customers
{
    public List<Customer> customerList {get; set;}

    public Customers()
    {
        customerList = new List<Customer>();
    }
    public Customers Authenticate(string username, string password)
    {
        var c = customerList.Where(o => (o.username == username) && (o.password == password));
    }

    if(c.count() > 0)
    {
        return char.First();
    }
    else 
    {
        return string.Empty;
    }
}
