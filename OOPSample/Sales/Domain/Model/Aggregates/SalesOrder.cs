namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrder(int id, int customerId)
{
    private int Id { get; } = id;
    private int CustomerId { get; } = customerId;

    private readonly List<SalesOrderItem> _items = [];

    public void AddItem(int productId, int quantity, double unitPrice)
    {
        _items.Add(new SalesOrderItem(Id, productId, quantity,unitPrice));
    }
}