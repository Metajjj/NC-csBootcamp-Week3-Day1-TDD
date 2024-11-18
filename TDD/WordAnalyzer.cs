using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class WordAnalyzer
    {
        public static string FindLongestWord(string text)
        {
            var splitText = text.Split(' ').ToList();

            string txt=""; int len = 0;
            foreach (var word in splitText)
            {
                if (len < word.Length) { len = word.Length; txt = word; }
            }


            return txt;
        }
    }
}
