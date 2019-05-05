using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class SDelegate
    {
        public delegate void CALLBACK0();
        public delegate void CALLBACK1(object obj1);
        public delegate void CALLBACK2(object obj1, object obj2);
        public delegate void CALLBACK3(object obj1, object obj2, object obj3);
    }
}
