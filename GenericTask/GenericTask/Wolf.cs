using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask
{
     public  class Wolf <T> where T : Animal
    {
       public bool IsPridelLeader {  get; set; }
        public int AttackDamage { get; set; }
        public int Hunt( T animal)
        {
            animal.HP-=AttackDamage;
            return animal.HP;
        }
    }
}
