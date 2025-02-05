using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInApp.Model
{
    
    
        public class Post
        {
            public string Author { get; set; }
            public string Content { get; set; }
            public string Image { get; set; }
        public int LikeCount { get; set; }
        public int CommentCount { get; set; }
        public string TimePosted { get; set; }
        public string JobTitle { get; set; }

    }



}
