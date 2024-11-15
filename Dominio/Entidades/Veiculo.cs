using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MinimalApi.Dominio.Entidade;

public class Veiculo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;

    [Required]
    [StringLength(255)]
    public string Nome { get; set; } = default!;

    [StringLength(100)]
    public string Marca { get; set; } = default!;

    public int Ano { get; set; } = default!;
}