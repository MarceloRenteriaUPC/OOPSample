namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrder(int id, int customerId)
{
    public int Id { get; } = id;
    public int customerId { get; } = customerId;
    
}