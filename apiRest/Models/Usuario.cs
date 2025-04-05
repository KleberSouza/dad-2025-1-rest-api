using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiRest.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo nome obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo e-mail obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        public List<Veiculo> Veiculos { get; set; }
    }
}
