class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main St",
            "Rio de Janeiro",
            "RJ",
            "Brazil");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Mouse", "P001", 20, 2));
        order1.AddProduct(new Product("Keyboard", "P002", 50, 1));

        Address address2 = new Address(
            "Rua das Flores",
            "São Paulo",
            "SP",
            "Brazil");

        Customer customer2 = new Customer(
            "Maria Silva",
            address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Monitor", "P003", 200, 1));
        order2.AddProduct(new Product("Webcam", "P004", 80, 1));

        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

        Console.WriteLine();

        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}