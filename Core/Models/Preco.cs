namespace Ingresso.Core.Models;

public class Preco
{
    public Guid Id { get; set; }
    public ulong Imposto { get; set; }
    public ulong Margem { get; set; }
    public Guid movie_id { get; set; }
    public Movies? movie { get; set; }
}