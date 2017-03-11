using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TallerMVC5.Models
{
    public class Contacto
    {        
        [Required]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]*$")]
        [StringLength(32)]
        public string Telefono { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El {0} no puede superar los {1} caracteres")]
        public string Comentario { get; set; }
    }
    
}