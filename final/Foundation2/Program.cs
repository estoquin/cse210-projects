using System;

class Program
{
    static void Main(string[] args)
    {
        Address a = new Address();
        Customer c = new Customer();
        Product p1 = new Product();
        Product p2 = new Product();
        Product p3 = new Product();
        Order o1 = new Order();
        
        a.SetStreet("Av. Belgrano 2138");
        a.SetCity("San Miguel de Tucuman");
        a.SetState("Tucuman");
        a.SetCountry("Argentina");
        
        c.SetAddres(a);
        c.SetName("Juan Carlos");
        
        p1.SetId(1);
        p1.SetName("Pillows");
        p1.SetPrice(3.45);
        p1.SetQuantity(2);
        
        p2.SetId(2);
        p2.SetName("Bed");
        p2.SetPrice(45.3);
        p2.SetQuantity(1);
        
        p3.SetId(3);
        p3.SetName("Sheets");
        p3.SetPrice(3.4);
        p3.SetQuantity(2);

        o1.SetCustomer(c);
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);

        Address a1 = new Address();
        Customer c1 = new Customer();
        Product p4 = new Product();
        Product p5 = new Product();
        Product p6 = new Product();
        Order o2 = new Order();
        
        a1.SetStreet("200 Park Ave");
        a1.SetCity("New York");
        a1.SetState("NY");
        a1.SetCountry("USA");
        
        c1.SetAddres(a1);
        c1.SetName("William Richards");
        
        p4.SetId(4);
        p4.SetName("Chair");
        p4.SetPrice(332.45);
        p4.SetQuantity(3);
        
        p5.SetId(5);
        p5.SetName("Table");
        p5.SetPrice(133.4);
        p5.SetQuantity(1);
        
        p6.SetId(6);
        p6.SetName("Knife");
        p6.SetPrice(303.5);
        p6.SetQuantity(2);
        
        o2.SetCustomer(c1);
        o2.AddProduct(p4);
        o2.AddProduct(p5);
        o2.AddProduct(p6);

        Console.WriteLine("\n----------------------------------------------*/");
        o1.DisplayShippingAddress();
        o1.DisplayPackingLabel();
        o1.DisplayTotalPrice();

        Console.WriteLine("\n----------------------------------------------*/");
        o2.DisplayShippingAddress();
        o2.DisplayPackingLabel();
        o2.DisplayTotalPrice();
    }
}