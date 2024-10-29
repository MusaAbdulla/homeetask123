using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask
{
  public abstract class Animal
    {
        public int AvgLifeTime  { get; set; }
        public enum Gender 
        {
            Male=5,
            FeMale=6
        }
        public Gender gender { get; set; }
        public string breed {  get; set; }
        public int HP { get; set; }

    }
}
