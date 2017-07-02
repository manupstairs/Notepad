using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractivityAndCommand
{
    interface IShowMessage
    {
        event EventHandler<string> ShowMessageEvent;
    }
}
