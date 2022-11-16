
using Microsoft.EntityFrameworkCore;

public class EcommerceDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-ecommerce;Integrated Security=True;Encrypt=false;");
    }
}

public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public float Amount { get; set; }
    public string Status { get; set; }

    // FK
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

    public List<Product> Products { get; set; }
    public List<Payment> Payments { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }

    public List<Order> Orders { get; set; }

}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string level { get; set; }

    public List<Order> Orders { get; set; }
}

public class Payment
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string level { get; set; }

    public List<Order> Orders { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string description { get; set; }
    public float price { get; set; }

    public List<Order> Orders { get; set; }
}
