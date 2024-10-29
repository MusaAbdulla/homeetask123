namespace GenericTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Wolf<Elephant> wolf = new Wolf<Elephant> ();
            wolf.IsPridelLeader = true;
            wolf.AttackDamage = 200;
            Elephant elephant = new Elephant();
            elephant.breed = "Teymurun Fili";
            elephant.IsTrained = true;
            elephant.AvgLifeTime = 80;
            elephant.Weight = 3000;
            elephant.HP = 500;
            Console.WriteLine($"Filin Qalan saglamligi:{ wolf.Hunt(elephant)}");
            Console.WriteLine($"Filin cinsi:{elephant.breed}\nFil ehillesdirilib:{elephant.IsTrained}\nFilin ortalama omuru:{elephant.AvgLifeTime}\nFilin Cekisi:{elephant.Weight}\nFilin saglamligi:{elephant.HP}");
                
        }
    }
}
