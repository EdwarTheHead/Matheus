using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteAM4.Models
{
    public class Noticias
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage ="Campo obrigatório")]
        public string titulo { get; set; }

        [DisplayName("Chamada")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string chamada { get; set; }

        [DisplayName("Texto")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string texto { get; set; }

        public string imagem { get; set; }

        [DisplayName("Autor")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string autor { get; set; }

        public DateTime data { get; set; }
    }
}