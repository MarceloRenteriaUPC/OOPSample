namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrder(int id, int customerId)
{
    public int Id { get; } = id;
    public int customerId { get; } = customerId;
    
    private readonly List<SalesOrderItem> _items = [];
    
    public void AddItem(int productId, int quantity, double unitPrice)
    {
        _items.Add(new SalesOrderItem(Id, productId, quantity, unitPrice));
    }
    
}