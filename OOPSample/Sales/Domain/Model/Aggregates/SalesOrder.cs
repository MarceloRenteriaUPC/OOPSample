using OOPSample.Shared.Domain.Model.ValueObjects;

namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrder(int id, int customerId)
{
    public int Id { get; } = id;
    public int CustomerId { get; } = customerId;
    
    private readonly List<SalesOrderItem> _items = [];
    
    public Address ShippingAddress { get; private set; }
    public void AddItem(int productId, int quantity, double unitPrice)
    {
        _items.Add(new SalesOrderItem(Id, productId, quantity, unitPrice));
    }
    
    public void Dispatch(string street, string city, string state, string zipCode)
    {
        ShippingAddress = new Address(street, city, state, zipCode);
    }
    
}