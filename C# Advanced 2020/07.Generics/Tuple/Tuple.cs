using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<TFirst,TSecond>
    {
        public Tuple(TFirst firstitem,TSecond seconditem)
        {
            this.FirstItem = firstitem;
            this.SecondItem = seconditem;
        }

        
        public TFirst FirstItem { get; set; }

        public TSecond SecondItem { get; set; }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem}";
        }
    }
}
