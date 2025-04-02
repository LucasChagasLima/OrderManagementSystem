# Order Management System / Sistema de Gerenciamento de Pedidos

![image](https://github.com/user-attachments/assets/f712e06d-7dd6-4457-bbbe-7ffa6fc3f6c1)

# UML

![image](https://github.com/user-attachments/assets/1a84269b-a71e-4e1b-8af2-726009db5ecb)


### Description
A C# console application for managing customer orders, including client registration, order status tracking, and total price calculation. Built using object-oriented principles and composition (e.g., `Order` composed of multiple `OrderItem` objects).

### Features
- Register clients with name, email, and birth date.
- Create orders with status tracking (e.g., "Processing").
- Add multiple items to orders (product name, price, quantity).
- Calculate subtotals per item and total order price.
- Display detailed order summary with timestamps.

### Usage
1. **Prerequisites**: .NET 6.0 SDK or later.

# Input Example

Enter client data:
Name: Lucas L
Email: Lucasl@gmail.com
Birth date (dd/MM/yyyy): 04/04/1994

Enter Order data:
Status: Processing
How many items to this order: 2

Enter #1 item data:
Product name: TV
Product price: 1000.00
Quantity: 1

Enter #2 item data:
Product name: Mouse
Product price: 40.00
Quantity: 2

ORDER SUMMARY:
Order moment: 02/04/2025 15:19:22
Order status: Processing
Client: Lucas L (04/04/1994) - Lucasl@gmail.com
Order items:
TV, $1000.00, Quantity: 1, Subtotal: $1000.00
Mouse, $40.00, Quantity: 2, Subtotal: $80.00
Total price: $1080.00

## Classes
Client: Stores client data.

Order: Manages order status, items, and total calculation.

OrderItem: Represents an item in an order (product + quantity).

Product: Defines product details.

OrderStatus: Enum 
