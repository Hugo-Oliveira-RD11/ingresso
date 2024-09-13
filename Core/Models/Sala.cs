using System.ComponentModel.DataAnnotations;
using Ingresso.Core.Models.Corporation;

namespace Ingresso.Core.Models;

public class Sala
{
    public Guid Id { get; set; }
    [Required]
    public Guid Id_Corp { get; set; }
    public Corp corp { get; set; }
    
    public Guid Id_Sala { get; set; }
    public Sala sala { get; set; }
}