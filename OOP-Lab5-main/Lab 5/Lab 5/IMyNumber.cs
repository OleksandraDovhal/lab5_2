using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab_5
{
    public interface IMyNumber<T> where T : IMyNumber<T>
    {
        T Add(T b);
        T Subtract(T b);
        T Multiply(T b);
        T Divide(T b);
    }
}
