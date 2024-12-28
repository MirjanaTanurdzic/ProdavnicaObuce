using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProdavnicaObuceM.Models
{
    public class mainModel
    {
        public Narudzbenica Narudzbenica { get; set; }
        public MuskaObuca MuskaObuca { get; set; }
        public ZenskaObuca ZenskaObuca { get;set; }
        public DecijaObuca DecijaObuca { get; set;}
    }
}