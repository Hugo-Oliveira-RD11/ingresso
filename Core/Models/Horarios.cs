namespace Ingresso.Core.Models;

public class Horarios
{
    public Guid Id { get; set; }
    public Guid Id_Preco { get; set; }
    public Guid Id_Movie { get; set; }
    public Preco Preco { get; set; }
    public Movies movie { get; set; }
}