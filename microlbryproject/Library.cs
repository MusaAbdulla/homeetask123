namespace MicroProject;

public class Library
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();
    public void AddBook(Book item)
    {
        Books.Add(item);
    }
    public Book GetBookById(int id)
    {
        return Books.FirstOrDefault(x => x.Id == id);
    }
    public void RemoveBook(int id)
    {

        for (int i = 0; i < Books.Count; i++)
        {
            if (Books[i].Id == id)
            {
                Books.RemoveAt(i);
                Console.WriteLine($"{id} id-li kitab silindi.");
                break;
            }
        }

    }
}