using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Commands;

namespace CatWorkbookPrismPoc.Infrastructure.Commands
{
    public class ApplicationCommands
    {
        public static CompositeCommand OpenProgram = new CompositeCommand();
    }
}
