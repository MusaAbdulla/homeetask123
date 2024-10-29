namespace classtask
{
    class Program
    {
        public static void Main(string[] args)
        {
            Product[] prdcts = { new Product("su", "sirab", 50), new Product("cipsi", "lays", 40), new Product("siqaret", "winston", 55) };

            double minPrice = 20;
            double maxPrice = 53;
            for (int i = 0; i < prdcts.Length; i++)
            {
                if (prdcts[i].Price < maxPrice && prdcts[i].Price > minPrice)
                {
                    Console.WriteLine($"Name: {prdcts[i].Name}, BrandName:{prdcts[i].BrandName}, Price:{prdcts[i].Price}");
                }
            }
        }
    }
}
