public class SoldProduct
{
    private int Id { get; set; }
    private int ProductId { get; set; }
    private int Stock { get; set; }
    private int SaleId { get; set; }
  

    public SoldProduct(int id, int productId, int stock, int saleId)
    {
        Id = id;
        ProductId = productId;
        Stock = stock;
        SaleId = saleId;   
        Console.WriteLine("SoldProduct created");
    }
}