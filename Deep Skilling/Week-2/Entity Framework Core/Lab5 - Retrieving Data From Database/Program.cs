using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

// Display all products
var products = context.Products.ToList();

Console.WriteLine("Product List");
foreach (var p in products)
{
    Console.WriteLine($"{p.Id} {p.Name} ₹{p.Price}");
}

// Find product by Id
var product = context.Products.Find(1);

if (product != null)
{
    Console.WriteLine("\nFound Product");
    Console.WriteLine(product.Name);
}

// First product whose price is greater than 50000
var expensive = context.Products
                       .FirstOrDefault(p => p.Price > 50000);

if (expensive != null)
{
    Console.WriteLine("\nExpensive Product");
    Console.WriteLine(expensive.Name);
}
