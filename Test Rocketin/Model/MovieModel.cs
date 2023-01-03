using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Rocketin.Model
{
    public class MovieModel
    {
        public int id_movie { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string artis { get; set; }
        public int? duration { get; set; }
        public string genres { get; set; }
        public string watch_url { get; set; }

        public int TakePage { get; set; }
        public int TakeCount { get; set; }

    }

    public class MovieViewship
    {
        public int most_viewed_id_movie { get; set; }
        public string most_viewed_movie_title { get; set; }
        public int? most_viewed_movie_count { get; set; }
        
        public string most_viewed_genre { get; set; }
        
    }
}