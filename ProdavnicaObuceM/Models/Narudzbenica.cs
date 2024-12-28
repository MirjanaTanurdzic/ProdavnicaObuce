using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProdavnicaObuceM.Models
{
    public class Narudzbenica
    {
        public string Naziv { get; set; }
        public string Brend { get; set; }
        public string Cena { get; set; }
        public string Tip { get; set; }
        [Required(ErrorMessage = "Molim Vas unesite Vaše ime i prezime..")] 
        public string ImePrezime { get; set; }
        [Required(ErrorMessage = "Molim Vas unesite Vašu email adresu."), EmailAddress(ErrorMessage = "Molim Vas unesite ispravnu Email adresu, uključujući '@'.")] 
        public string Email { get; set; }
        [Required(ErrorMessage = "Molim Vas unesite Vaš broj telefona."), MaxLength(11,ErrorMessage = "Molim Vas unesite ispravan broj telefona.")] 
        public string Mobilni { get; set; }
        [Required(ErrorMessage = "Molim Vas unesite Vašu adresu.")] 
        public string Adresa { get; set; }
        [Required(ErrorMessage = "Molim Vas unesite naziv grada.")] 
        public string Grad {  get; set; }
        public bool Pravilnik { get; set; }
    }
}