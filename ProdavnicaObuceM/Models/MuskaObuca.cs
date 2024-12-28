using ProdavnicaObuceM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProdavnicaObuceM.Models
{
    public class MuskaObuca:Narudzbenica
    {
        [Required(ErrorMessage = "Molim Vas unesite potreban broj obuće."), Range(40,48, ErrorMessage = "Molim Vas unesite ispravan broj obuće.")]
        public int MuskiBroj {  get; set; }
    }
}