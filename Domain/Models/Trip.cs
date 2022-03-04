using Domain.Interfaces;

namespace Domain.Models;

public struct Trip: IEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public Location Location { get; set; }
    public IEnumerable<Day> Days { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }          
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}