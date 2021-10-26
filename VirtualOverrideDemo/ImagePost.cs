using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class ImagePost : Post
    {

        public string ImageURL { get; set; }


        public ImagePost() { }

        public ImagePost(string url, string title, string username, bool isPublic)
        {
            // inherited from base class (Post)
            ID = GetNextID();
            Title = title;
            SendByUsername = username;
            IsPublic = isPublic;
            
            // not inherited from base class (Post)
            ImageURL = url;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} by {3}", ID, Title, ImageURL, SendByUsername);
        }
    }
}
