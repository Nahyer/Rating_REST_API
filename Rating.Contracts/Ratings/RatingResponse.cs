namespace Rating.Contracts.Ratings;

public record RatingResponse(
    Guid id,
    string Name,
    int Rating,
    string description,
    DateTime TimeCreated
);