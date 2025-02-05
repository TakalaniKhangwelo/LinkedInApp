using LinkedInApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInApp.ViewModel
{ 
        public class HomePageViewModel
        {
            public ObservableCollection<Post> Posts { get; set; }

            public HomePageViewModel()
            {
                // Sample posts to simulate LinkedIn posts
                Posts = new ObservableCollection<Post>
            {
                new Post
                {
                    Author = "Vanessa Takalani",
                    Content = "Excited to be working with  awsome team!",
                    Image = "proj.jpg",
                     LikeCount = 267,
                    CommentCount = 42,
                    TimePosted = "2h",
                    JobTitle = "Software Engineer"
                },
                new Post
                  {
                    Author = "Khangwelo Takalani",
                    Content = "Learning .NET MAUI, it’s amazing!",
                    Image = "pic.jpg",
                     LikeCount = 189,
                    CommentCount = 28,
                    TimePosted = "4h",
                    JobTitle = "Mobile Developer"
                }

            };
        }
    }
}



