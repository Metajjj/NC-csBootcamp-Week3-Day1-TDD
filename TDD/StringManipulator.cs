using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class StringManipulator
    {

        public static bool IsPalindrome(string input)
        {
            return input == String.Join("",input.Reverse() );
        }
    }
}
