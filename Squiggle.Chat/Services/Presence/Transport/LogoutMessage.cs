﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Squiggle.Chat.Services.Presence.Transport
{
    [Serializable]
    class LogoutMessage : Message
    {
        public IPEndPoint ChatEndPoint { get; set; }
    }
}