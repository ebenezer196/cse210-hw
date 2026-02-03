using System;
using System.Collections.Generic;
using System.Text;

// Address class - Encapsulates address information
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Method to check if address is in USA
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES";
    }

    // Method to return formatted address string
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }

    // Getters
    public string GetStreetAddress() { return _streetAddress; }
    public string GetCity() { return _city; }
    public string GetStateProvince() { return _stateProvince; }
    public string GetCountry() { return _country; }
}

// Product class - Encapsulates product information
public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    // Method to calculate total cost of this product
    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    // Getters
    public string GetName() { return _name; }
    public string GetProductId() { return _productId; }
    public double GetPricePerUnit() { return _pricePerUnit; }
    public int GetQuantity() { return _quantity; }

    // Method to get product label information
    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productId})";
    }
}

// Customer class - Encapsulates customer information
public class Customer
{
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if customer lives in USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Getters
    public string GetName() { return _name; }
    public Address GetAddress() { return _address; }
}

// Order class - Encapsulates order information
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add product to order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate total cost of order
    public double CalculateTotalCost()
    {
        double productTotal = 0;
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        // Add shipping cost
        double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
        
        return productTotal + shippingCost;
    }

    // Method to generate packing label
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("PACKING LABEL:");
        label.AppendLine("====================");
        
        foreach (Product product in _products)
        {
            label.AppendLine(product.GetPackingLabel());
        }
        
        return label.ToString();
    }

    // Method to generate shipping label
    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("SHIPPING LABEL:");
        label.AppendLine("====================");
        label.AppendLine(_customer.GetName());
        label.AppendLine(_customer.GetAddress().GetFullAddress());
        
        return label.ToString();
    }

    // Getters
    public List<Product> GetProducts() { return _products; }
    public Customer GetCustomer() { return _customer; }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ONLINE ORDERING SYSTEM");
        Console.WriteLine("======================\n");

        // Create first order - USA customer
        Address address1 = new Address(
            "123 Main Street",
            "Springfield",
            "IL",
            "USA"
        );
        
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        // Add products to first order
        Product product1 = new Product("Laptop", "TECH-001", 899.99, 1);
        Product product2 = new Product("Wireless Mouse", "TECH-002", 25.50, 2);
        Product product3 = new Product("USB-C Cable", "TECH-003", 12.99, 3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Display Order 1 information
        Console.WriteLine("ORDER #1");
        Console.WriteLine("--------\n");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}\n");
        Console.WriteLine("======================\n");

        // Create second order - International customer
        Address address2 = new Address(
            "45 Rue de la Paix",
            "Paris",
            "Île-de-France",
            "France"
        );
        
        Customer customer2 = new Customer("Marie Dubois", address2);
        Order order2 = new Order(customer2);

        // Add products to second order
        Product product4 = new Product("Smartphone", "TECH-004", 699.00, 1);
        Product product5 = new Product("Phone Case", "ACC-001", 19.99, 1);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display Order 2 information
        Console.WriteLine("ORDER #2");
        Console.WriteLine("--------\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}\n");
        Console.WriteLine("======================\n");

        // Create third order - Another USA customer
        Address address3 = new Address(
            "789 Oak Avenue",
            "Seattle",
            "WA",
            "USA"
        );
        
        Customer customer3 = new Customer("Emily Johnson", address3);
        Order order3 = new Order(customer3);

        // Add products to third order
        Product product6 = new Product("Tablet", "TECH-005", 449.99, 1);
        Product product7 = new Product("Stylus Pen", "ACC-002", 89.99, 1);
        Product product8 = new Product("Screen Protector", "ACC-003", 15.99, 2);

        order3.AddProduct(product6);
        order3.AddProduct(product7);
        order3.AddProduct(product8);

        // Display Order 3 information
        Console.WriteLine("ORDER #3");
        Console.WriteLine("--------\n");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order3.CalculateTotalCost():F2}\n");
        Console.WriteLine("======================\n");

        Console.WriteLine("Summary:");
        Console.WriteLine($"Order #1 (USA): ${order1.CalculateTotalCost():F2} (includes $5 shipping)");
        Console.WriteLine($"Order #2 (International): ${order2.CalculateTotalCost():F2} (includes $35 shipping)");
        Console.WriteLine($"Order #3 (USA): ${order3.CalculateTotalCost():F2} (includes $5 shipping)");
    }
}