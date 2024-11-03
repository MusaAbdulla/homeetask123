using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FileHelper
    {
        public string Path { get;  }
        public FileHelper(string path)
        {
            Path = path;
            
        }
        string json;
        List<string> Files = [];
        public void Add(string name)
        { 
          Files.Add(name);
            json= JsonConvert.SerializeObject(Files);
            using StreamWriter sw = new StreamWriter(Path,false );
            sw.Write(json);
        }
        public bool Exixst(string name)
        { 
         return Files.Contains(name);
        }
        public void Update (int index , string name)
        {
            Files[index] = name;
            json = JsonConvert.SerializeObject(Files);
            using StreamWriter sw = new StreamWriter(Path, false);
            sw.Write(json);
        }
        public void Delete(int index )
        {
        Files.RemoveAt(index);
            json = JsonConvert.SerializeObject(Files);
            using StreamWriter sw = new StreamWriter(Path, false);
            sw.Write(json);
        }
    }
}
