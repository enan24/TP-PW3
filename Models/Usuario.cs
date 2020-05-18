using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP_PW3.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required (ErrorMessage="Se requiere el ingreso de Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Se requiere el ingreso de Contraseña")]
        //[RegularExpression(@"/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&#.$($)$-$_])[A-Za-z\d$@$!%*?&#.$($)$-$_]{8,15}$/", ErrorMessage ="La contraseña debe poseer al menos una mayuscula, una minuscula,  y un digito")]
        [StringLength(12,MinimumLength =8,ErrorMessage ="La contraseña debe poseer al meonos 8 caracteres")]
        [Compare("RePassword",ErrorMessage = "Las contraseñas deben coincidir")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Se requiere el re-ingreso de Contraseña")]
        public string RePassword { get; set; }
        [Required(ErrorMessage ="Requerido")]
        [Range(18,Int32.MaxValue, ErrorMessage ="Debe ser mayor de 18 años")]
        public int Edad { get; set; }

       
    }
}