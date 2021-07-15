using System;
using System.IO;

namespace OrderedList
{
    class Program
    {
        /// <summary>
        /// P1-Linked list to read input from file and seaching for a word in the list 
        /// if present remove the word else insert the word 
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UnOrderedLinkedList<string> unOrdered = new UnOrderedLinkedList<string>();
            string filePath = @"C:\Users\HP1\source\repos\DataStructure1\OrderedList\FileToTest.txt";
            string text = File.ReadAllText(filePath);
            string[] textArray = text.Split(" ");
            for(int i=0;i<textArray.Length;i++)
            {
                unOrdered.AddLast(textArray[i]);
            }
            Console.WriteLine("enter the word to be searched:");
            string word = Console.ReadLine();
            int found = unOrdered.SearchNode(word);
            if(found==1)
            {
                unOrdered.DeleteNode(word);
            }
            else
            {
                unOrdered.AddLast(word);
            }
            string newText = unOrdered.DisplayList();
            File.WriteAllText(filePath, newText);
        }
    }
}
