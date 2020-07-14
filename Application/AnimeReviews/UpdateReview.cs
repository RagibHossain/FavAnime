using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.AnimeReviews
{
    public class UpdateReview
    {
           public class Command : IRequest
              {
        
                public Guid Id { get; set; }

               public string Title { get; set; }

               public int? Rating { get; set; }

               public string Review { get; set; }
              
              }
        
                public class Handler : IRequestHandler<Command>
                {
                    private readonly DataContext _context;
                    public Handler(DataContext context)
                    {
                        _context = context;
        
                    }
        
                    public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
                    {
                        var review = await _context.AnimeReviews.FindAsync(request.Id);
                        if(review == null) throw new Exception("No review found ");

                        review.Rating = request.Rating ?? review.Rating;
                        review.Review = request.Review ?? review.Review;
                        review.Title = request.Title ?? review.Title;

                        var result =await _context.SaveChangesAsync() > 0;
        
                        if(result) return Unit.Value;
                       
                        throw new Exception("Problem saving data");
        
                    }
                }
    }
}