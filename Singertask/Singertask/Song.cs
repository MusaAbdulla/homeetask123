namespace Singertask
{
    public class Song
    {
        private int _ratings;
        private string _songname;
        private string _genre;
        private Singer _singer;

        public Song(int ratings, string songname, string genre, Singer singer)
        {
            Ratings = ratings; 
            SongName = songname; 
            Genre = genre; 
            Singer = singer; 
        }

        public int Ratings
        {
            get { return _ratings; }
            set
            {
                if (value >= 0 && value <= 10) 
                {
                    _ratings = value;
                    Console.WriteLine($"Rating: {_ratings}");
                }
                else
                {
                    Console.WriteLine("Rating ancaq 0-10 arasinda ola biler .");
                }
            }
        }

        public string SongName
        {
            get { return _songname; }
            set
            {
                if (value.Length <= 100) 
                {
                    _songname = value;
                }
                else
                {
                    Console.WriteLine("Mahni Adi sehvdir ; Ancaq  100 simvol ve ya az ola biler.");
                }
            }
        }

        public string Genre
        {
            get { return _genre; }
            set
            {
                if (value == "Pop" || value == "Rock" || value == "Jazz" || value == "Techno")
                {
                    _genre = value;
                }
                else
                {
                    Console.WriteLine("Janr Sehvdir; Ancaq bu janrlar ola biler- Pop, Rock, Jazz, or Techno.");
                }
            }
        }

        public Singer Singer
        {
            get { return _singer; }
            set { _singer = value; }
        }

        public void AddRating(int rating)
        {
            Ratings = rating; 
        }

        public double GetAverageRating()
        {
           
            return _ratings; 
        }
    }
}
