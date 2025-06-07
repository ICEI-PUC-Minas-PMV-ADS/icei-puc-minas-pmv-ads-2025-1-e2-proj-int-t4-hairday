// Modelo Cliente
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Hairday.Models
{
    public class Cliente
    {
        [Key]
        public int id_cliente { get; set; }

        [Required, MaxLength(100)]
        public string nome { get; set; }

        [Required, EmailAddress]
        public string email { get; set; }

        [Required]
        public string senha { get; set; }

        public string cidade { get; set; }

        public string telefone { get; set; }

        [ValidateNever]
        public ICollection<Agendamento> agendamentos { get; set; }
    }
}