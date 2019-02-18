using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Personagens.Domains
{
    public class PersonagensDomain
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:150,MinimumLength =3 , ErrorMessage = "Numero de caracteres inválido")]
        public string Personagens { get; set; }

        [Required]
        public string Lancamento { get; set; }
    }
}
