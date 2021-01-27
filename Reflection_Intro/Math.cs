using System;

namespace Reflection_Intro
{
    public class Math
    {
        int _number1;
        int _number2;
        public Math(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
       [MathAttritube("Sum Name")]
        public int sum(int number1,int number2)
        {
            return number1 + number2;
        }
        public int sum2()
        {
            return _number1 + _number2;
        }
    }
    public class MathAttritube : Attribute
    {
        public MathAttritube(string sumname)
        {

        }
    }
}
