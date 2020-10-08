using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeple<TFirst,TSecond,TThird>
    {

        public Threeple(TFirst firstitem, TSecond seconditem, TThird thirditem)
        {
            this.FirstItem = firstitem;
            this.SecondItem = seconditem;
            this.ThirdItem = thirditem;
        }

        public TFirst FirstItem { get; set; }

        public TSecond SecondItem { get; set; }

        public TThird ThirdItem { get; set; }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem} -> {this.ThirdItem}";
        }
    }
}
