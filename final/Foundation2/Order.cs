/*
Order
 - Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
 - The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
 - This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
 - A packing label should list the name and product id of each product in the order.
 - A shipping label should list the name and address of the customer
*/

class Order
{

    private Customer _customer;
    private List<Product> _products;
    public Order()
    {
        List<Product> products = new List<Product>();
        this._products = products;
    }

    public void SetCustomer(Customer customer)
    {
        this._customer = customer;
    }

    public void AddProduct(Product product)
    {
        List<Product> products = new List<Product>();
        products = this._products;
        products.Add(product);
        this._products = products;
    }

    public void DisplayTotalPrice()
    {
        double total = 0;
        List<Product> products = new List<Product>();
        products = this._products;
        foreach(Product product in products)
        {
            total = total + ( product.GetPrice() * product.GetQuantity());
        }
        total = AddShippingCost(total);
        Console.WriteLine($"Total: ${total}");
    }

    private double AddShippingCost(double total)
    {
        
        if(this._customer.USAResident())
        {
            return total + 5;
        }
        else
        {
            return total + 35;
        }
    }

    public void DisplayPackingLabel()
    {
        List<Product> products = new List<Product>();
        products = this._products;
        Console.WriteLine("Items: ");
        foreach(Product product in products)
        {
            Console.WriteLine($"\t - ({product.GetId()}) - {product.GetName()}");
        }
    }

    public void DisplayShippingAddress()
    {
        Console.WriteLine($"To: {this._customer.GetName()}");
        Console.WriteLine($"{this._customer.GetShippingAddress()}");
    }
}