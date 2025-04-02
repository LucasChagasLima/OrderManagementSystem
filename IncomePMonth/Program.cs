using IncomePMonth.Entities;
using IncomePMonth.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter Cliente Data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birth = DateTime.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Enter Order Data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(name, email, birth);

Console.Write("How many items to this order: ");
int num = int.Parse(Console.ReadLine());

Order order = new Order(DateTime.Now, status, client);

for (int i = 1; i <= num; i++)
{
    Console.WriteLine("Enter #" + i + " item data: ");
    Console.Write("Product name: ");
    string nameItem = Console.ReadLine();
    Console.Write("ProductPrice: ");
    double priceItem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quatit = int.Parse(Console.ReadLine());

    Product product = new Product(nameItem, priceItem);
    OrderItem orderItem = new OrderItem(quatit, priceItem, product);
    order.AddItem(orderItem);
}


Console.WriteLine();
Console.WriteLine("ORDER SUMMARY: ");
Console.WriteLine(order);



