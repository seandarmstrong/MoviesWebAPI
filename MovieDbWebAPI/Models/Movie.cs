﻿namespace MovieDbWebAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}