
using Microsoft.AspNetCore.Mvc;
using Rating.Contracts.Ratings;
using Rating.Models;
using Rating.Services;

namespace Rating.Controllers;

[ApiController]
[Route("[controller]")]
public class RatingsController : ControllerBase
{
    private readonly IRatingService _ratingService;

    public RatingsController(IRatingService ratingService)
    {
        _ratingService = ratingService;
    }

    [HttpPost]
    public IActionResult CreateRating(CreateRatingRequest request)
    {
        var rating = new Ratings(
            Guid.NewGuid(),
            request.Name,
            request.Rating,
            request.Description,
            DateTime.UtcNow);

        _ratingService.CreateRating(rating);

        var response = new RatingResponse(
           rating.Id,
           rating.Name,
           rating.Rating,
           rating.Description,
           DateTime.UtcNow
        );

        return CreatedAtAction(
            actionName: nameof(GetRating),
            routeValues: new { id = rating.Id },
            value: response
        );
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetRating(Guid id)
    {
        Ratings ratings = _ratingService.GetRating(id);
        var response = new RatingResponse(
           ratings.Id,
           ratings.Name,
           ratings.Rating,
           ratings.Description,
           DateTime.UtcNow
        );

        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdatRating(Guid id, UpdattRatingRequest request){
        
        var rating = new Ratings(
            id,
            request.Name,
            request.Rating,
            request.Description,
            request.TimeCreated
        );

        _ratingService.UpdateRating(rating);
        return NoContent();
    }

    [HttpDelete]
    public IActionResult DeletRating(Guid id){
        _ratingService.DeleteRating(id);
        return NoContent();
    }
}