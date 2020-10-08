using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxofIntegers
{
    public class Box<T>
    {
        public Box(T Value)
        {
            this.Value = Value;
        }
         
        
        
        public T Value { get; set; }

        public override string ToString()
        {
            return $"{this.Value.GetType()}: {this.Value}";
        }
    }
}
