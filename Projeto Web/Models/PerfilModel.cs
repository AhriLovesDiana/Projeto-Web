using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto_Web.Models
{
    class PerfilModel
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string DataNascimento { get; set; }

        [Required]
        [MaxLength(100)]
        public string Bio { get; set; }


    }
}
