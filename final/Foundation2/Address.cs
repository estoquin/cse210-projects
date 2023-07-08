/*
Address
 - The address contains a string for the street address, the city, state/province, and country.
 - The address should have a method that can return whether it is in the USA or not.
 - The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
*/

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address()
    {

    }

    public void SetStreet(string street)
    {
        this._street = street;
    }

    public void SetCity(string city)
    {
        this._city = city;
    }

    public void SetState(string state)
    {
        this._state = state;
    }

    public void SetCountry(string country)
    {
        this._country = country;
    }

    public string GetCountry()
    {
        return this._country;
    }

    public string GetFullAddress()
    {
        return $"{this._street}, {this._city}, {this._state}, {this._country}";
    }
}