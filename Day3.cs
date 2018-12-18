using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {
    static void isWeird(int n)
    {
        if (n%2 != 0) {
            Console.Write("Weird");
        } else if(n >= 2 && n <= 5) {
            Console.Write("Not Weird");
        } else if (n >= 6 && n <= 20) {
            Console.Write("Weird");
        } else if (n > 20 ) {
            Console.Write("Not Weird");
        }
    }


    static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        isWeird(N);
    }
}
