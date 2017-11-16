
using System;

namespace VsCodeProOne.Patterns.AbstractFactoryPattern
{
    public class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside::red::fill() method");
        }
    }

}