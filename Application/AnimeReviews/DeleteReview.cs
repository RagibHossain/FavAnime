using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.AnimeReviews
{
    public class DeleteReview
    {
           public class Command : IRequest
                {
                 public Guid Id { get; set; }

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
                       
                        var review =await _context.AnimeReviews.FindAsync(request.Id);
                        
                        if(review == null) throw new Exception("no review found");
                        
                         _context.Remove(review);

                        var result =await _context.SaveChangesAsync() > 0;
        
                        if(result) return Unit.Value;
                       
                        throw new Exception("Problem occured saving data ");
        
                    }
                }
    }
}