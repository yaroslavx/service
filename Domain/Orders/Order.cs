using Domain.Products;

namespace Domain.Orders;

public class Order
{
    private readonly HashSet<LineItem> _lineItems = new();
    
    public Guid Id { get; private set; }
    
    public Guid CustomerId { get; private set; }
}

public class LineItem
{
    public Guid Id { get; private set; }
    
    public Guid OrderId { get; private set; }
    
    public Guid ProductId { get; private set; }
    
    public Money Price { get; private set; }
}

