namespace project51;

public class Customer2
{
    public List<Customer> customerlist { get; set; }

    public Customers()
    {
        customerlist = new List<Customer>();

    }

    public Customer Authenticate(string username, string password)
    {
        var c = customerlist.Where((o.Username == username) && (o.Password == password));

        if(c.Count > 0)
        {
            return c.First();
        }
        else
        {
            return null;
        }
    }
}
