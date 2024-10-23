namespace indexertask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt arryy = new ListInt();
            arryy[0] = 1;
            arryy[1] = 2;
            arryy[2] = 3;
            arryy[3] = 4;


            arryy.Add(5, 7, 9);

            arryy.Contains(15354);

            arryy.Pop();
            arryy.Sum();

            Console.WriteLine(arryy.ToString());

            //arryy.LastIndexOf(2);
            for (int i = 0; i < arryy.GetHashCode(); i++)
            {
                Console.WriteLine(arryy[i]);
            }
        }
    }
}
