using Domain.Interfaces;

namespace Domain.Models;

public struct Location: IEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}