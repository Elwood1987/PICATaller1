using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller1.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "El primer apellido es obligatorio")]
        [Display(Name = "Primer Apellido")]
        [MaxLength(length: 30, ErrorMessage = "El apellido no puede ser mayor a 30")]
        public String primerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        [MaxLength(length: 30, ErrorMessage = "El apellido no puede ser mayor a 30")]
        public String segundoApellido { get; set; }

        [Required(ErrorMessage = "El primer nombre es obligatorio")]
        [Display(Name = "Primer Nombre")]
        [MaxLength(length: 30, ErrorMessage = "El nombre no puede ser mayor a 30")]
        public String  primerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        [MaxLength(length: 30, ErrorMessage = "El segundo nombre no puede ser mayor a 30")]
        public String segundoNombre { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "El correo ingresado no es correcto")]
        public String email { get; set; }

        [Required(ErrorMessage = "El número de telefono ingresado no es correcto")]
        [Display(Name = "Teléfono")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d*$", ErrorMessage = "El número de telefono ingresado no es correcto")]
        public String telefono { get; set; }
        
    }
}
