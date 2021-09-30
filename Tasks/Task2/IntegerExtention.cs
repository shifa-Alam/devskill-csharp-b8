using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class IntExtensions
    {
        public static bool IsOdd( this int value)
        {
            return (value%2==0)?false:true;
        }
    }
}
