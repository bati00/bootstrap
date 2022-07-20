using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biostar2_cli.commands
{
    public interface ICommand
    {
        Task Execute(); 
    }
}
