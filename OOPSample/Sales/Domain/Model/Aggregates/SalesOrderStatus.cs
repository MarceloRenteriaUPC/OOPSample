namespace OOPSample.Sales.Domain.Model.Aggregates;

public enum SalesOrderStatus
{
    Cancelled,
    PendingPayment,
    ReadyForShipment,
    Shipped,
    Completed,
}