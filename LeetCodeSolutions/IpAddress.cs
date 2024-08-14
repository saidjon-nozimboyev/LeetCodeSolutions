using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class IpAddress
    {
        public string DefangIPaddr(string address)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')
                {
                    result.Append("[.]");
                }
                else
                {
                    result.Append(address[i]);
                }
            }

            return result.ToString();
        }
    }
}
