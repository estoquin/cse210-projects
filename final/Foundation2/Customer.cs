/*
Customer
 - The customer contains a name and an address.
 - The name is a string, but the Address is a class.
 - The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
*/


class Customer
{

    private string _name;
    private Address _address;
    public Customer()
    {

    }

    public void SetName(string name)
    {
        this._name = name;
    }

    public string GetName()
    {
        return this._name;
    }

    public void SetAddres(Address address)
    {
        this._address = address;
    }
    public Address GetAddres()
    {
        return this._address;
    }

    public string GetShippingAddress()
    {
        return this._address.GetFullAddress();
    }

    public bool USAResident()
    {
        if(this._address.GetCountry() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}