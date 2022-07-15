﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Helpers
{
    public static class Complexity
    {
        public static IEnumerable<T> Algo1<T>(IEnumerable<T> source)
        {
            Stack<T> stack = new Stack<T>();

            foreach (T item in source) 
            {
                stack.Push(item);
            }

             //return stack;
           return stack.ToList<T>();
        }
    }
}