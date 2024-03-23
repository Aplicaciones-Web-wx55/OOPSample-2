namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrderItem(int salesOderId, int productId, int quantity, double unitPrice)
{
    public Guid Id { get; } = GenerateOrderItemId();
    public int SalesOderId { get; } = salesOderId;
    public int ProductId { get; } = productId;
    public int Quantity { get; } = quantity;
    public double UnitPrice { get; } = unitPrice;

    private static Guid GenerateOrderItemId()
    {
        return Guid.NewGuid();
    }
}