using System.ComponentModel.DataAnnotations;

namespace Ingresso.Core.Models;

public class Horario
{
    public Guid Id { get; set; }
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime hora_e_dia { get; set; }
    
    public Preco preco { get; set; }
    public Guid preco_Id { get; set; } 
    
    public Sala sala { get; set; }
    public Guid sala_Id { get; set; }

    public Movie movie { get; set; }
    public Guid movie_Id { get; set; }
}