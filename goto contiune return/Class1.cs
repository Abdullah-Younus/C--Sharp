﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto_contiune_return
{
    class Class1
    {
        static void Main(string[] args) 
        { 
            int num = 8; 
            int result; 
            result = Square(num);
            Console.WriteLine("Square of {0} = {1}", num, result);
        } 
        static int Square(object inum) 
        { 
            return (int)inum * (int)inum;
        }

    }
}
