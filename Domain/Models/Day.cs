using Domain.Interfaces;

namespace Domain.Models;

public struct Day: IEntity
{
    public Guid Id { get; set; }

    public DateTime Date { get; set; }
    public IEnumerable<Location> Locations { get; set; }
    public IEnumerable<Picture> Pictures { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}