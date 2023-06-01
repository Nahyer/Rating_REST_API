namespace Rating.Contracts.Ratings;
public record CreateRatingRequest(
    string Name,
    int Rating,
    string Description,
    DateTime TimeCreated
);