using Rating.Models;

namespace Rating.Services;

public interface IRatingService
{
    void CreateRating(Ratings ratings);
    Ratings GetRating(Guid id);
    void UpdateRating(Ratings ratings);
    void DeleteRating(Guid id);
}