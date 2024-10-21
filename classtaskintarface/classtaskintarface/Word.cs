using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtaskintarface
{
    internal class Word
    {
        
    private string _currenttext;
        public string CurrentText
        {
            get { return _currenttext; }
        }
        public void Open()
        {
            _currenttext = string.Empty;
        }

        public void Write(string currenttext)
        {
            _currenttext = currenttext;
        }
        public void Save()
        {
            Console.WriteLine(_currenttext);
        }
        public void SaveAndClose(string filename)
        {
            Console.WriteLine($"C:/Users/Word/{filename}.docx");
        }


    }
}
