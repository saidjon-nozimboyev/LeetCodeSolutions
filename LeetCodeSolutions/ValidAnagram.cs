using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            var first = s.ToArray();
            Array.Sort(first);
            var second = s.ToArray();
            Array.Sort(second);
            return first.ToString() == second.ToString();
        }
    }
}
