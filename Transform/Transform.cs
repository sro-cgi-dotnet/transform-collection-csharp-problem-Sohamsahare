using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform{
        // Map() works on any collection which implements IEnumberable, Func is a
        // inbuilt delegate that transforms our collection according to the 
        // function passed to it.
        public static IEnumerable<TResult> Map<TSource, TResult>(this IEnumerable<TSource> input,Func<TSource,TResult> expressionFunc){
            return input.Select(expressionFunc);
        } 
    }
}
