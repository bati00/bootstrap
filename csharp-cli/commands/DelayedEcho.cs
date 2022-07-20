using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biostar2_cli.commands
{

    [Verb("echo", HelpText = "echo")]
    public class DelayedEcho : ICommand
    {
        [Option('d', "delay time(ms)", Required = false, Default = 0, HelpText = "set the delay time(ms)")]
        public int DelayTime{ get; set; }

        [Option('m', "message", Required = false, Default = "", HelpText = "set the message.")]
        public string Message { get; set; }

        public async Task Execute()
        {

            if (DelayTime >0) {
                await Task.Delay(DelayTime);
            }
            await Task.Factory.StartNew(()=>{Console.WriteLine(Message);}); 
            return;
        }
    }
}
