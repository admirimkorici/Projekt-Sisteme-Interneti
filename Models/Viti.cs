using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projekt_Sisteme_Interneti.Models
{
    [Table("Viti")]
    public class Viti
    {
        public int Id { get; set; }
        public int NrViti { get; set; }
    }
}