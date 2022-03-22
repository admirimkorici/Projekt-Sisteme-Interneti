using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projekt_Sisteme_Interneti.Models
{
    [Table("Dega")]
    public class Dega
    {
        public int Id { get; set; }
        public string Emri { get; set; }
    }
}