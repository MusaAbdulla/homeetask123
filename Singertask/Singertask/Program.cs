namespace Singertask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singer singer = new Singer("Seyyad", "Elizade", 63);
            Song song = new Song(8,"Beyaz geceler", "Pop", singer);

           
            
            Console.WriteLine($"{singer.Name} {singer.Surname} {singer.Age}");
            Console.WriteLine($" {song.Ratings} {song.SongName} {song.Genre} {song.Singer}");
        }
    }
}
