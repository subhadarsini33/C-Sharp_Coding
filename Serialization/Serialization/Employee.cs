using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
   public  class Employee
    {
        public int id;
        public string name;

        public Employee(int Id, String Name)
        {
            this.id = Id;
            this.name = Name;


        }
    }
}
