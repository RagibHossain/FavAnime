using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.AnimeReviews;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimeReviewsController
    {
        private readonly IMediator _mediator;
        public AnimeReviewsController(IMediator mediator)
        {

            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<AnimeReview>>> DisplayAllReviews()
        {

            return await _mediator.Send(new DisplayAllReviews.Query());
        }

        [HttpPost]

        public async Task<ActionResult<Unit>> AddReview(AddReview.Command command)
        {
            
            return await _mediator.Send(command);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> DeleteReview(Guid id)
        {
          // command.Id = id;
           return await _mediator.Send(new DeleteReview.Command{Id = id});
              
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Unit>> UpdateReview(Guid id, UpdateReview.Command command)
        {
             command.Id = id;
            return await _mediator.Send(command); 
        }

    }
}