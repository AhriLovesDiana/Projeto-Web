using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Web.Models
{
    class CadastroModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(10)]
        public string User { get; set; }
        [Required]
        [MaxLength(100)]
        public string Senha { get; set; }
        [Required]
        [MaxLength(100)]
        public string Repitasenha { get; set; }
       
    }
}
