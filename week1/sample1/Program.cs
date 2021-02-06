using System;

namespace Week1
{
        class Program
        {
        public string DefangIPaddr(string address)
        {
            return new System.Text.StringBuilder(address).Replace(".", "[.]").ToString();
        }
    }

}
