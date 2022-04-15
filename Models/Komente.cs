using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekt_Sisteme_Interneti.Models
{
    public class Komente
    {
        [Required]
        public int ID { get; set; }
        [Required(ErrorMessage = "Fusha {0} eshte e detyruar")]
        [StringLength(15, ErrorMessage = "Fusha {0} duhet te jete midis 5 dhe 15 karaktere", MinimumLength = 5)]
        public string Emri { get; set; }
        [Required(ErrorMessage = "Fusha {0} eshte e detyruar")]
        [EmailAddress]
        public string Email { get; set; }
        public string Subjekti { get; set; }
        [Required(ErrorMessage = "Fusha {0} eshte e detyruar!")]
        public string Komenti { get; set; }

    }
}