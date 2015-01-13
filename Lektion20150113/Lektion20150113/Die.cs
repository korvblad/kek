using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion20150113
{
     public class Die
    {
         private int _faceValue;

             public int Throw()
             {
                 var random = new Random();
                 _faceValue = random.Next(1, 7);
                 return _faceValue;
             }
    }
}
