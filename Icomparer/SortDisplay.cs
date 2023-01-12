using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icomparerejemplo
{
    public class SortDisplay : IComparer<Display>
    { 
        public int Compare(Display x, Display y)
        {
            Display firstDisplay = x as Display;
            Display secondDisplay = y as Display;
            return firstDisplay.PPI.CompareTo(secondDisplay.PPI);
        }
    }
}
