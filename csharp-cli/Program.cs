using biostar2_cli.commands;
using biostar2_cli.options;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biostar2_cli
{

    class Program
    {
        
        static void Main(string[] args)
        
        {
        
            //var options = new Options();
            //try{
                                
            //    CommandLine.Parser.Default.ParseArguments<Options>(args).WithParsed<Options>(opts => options = opts);
            //}catch(Exception e) {
            //    Debug.Write(e);
            //}
            string line;
            while ((line = Console.ReadLine()) != "x") {
                if (line.Length == 0) continue;
                //Console.WriteLine(line.Length);
                string[] words = line.Split(' ');
                string command = words[0];
                List<string> remaining=words.ToList();
                remaining.RemoveAt(0);
                string[] param = remaining.ToArray();
                //foreach (string p in param)
                //{
                //    Console.WriteLine(p);
                //}
                try
                {
                    CommandLine.Parser.Default.ParseArguments<Login, Logout, DelayedEcho>(words).WithParsedAsync<ICommand>(t => t.Execute());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e); 
                }

            }
        }
    }
}
