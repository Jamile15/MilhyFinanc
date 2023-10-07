
using System.ComponentModel.DataAnnotations;

namespace MilhyFinancApi.Models;

public class Usuario
{
    [Required(ErrorMessage = "O campo nome do usuario é obrigatório")]
    [MaxLength(10, ErrorMessage = "O tamaho do nome não pode exceder 50 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo senha é obrigatória")]
    public string Senha { get; set; }

    [Required(ErrorMessage = "O campo Email é obrigatorio")]
    public string Email { get; set; }
}