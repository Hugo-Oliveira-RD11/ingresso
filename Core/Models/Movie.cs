using System.ComponentModel.DataAnnotations;

namespace Ingresso.Core.Models;

public class Movie
{
    public Guid? Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.MultilineText)]
    public string? Description { get; set; }
    public uint Minutes { get; set; }
    
    public ICollection<Horario> horarios { get; set; }
}