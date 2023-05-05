public class Product
{
    private int Id { get; set; }
    private string Description { get; set; }
    private double Cost { get; set;}
    private double SalePrice { get; set; }
    private int Stock { get; set; }
    private int UserId { get; set; }

    public Product(int id, string name, double cost, string description, double salePrice, int stock, int userId)
    {
        Id = id;
        Description = description;
        Cost = cost;
        SalePrice = salePrice;
        Stock = stock;
        UserId = userId;
        Console.WriteLine("Product created");
    }
}