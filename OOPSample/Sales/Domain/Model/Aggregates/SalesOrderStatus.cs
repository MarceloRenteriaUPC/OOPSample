namespace OOPSample.Sales.Domain.Model.Aggregates;

public enum SalesOrderStatus
{
    PendingPayment,
    ReadyForShipment,
    Shipped,
    Completed,
}