using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ingresso.Core.Models.Corporation;

namespace Ingresso.Core.Models;

public class Sala
{
    public Guid Id { get; set; }
    [Required]
    
    public Guid Corp_ID { get; set; }
    public Corp corp { get; set; }
    
    public ICollection<Horario>? horario { get; set; }
}