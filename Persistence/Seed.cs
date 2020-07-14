using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {

        public static void SeedData(DataContext context)
        {
            if(!context.AnimeReviews.Any()){
                var animeReviews = new List<AnimeReview>{
                new AnimeReview("Naruto Shippuden",10,"The best show on the planet . Hats off to the director"),
                new AnimeReview("Naruto Shonen Jump",10,"The best show on the planet . Hats off to the director"),
                new AnimeReview("Dragon ball Z",10,"This one is also a great show . I have been watching it since childhood so i have my emotion attached to this show "),
                new AnimeReview("Death Note",10,"Must watch show"),
                new AnimeReview("Full metal Alchemist",10,"I haven't watched it yet but i will surely watch it next")
            };

               
                context.AnimeReviews.AddRange(animeReviews);
               
                context.SaveChanges();
            
            }

        }
    }
}