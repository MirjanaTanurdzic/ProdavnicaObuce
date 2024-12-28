using ProdavnicaObuceM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProdavnicaObuceM.Models
{
    public class ZenskaObuca:Narudzbenica
    {
        [Required(ErrorMessage = "Molim Vas unesite potreban broj obuće."), Range(36,40, ErrorMessage = "Molim Vas unesite ispravan broj obuće.")]
        public int ZenskiBroj { get; set; }
    }
}