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
