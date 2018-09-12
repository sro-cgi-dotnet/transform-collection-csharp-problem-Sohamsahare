using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public delegate int ExpressionDelegate(int number);
    public static class Transform 
    {
        public static int[] Map(this int[] numbers, ExpressionDelegate expressionDelegate)
        {
            int[] result = new int[numbers.Length];
            for(int i = 0; i < result.Length; i++){
                result[i] = expressionDelegate(numbers[i]);
            }
            return result;
        }
    }
}
