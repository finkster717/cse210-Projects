public class Customer
{
    private string _name;
    private Address _address;
    private string _addressString;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        _addressString = address.GetAddressString();
    }

    public bool InUSA()
    {
        if (_address.IsInUSA() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetCustomerAddressString()
    {
        return $"{_addressString}";
    }
}