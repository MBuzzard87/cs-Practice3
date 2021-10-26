using System;
using System.Threading;

namespace VirtualOverrideDemo
{
    class VideoPost : Post
    {
        Timer timer;
        protected bool isPlaying = false;
        protected int currDuration = 0;
        protected string VideoURL { get; set; }
        protected int Length { get; set; }


        public VideoPost() { }

        public VideoPost(string url, int length, string title, string username, bool isPublic)
        {
            // inherited from base class (Post)
            ID = GetNextID();
            Title = title;
            SendByUsername = username;
            IsPublic = isPublic;

            // not inherited from base class (Post)
            Length = length;
            VideoURL = url;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} Length: {3} by {4}", ID, Title, VideoURL, Length, SendByUsername);
        }

        public void Play()
        {
            if(!isPlaying)
            {

                Console.WriteLine("Playing");
                isPlaying = true;
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}", currDuration);
                GC.Collect();
            } else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Video stopped at {0} seconds", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
            
        }


    }
}
