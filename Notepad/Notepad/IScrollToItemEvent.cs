﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    interface IScrollToItemEvent
    {
        event EventHandler<NotepadPage> ScrollToItem;
    }
}
