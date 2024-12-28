using ProdavnicaObuceM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProdavnicaObuceM.Models
{
    public class DecijaObuca:Narudzbenica
    {
        [Required(ErrorMessage ="Molim Vas izaberite odgovarajući uzrast.")]
        public string Uzrast { get; set; }
        [Required(ErrorMessage = "Molim Vas unesite potreban broj obuće."), Range(16,35, ErrorMessage = "Molim Vas unesite ispravan broj obuće.")]
        public int DecijiBroj {  get; set; }
    }
}