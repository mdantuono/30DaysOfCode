using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numberOfLines = Convert.ToInt32(Console.ReadLine());
        List<string> lines = new List<string>();
        for(int i = 0; i < numberOfLines; i++) {
            lines.Add(Console.ReadLine());
        }
        List<string> evens = new List<string>();
        List<string> odds = new List<string>();

        for(int n = 0; n < lines.Count; n++) {
            string evenString = "";
            string oddString = "";
            for(int i = 0; i < lines[n].Length; i++) {
                if(i % 2 == 0) evenString += lines[n][i];
                else oddString += lines[n][i];
            }
            evens.Add(evenString);
            odds.Add(oddString);
        }

        for (int i = 0; i < evens.Count; i++) {
            Console.WriteLine(evens[i] + " " + odds[i]);
        }

    }
}
