using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab_5
{
    public class MyFrac : IMyNumber<MyFrac>, IComparable
    {
        BigInteger num, denom;
        public double Value
        {
            get { return (double) num / (double) denom; }
        }
        public MyFrac() { }
        public MyFrac(BigInteger num, BigInteger denom)
        {
            this.num = num;
            this.denom = denom;
        }
        public double GetValue()
        {
            return ((double)num / (double)denom);
        }
        public MyFrac Add(MyFrac that)
        {
            return Normal(new MyFrac(this.num * that.denom + this.denom * that.num, this.denom * that.denom));
        }

        public MyFrac Divide(MyFrac that)
        {
            return Normal(new MyFrac(this.num * that.denom - this.denom * that.num, this.denom * that.denom));
        }

        public MyFrac Multiply(MyFrac that)
        {
            return Normal(new MyFrac(this.num * that.num, this.denom * that.denom));
        }

        public MyFrac Subtract(MyFrac that)
        {
            return Normal(new MyFrac(this.num * that.denom, this.denom * that.num));
        }
        public MyFrac Normal(MyFrac T)
        {
            BigInteger a, b;
            a = T.num;
            b = T.denom;
            while(b!= a && -b != a)
            {
                if (a > b) { a = a - b; }
                else { b = b - a; }
            }
            return new MyFrac(T.num / a, T.denom / a);
        }
        public int CompareTo(object o)
        {
            MyFrac one = o as MyFrac;
            if (Value > one.Value)
            {
                return 1;
            }
            else if (Value == one.Value)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public override string ToString()
        {
            try
            {
                return num + "/" + denom;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }
    }
}
