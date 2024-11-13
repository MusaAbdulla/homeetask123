namespace MicroProject;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public double Price { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"book id:{Id}" +
                          $"\nbook name:{Name}" +
                          $"\nbook author:{AuthorName}" +
                          $"\nbook price:{Price}"
                         );
    }
}