public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetOrderTotal()
    {
        double orderTotal = 0;
        foreach (Product product in _products)
        {
            orderTotal += product.GetTotalPrice();
        }
        orderTotal += GetShippingCost();

        return orderTotal;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddressString()}";
    }

    public string GetPackingLabel()
    {
        string packingLabelString = "";
        foreach (Product product in _products)
        {
            packingLabelString += $"{product.GetProductName()} | ID: {product.GetPruductID()}\n";
        }

        return packingLabelString;
    }

    public double GetShippingCost()
    {
        if(_customer.InUSA() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
}