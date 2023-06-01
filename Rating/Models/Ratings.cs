namespace Rating.Models;

public class Ratings
{
    public Guid Id { get; }
    public string Name { get; }
    public int Rating { get; }
    public string Description { get; }
    public DateTime TimeCreated { get; }

    public Ratings(
        Guid id,
        string name,
        int rating,
        string description,
        DateTime timeCreated
    )
    {
        Id = id;
        Name = name;
        Rating = rating;
        Description = description;
        TimeCreated = timeCreated;
    }
}