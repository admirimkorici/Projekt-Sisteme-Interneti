using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projekt_Sisteme_Interneti.Models
{
    [Table("Ditet")]
    public class Ditet
    {
        public int Id { get; set; }
        public string Dita { get; set; }
        public string Lenda { get; set; }
        public string Pedagogu { get; set; }
        public string LlojiOres { get; set; }
        public int Ora { get; set; }
        public string Salla { get; set; }
        public int? DegaId { get; set; }
        public virtual Dega Dega { get; set; }
        public int? VitiId { get; set; }
        public virtual Viti Viti { get; set; }
        public int? GrupiId { get; set; }
        public virtual Grupi Grupi { get; set; }

    }
}