using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace HTML_HELPERS.Models
{
    public class Cliente
    {
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }

        [Range(15, 99, ErrorMessage = "Debes ser mayor a 15")]
        public int Edad { get; set; }

        public string Telefono { get; set; }

        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }




        public string ClienteGenero { get; set; }


        public string Estado { get; set; }

        public bool Hobbys { get; set; }

        public bool Basketball { get; set; }
        public bool Baseball { get; set; }
        public bool Tennis { get; set; }




    }
}