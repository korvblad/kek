using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Personer
{
    class Person
    {
         private string _name;
         private int shoeSize;
         

        public string Name
         {
             get { return _name; }
             set
             {
                 if(String.IsNullOrWhiteSpace(value))
                 {
                     throw new ArgumentException();
                 }
                 _name = value;
             }
         }
    }
}
