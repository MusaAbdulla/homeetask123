namespace Singertask
{
    public class Singer
    {
        public Singer(string name, string surname, int age)
        {
            Name = name;      // Use property setter for validation
            Surname = surname; // Use property setter for validation
            Age = age;        // Use property setter for validation
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 100)
                    _name = value;
                else
                    Console.WriteLine ("Ad sehvdir zehmet olmasa duzeldin");
            }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length <= 10)
                    _surname = value;
                else
                    Console.WriteLine ("Soyad sehvdir zehmet olmasa duzeldin");
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 170)
                    _age = value;
                else
                    Console.WriteLine ("Yas sehvdir, 170 den boyuk ola bilmez");
            }
        }
    }
}
