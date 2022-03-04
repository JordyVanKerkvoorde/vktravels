using System.Reflection.Metadata;
using Domain.Interfaces;

namespace Domain.Models;

public struct Picture: IEntity
{
    public Guid Id { get; set; }

    public string Caption { get; set; }
    public Blob ImageData { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}