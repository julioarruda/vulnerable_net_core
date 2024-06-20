using System;
using System.Diagnostics;

namespace vulnerable_asp_net_core.Utils
{
    [Serializable]
    public class Executable
    {
        // Incluido por GFT AI Impact Bot
        private string _cmd = "ls";
        private string _param = "";

        // Incluido por GFT AI Impact Bot
        public string Cmd
        {
            get { return _cmd; }
            set
            {
                if (value != "ls")
                    Console.WriteLine("Invalid command");
                else
                    _cmd = value;
            }
        }

        // Incluido por GFT AI Impact Bot
        public string Param
        {
            get { return _param; }
            set { _param = value; }
        }

        public Executable() {}

        // Alterado por GFT AI Impact Bot
        public Executable(string cmd, string param)
        {
            Cmd = cmd;
            Param = param;
        }

        public string Run()
        {
            return "Execute `" + Cmd + " " + Param + "`";
        }
    }
}