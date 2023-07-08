/*
Product
 - Contains the name, product id, price, and quantity of each product.
 - The price of this product is computed by multiplying the price and the quantity.
*/

class Product
{

    private string _name;
    private int _id;
    private double _price;
    private int _quantity;
    public Product()
    {

    }

    public void SetName(string name)
    {
        this._name = name;
    }

    public void SetId(int id)
    {
        this._id = id;
    }

    public void SetPrice(double price)
    {
        this._price = price;
    }

    public void SetQuantity(int quantity)
    {
        this._quantity = quantity;
    }

    public int GetQuantity()
    {
        return this._quantity;
    }

    public double GetPrice()
    {
        return this._price;
    }

    public string GetName()
    {
        return this._name;
    }

    public int GetId()
    {
        return this._id;
    }
}