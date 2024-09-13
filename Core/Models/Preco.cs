namespace Ingresso.Core.Models;

public class Preco
{
    public Guid Id { get; set; }
    public ulong Imposto { get; set; }
    public ulong Margem { get; set; }
    public Guid horario_Id { get; set; }
    public Horario horario { get; set; }
}