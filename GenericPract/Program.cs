using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> firstdictionary = new Dictionary<int, string>();
            Dictionary<int, string> secondDictionary = new Dictionary<int, string>();
            string  story = @"Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном  чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            
            string[] text = story.Split(new string[] { " ", ",", ".","\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            int value = 0;
            for (int i = 0; i < text.Length; i++)
            {
                firstdictionary.Add(i, text[i]);
            }
            for (int i = 0; i < firstdictionary.Count; i++)
            {
                if (!secondDictionary.ContainsValue(firstdictionary[i]))
                {
                    secondDictionary.Add(value++, firstdictionary[i]);
                }
            }
            int count = 0;
            for (int i = 0; i < secondDictionary.Count; i++)
            {
                if (secondDictionary[i] == " ")
                {
                    i++;
                }
                for (int j = 0; j < firstdictionary.Count; j++)
                {
                    if (secondDictionary[i] == firstdictionary[j])
                    {
                        count++;
                    }                    
                }
                Console.WriteLine($"{i} {secondDictionary[i],20} {count,20}");
                count = 0;
            }
            Console.WriteLine($"Всего слов: {firstdictionary.Count}, из них уникальных: {secondDictionary.Count}");
        }
    }
}
