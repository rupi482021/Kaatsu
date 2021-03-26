using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kaatsu.Models
{
    public class video
    {

       int videoId ;
       string description;
       string caption;
       string subtitlepath;

        public video(int videoId, string description, string caption, string subtitlepath)
        {
            VideoId = videoId;
            Description = description;
            Caption = caption;
            Subtitlepath = subtitlepath;
        }

        public video() { }

        public int VideoId { get => videoId; set => videoId = value; }
        public string Description { get => description; set => description = value; }
        public string Caption { get => caption; set => caption = value; }
        public string Subtitlepath { get => subtitlepath; set => subtitlepath = value; }


    }
}