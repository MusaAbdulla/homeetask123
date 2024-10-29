using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask
{
    public  class Meat :Food
    {
        public enum Type 
        {
            Rotten =2,
            Fresh =3

        
        }
        public Type type {  get; set; }
    }
}
