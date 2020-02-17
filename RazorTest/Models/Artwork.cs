using System;

namespace RazorTest.Models
{
    public class Artwork
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public string SrcFile { get; set; }
    }
}