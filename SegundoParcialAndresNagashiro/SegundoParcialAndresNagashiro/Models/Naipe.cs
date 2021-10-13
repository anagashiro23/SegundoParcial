using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAndresNagashiro.Models
{
    public class Naipe
    {
        [Key]
        public string naipe { get; set; }
        [Display(Name = "Nombre de la carta")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El nombre debe contener entre 3 a 60 caracteres")]
        [Required(ErrorMessage = "El nombre del naipe es requerido")]
        public string carta { get; set; }
        [Display(Name = "nombre del naipe")]
        public string nombre { get; set; }
        [Url]
        [Display(Name = "link de la imagen")]
        public string imagen { get; set; }


    }
}
