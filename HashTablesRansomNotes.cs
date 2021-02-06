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
    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach(var i in magazine){
            if(!dict.ContainsKey(i)){
                dict.Add(i, 1);
            }
            else{
                dict[i]++;
            }
        }
        try{
            foreach(var i in note){
                if(dict[i]<1){
                    Console.WriteLine("No");
                    return;
                }
                else{
                    dict[i]--;
                }
            }    
        }
        catch (Exception ex){
            Console.WriteLine("No");
            return;
        }
        Console.WriteLine("Yes");
    }

    static void Main(string[] args) {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
