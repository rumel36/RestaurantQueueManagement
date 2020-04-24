using System;
using System.Collections.Generic;
using System.Text;

namespace EventDemo
{
    public class MailService
    {
        public void OnVideoEncodedMail(object source, EventArgs e) {

            Console.WriteLine("MailService: Sending email");
        
        }

    }
}
