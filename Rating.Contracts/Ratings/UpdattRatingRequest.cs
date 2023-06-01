namespace Rating.Contracts.Ratings;

public record UpdattRatingRequest(
    Guid Id,
    string Name,
    int Rating,
    string Description,
    DateTime TimeCreated
);