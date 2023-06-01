using Rating.Models;

namespace Rating.Services;

public class RatingService : IRatingService
{
    private static readonly Dictionary<Guid, Ratings> _ratings = new ();
    public void CreateRating(Ratings ratings)
    {
        _ratings.Add(ratings.Id, ratings); 
    }

    public void DeleteRating(Guid id)
    {
        _ratings.Remove(id);
    }

    public Ratings GetRating(Guid id)
    {
       return _ratings[id];
    }

    public void UpdateRating(Ratings ratings)
    {
        _ratings[ratings.Id] = ratings;
    }

}