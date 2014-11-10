using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContextPlus.Configurator
{
    public interface IContextMenuService
    {
        IEnumerable<ContextMenuItem> 
    }

    public class ContextMenuItem
    {
        public string Caption { get; set; }
        public string CommandLine { get; set; }
    }

    internal class ContextMenuService : IContextMenuService
    {
        public IEnumerable<ContextMenuItem> 
        {
            throw new NotImplementedException();
        }
    }
}
