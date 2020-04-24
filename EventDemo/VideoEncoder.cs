using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventDemo
{
    public class VideoEncoder
    {

        public delegate void VideoEnCodedEventHandler(object source, EventArgs args);
        public event VideoEnCodedEventHandler VideoEncoded;

        public void Encode(VideoPoco video)
        {
            Console.WriteLine("Encoding Videos..");
            Thread.Sleep(3000);
           
            OnVideoEncoded();
         }

        protected virtual void OnVideoEncoded()
        {

            if (VideoEncoded != null) 
                VideoEncoded(this, EventArgs.Empty);
            

        }

    }

}
