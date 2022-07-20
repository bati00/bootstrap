using biostar2_cli.utility;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace biostar2_cli.commands
{
    [Verb("logout", HelpText = "logout from server")]
    public class Logout : ICommand
    {
        public async Task Execute()
        {
            await Task.Delay(100);
            Console.WriteLine("logout");
            return; 
        }
    }

    [Verb("login", HelpText="login to server")]
    public class Login :ICommand
    {
        [Option('a', "Address", Required = false,Default="127.0.0.1", HelpText = "address to login")]
        public string Address { get; set; }
        [Option('i', "Identification", Required = false,Default="admin", HelpText = "ID to login")]
        public string Id { get; set; }
        [Option('p', "Password", Required = false,Default="", HelpText = "password to login")]
        public string Password { get; set; }

        public async Task Execute()
        {

            if (string.IsNullOrEmpty(Password)) {
                Password = SecureStringUtil.GetInputPassword(); 
            }

            await Task.Factory.StartNew( () => {
                Console.WriteLine(string.Format("login-{0},{1},{2}",Address,Id,Password));
            });
            
            
            return;

        }

        
    }
}
