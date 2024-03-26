namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrderItem
{
    public SalesOrderItem(int salesOrderId, int productId, int quantity, double unitPrice)
    {
        if(salesOrderId <= 0)
            throw new ArgumentException("Sales order id must be greater than 0", nameof(salesOrderId));
        if(productId <= 0)
            throw new ArgumentException("Product id must be greater than 0", nameof(productId));
        if(quantity <= 0)
            throw new ArgumentException("Quantity must be greater than 0", nameof(quantity));
        if(unitPrice <= 0)
            throw new ArgumentException("Unit price must be greater than 0", nameof(unitPrice));
        SalesOrderId = salesOrderId;
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
        Id = GenerateOrderItemId();
    }

    public Guid Id { get; }
    public int SalesOrderId { get; }
    public int ProductId { get; }
    public int Quantity { get; }
    public double UnitPrice { get; }

    private static Guid GenerateOrderItemId()
    {
        return Guid.NewGuid();
    }
    public double CalculateItemPrice() => Quantity * UnitPrice;
}