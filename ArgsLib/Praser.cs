using System.Collections.Generic;

namespace ArgsLib
{
    public class Praser
    {
        private readonly LinkedList<string> _commandArgs = new LinkedList<string>();
        public Praser(string command)
        {
            
        }

        public string GetValue(string name)
        {
            return "/usr/local";
        }
    }
}