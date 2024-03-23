namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrder(int id, int customerId)
{
    private int Id { get; } = id;
    private int CustomerId { get; } = customerId;
}