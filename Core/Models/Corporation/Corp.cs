using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace Ingresso.Core.Models.Corporation;

public class Corp
{
    public string? Name_Cinema { get; set; }
    public Guid Id { get; set; }
    [Required]
    public string? CNPJ  { get; set; }
    [Required]
    [DataType(DataType.EmailAddress)]
    public string email  { get; set; } = string.Empty;
    [Required]
    [DataType(DataType.Password)]
    public string password { get; set; } = string.Empty;

    public ICollection<Sala> SalaCollection { get; set; }
}