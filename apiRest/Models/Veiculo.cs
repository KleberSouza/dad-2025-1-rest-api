using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiRest.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo marca obrigatório!")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Campo modelo obrigatório!")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Campo placa obrigatório!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Campo ano obrigatório!")]
        public int Ano { get; set; }

        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
