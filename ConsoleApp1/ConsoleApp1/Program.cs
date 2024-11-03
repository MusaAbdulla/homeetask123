using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         FileHelper fileHelper = new FileHelper(@"C:\Users\Sheki-Komp\Desktop\classhometask\ConsoleApp1\ConsoleApp1\Files\names.json");
            fileHelper.Add("Musa");
            fileHelper.Add("Sema");
            fileHelper.Add("Huseynberg");
            fileHelper.Add("Revan");
            Console.WriteLine(fileHelper.Exixst("Musa"));
            fileHelper.Update(2, "Kamran");
            fileHelper.Delete(2);


        }
    }
}
