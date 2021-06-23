using System;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumFromScreen = Convert.ToInt32(Console.ReadLine()) ;
            NumFromScreen = (NumFromScreen * NumFromScreen) + 14 - 3;
            Console.WriteLine(NumFromScreen);
        }
    }
}
