using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    string sentence = Console.ReadLine();
    List<string> list = new List<string>();
    list.Add(sentence);
    Console.Write(sentence);
    List<string> list = new List<string>();
    list.Add(sentence);
    
    
    
    
    
    return (sentence);
  }
}

/*

using System;  
                      
public class CountWords  
{  
    public static void Main()  
    {  
        String sentence = "Beauty lies in the eyes of beholder";  
        int wordCount = 0;  
          
        for(int i = 0; i < sentence.Length-1; i++) {  
            //Counts all the spaces present in the string  
            //It doesn't include the first space as it won't be considered as a word  
            if(sentence[i] == ' ' && Char.IsLetter(sentence[i+1]) && (i > 0)) {  
                wordCount++;  
            }  
        }  
        //To count the last word present in the string, increment wordCount by 1  
        wordCount++;  
          
        //Displays the total number of words present in the given string  
        Console.WriteLine("Total number of words in the given string: " + wordCount);  
    }-  
}             


// C# program to find the 
// the total number of 
// elements in 1-D Array 
using System; 
namespace geeksforgeeks { 
  
class GFG { 
  
    // Main Method 
    public static void Main() 
    { 
  
        // declares a 1D Array of string. 
        string[] weekDays; 
  
        // allocating memory for days. 
        weekDays = new string[] {"Sun", "Mon", "Tue", "Wed", 
                                       "Thu", "Fri", "Sat"}; 
  
        // Displaying Elements of the array 
        foreach(string day in weekDays) 
            Console.Write(day + " "); 
  
        Console.Write("\nTotal Number of Elements: "); 
  
        // using Length property 
        Console.Write(weekDays.Length); 
    } 
} 
}

*/
