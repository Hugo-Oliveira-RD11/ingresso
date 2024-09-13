namespace Ingresso.Core.Models;

public class Movies
{
    public Guid? Id { get; set; }
    public string? Title { get; set; }
    public uint Minutes { get; set; }
    public Guid preco_id { get; set; }
    public Preco preco { get; set; }
    public ICollection<Horarios> horarios { get; set; }
}