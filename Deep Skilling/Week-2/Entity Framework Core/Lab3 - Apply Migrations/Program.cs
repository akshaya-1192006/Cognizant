using RetailInventory.Data;
Console.WriteLine("Migration Demo");
using var context = new AppDbContext();
context.Database.EnsureCreated();
Console.WriteLine("Database Created");
