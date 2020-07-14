using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.AnimeReviews
{
    public class DisplayAllReviews
    {
        public class Query : IRequest<List<AnimeReview>> { }

        public class Handler : IRequestHandler<Query, List<AnimeReview>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<AnimeReview>> Handle(Query request, CancellationToken cancellationToken)
            {
               

               var review = await _context.AnimeReviews.ToListAsync();                  
               return review;             
            
            }
        }
    }
}