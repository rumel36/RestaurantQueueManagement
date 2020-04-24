using System;
using System.Collections.Generic;
using System.Text;

namespace EventDemo
{
    public class MessageService
    {
        public void OnVideoEncodedMessage(object source, EventArgs args) {

            Console.WriteLine("Message Encoded....");
        }
    }
}
