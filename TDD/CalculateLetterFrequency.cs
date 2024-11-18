using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class CalculateLetterFrequencyClass
    {
        public static Dictionary<char, int> CalculateLetterFrequency(string text)
        {
            var frequency = new Dictionary<char, int>();

            foreach (char c in text)
            {
                char lowerCase = char.ToLower(c);
                if (frequency.ContainsKey(lowerCase))
                {
                    frequency[lowerCase]++;
                }
                else
                {
                    frequency[lowerCase] = 1;   
                }
            }
            return frequency;

            /*optional alt method*/
            var dic = new Dictionary<char,int>();
            foreach(char s in text)
            {
                if(!dic.TryAdd(s, 1))
                { dic[s]++; }
            }
            return dic;
        }
            
    }
}
