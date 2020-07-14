using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.AnimeReviews
{
    public class AddReview
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }

            public string Title { get; set; }

            public int Rating { get; set; }

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
                var animeReview = new AnimeReview(request.Id,request.Title,request.Rating,request.Review);

                 _context.AnimeReviews.Add(animeReview);
                
                 await _context.SaveChangesAsync();    
                 
                 return Unit.Value;
            }
        }
    }
}