using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ArgsLib
{
    public class Praser
    {
        private readonly Dictionary<string, string> _commandArgs = new Dictionary<string, string>();
        public Praser(string command)
        {
            var cmdArr = command.Split(" ");
            

            for (int i = 0; i < cmdArr.Length; i = i + 2)
            {
                if (i + 1 == cmdArr.Length || !IsValue(cmdArr[i + 1]))
                {
                    AddCommand(cmdArr[i], "true");
                    i--;
                    continue;
                }
                AddCommand(cmdArr[i], cmdArr[i + 1]);

            }

        }

        private bool IsValue(string str)
        {
            if (!str.StartsWith("-"))
            {
                return true;
                
            }
            var temp = str.Substring(1);
            if (temp.Length > 1 || (temp[0] >= '0' && temp[0] <= '9'))
            {
                return true;
            }

            return false;

        }

        public string GetValue(string name)
        {
            if (!_commandArgs.TryGetValue(name, out string result))
            {
                throw new ArgumentException($"未找到参数{name}的值");
            }
            return result;
        }

        private void AddCommand(string cmdKey, string cmdValue)
        {
            _commandArgs.Add(cmdKey.Substring(1), cmdValue);
        }

    }
}