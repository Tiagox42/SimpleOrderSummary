using SimpleOrderSummary.Entities;
using SimpleOrderSummary.Entities.Enums;

Console.WriteLine("Enter cliente data:");
Console.Write("Name:");
string name = Console.ReadLine();

Console.WriteLine("Email:");
string email = Console.ReadLine();

Console.WriteLine("Birth date (DD/MM/YYYY):");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, birthDate);

Console.WriteLine("Enter order data:");
Console.WriteLine("Status:");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());


Console.WriteLine("How many items to this order?");
int nOrder = int.Parse(Console.ReadLine());

DateTime moment = DateTime.Now;
Order order = new Order(moment, status, client);

for (int i = 1; i <= nOrder; i++)
{
    
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name:");
    string productName = Console.ReadLine();
    Console.Write("Product price:");
    double productPrice = double.Parse(Console.ReadLine());
    Console.Write("Quantity:");
    int productQuatity = int.Parse(Console.ReadLine());

    Product product = new Product(productName, productPrice);
    OrderItem item = new OrderItem(productQuatity, productPrice, product);
    order.AddItem(item);
}

Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);
