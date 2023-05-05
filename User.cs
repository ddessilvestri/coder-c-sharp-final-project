public class User
{
    private int Id { get; set; }
    private string Name { get; set; }
    private string LastName {get; set;}
    private string UserName { get; set; }
    private string Password { get; set; }    
    private string Email { get; set; }

    public User(int id, string name, string lastName, string userName, string password, string email)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        UserName = userName;
        Password = password;
        Email = email;   
        Console.WriteLine("User created");
    }
};