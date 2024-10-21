namespace classtaskintarface
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Word word = new Word();
            word.Write("Menim adim Musadir");
            word.Save();
            word.SaveAndClose("Menimhaqqimdamelumat");

            Console.WriteLine("--------------------------------------------------");

            Notepad notepad = new Notepad();
            notepad.Write("Dersde yazdiqlarim ");
            notepad.Save();
            notepad.SaveAndClose("notlar");

            Console.WriteLine("--------------------------------------------------");

            Notepad wordpad = new Notepad();
            notepad.Write("Dictionary");
            notepad.Save();
            notepad.SaveAndClose("lugetim");

            Console.WriteLine("--------------------------------------------------");




        }
    }
}
