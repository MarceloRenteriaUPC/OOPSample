namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrderItem(int salesOrderId, int productId, int quantity, double unitPrice)
{
    public Guid Id { get; } = GenerateOrderItemId();
    public int SalesOrderId { get; } = salesOrderId;
    public int ProductId { get; } = productId;
    public int Quantity { get; } = quantity;
    public double UnitPrice { get; } = unitPrice;

    private static Guid GenerateOrderItemId()
    {
        return Guid.NewGuid();
    }

    public double CalculateItemPrice() => Quantity * UnitPrice;
}