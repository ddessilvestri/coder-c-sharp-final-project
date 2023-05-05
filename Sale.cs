public class Sale
{
    private int Id { get; set; }
    private string Comments { get; set; }
    private int UserId { get; set; }    

    public Sale(int id, string comments, int userId)
    {
        Id = id;
        Comments = comments;
        UserId = userId;
        Console.WriteLine("Sale created");
    }
}