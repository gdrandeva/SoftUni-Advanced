using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodFinder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray());
            Stack<char> consonants = new Stack<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray());

            char currentVowel = ' ';
            char currentConsonant =  ' ';

            
            
            List<string> food = new List<string>()
            {
                {"pear"},
                {"flour"},
                {"pork"},
                {"olive"}

            };
            List<string> validWords = new List<string>();
            HashSet<char> usedLetters = new HashSet<char>();

            while (consonants.Count != 0)
            {
                currentVowel = vowels.Dequeue();
                currentConsonant = consonants.Pop();

                foreach (var product in food)
                {
                    if (product.Contains(currentVowel))
                    {
                        usedLetters.Add(currentVowel);
                    }
                        vowels.Enqueue(currentVowel);
                    if (product.Contains(currentConsonant))
                    {
                        usedLetters.Add(currentConsonant);
                        
                    }
                }
            }

            foreach (var item in food)
            {
                if (string.Join("", item.Intersect(usedLetters))==item)
                {
                    validWords.Add(item);
                }
               
            }
            Console.WriteLine($"Words found: {validWords.Count}");
            foreach (var item in validWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
