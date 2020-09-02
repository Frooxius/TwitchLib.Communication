using System;

namespace TwitchLib.Communication.Events
{
    public class OnErrorEventArgs : EventArgs
    {
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
