using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biostar2_cli.options
{
    class Options
    {
        [Option('a', "addr", HelpText = "Input an address to remote host.")]
        public string RemoteAddress { get; set; }

        [Option('p', "port", HelpText = "Input the number of port.", Default = 8025)]
        public int RemotePort { get; set; }

        [Option('u', "user_name", HelpText = "Input the user name to log on.", Default = "OEM Client")]
        public string UserName { get; set; }

        [Option('w', "password", HelpText = "Input the passphrase to log on.")]
        public string Passphrase { get; set; }

        [Option('o', "output", HelpText = "Input a file name to output.")]
        public string Output { get; set; }


        [Option('f', "offset", HelpText = "Offset to generate card", Default = 65536)]
        public int Offset { get; set; }


        [Option('g', "generate", HelpText = "Determine whether it allows the card generated.", Default = false)]
        public bool GenerateCard { get; set; }

    }
}
