using System;

namespace Domain
{
    public class AnimeReview
    {
        public AnimeReview(string title,int rating, string review)
        {
            this.Title = title;
            this.Rating = rating;
            this.Review = review;
        }

        public AnimeReview(Guid id, string title, int rating, string review)
        {
            Id = id;
            Title = title;
            Rating = rating;
            Review = review;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public int Rating { get; set; }

        public string Review { get; set; }

    }
}