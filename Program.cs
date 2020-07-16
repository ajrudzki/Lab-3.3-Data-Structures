using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Lab_3._3_Data_Structures
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.Write($"Please enter a word you would like to reverse: ");
            string entry  = Console.ReadLine();
            
            Console.WriteLine($"Your word in reverse is: {reverse(entry)}");
        }

        static string reverse(string word)
        {

            Stack<char> myStack = new Stack<char>();
            
            for(int i =0 ; i < word.Length; i++)
            {
                myStack.Push(word[i]);
            }

            string reverseWord = null;

            while (myStack.Count != 0)
            {
                reverseWord += myStack.Pop();
            }

            return reverseWord;

        }
                        
    }
    
}
