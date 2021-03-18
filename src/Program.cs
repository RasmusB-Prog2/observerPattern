using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new Channel();
            using var me = new User();
            me.Unsubscriber = channel.Subscribe(me);
            
            channel.UpdateString("test");
            me.Dispose();
        }
    }
}
