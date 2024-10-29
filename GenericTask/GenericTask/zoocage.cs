using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask
{
    public  class zoocage<T,U>
        where T : Animal ,new ()
        where U : Food ,new ()
    {
        public U food {  get; set; }
        public T animal { get; set; }
    }
}
